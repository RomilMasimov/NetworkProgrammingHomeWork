using LostServer.Data;
using LostServer.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LostServer
{
    public class Server
    {
        private HttpListener listener;
        private ApplicationContext dbContext;

        public Server(string prefixe, string connectionString)
        {
            listener = new HttpListener();
            listener.Prefixes.Add(prefixe);
            dbContext = new ApplicationContext(connectionString);
        }

        public async Task StartAsync()
        {
            listener.Start();

            while (true)
            {
                var httpContext = await listener.GetContextAsync();
                var request = httpContext.Request;
                var response = httpContext.Response;
                if (request.HttpMethod == "GET")
                {
                    var dataString = "";

                    var splitUrl = request.RawUrl.Split('/', '?');
                    var requestType = splitUrl[1].ToLower();
                    var stream = response.OutputStream;
                    if (requestType == "getpoteryashkas")
                    {
                        var data = await dbContext.Poteryashkas.ToListAsync();

                        var surname = request.QueryString["surname"];
                        var stringAge = request.QueryString["age"];
                        var stringLostFrom = request.QueryString["lostfrom"];
                        var stringLostTo = request.QueryString["lostto"];

                        if (!string.IsNullOrWhiteSpace(surname))
                        {
                            data = data.Where(m => m.Surname.ToLower() == surname.ToLower()).ToList();
                        }
                        if (!string.IsNullOrWhiteSpace(stringAge))
                        {
                            if (int.TryParse(stringAge, out var age))
                                data = data.Where(m => m.Age == age).ToList();
                        }
                        if (!string.IsNullOrWhiteSpace(stringLostFrom))
                        {
                            if (DateTime.TryParse(stringLostFrom, out var lostFrom))
                                data = data.Where(m => m.Lost?.ToShortDateString() == lostFrom.ToShortDateString()).ToList();
                        }
                        if (!string.IsNullOrWhiteSpace(stringLostTo))
                        {
                            if (DateTime.TryParse(stringLostTo, out var lostTo))
                                data = data.Where(m => m.Found?.ToShortDateString() == lostTo.ToShortDateString()).ToList();
                        }
                        dataString = JsonConvert.SerializeObject(data, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                    }
                    else if (requestType == "getpoteryashkaseen")
                    {
                        var stringId = splitUrl.Length > 2 ? splitUrl[2] : null;
                        if (!string.IsNullOrWhiteSpace(stringId))
                        {
                            if (!int.TryParse(stringId, out var id))
                            {
                                httpContext.Response.StatusCode = 400;
                                httpContext.Response.Close();
                                continue;
                            }

                            var data = await dbContext.Seens.Where(m => m.Who.Id == id).ToListAsync();
                            dataString = JsonConvert.SerializeObject(data, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                        }
                        else
                        {
                            httpContext.Response.StatusCode = 400;
                            httpContext.Response.Close();
                            continue;
                        }
                    }
                    else
                    {
                        httpContext.Response.StatusCode = 404;
                        httpContext.Response.Close();
                        continue;
                    }

                    using (var writer = new StreamWriter(stream))
                    {
                        await writer.WriteLineAsync(dataString);
                    }
                    httpContext.Response.StatusCode = 200;
                    httpContext.Response.Close();
                    continue;
                }
                else if (request.HttpMethod == "POST")
                {
                    var splitUrl = request.RawUrl.Split('/');
                    var dataType = splitUrl[1].ToLower();
                    if (dataType == "addpoteryashka")
                    {
                        Poteryashka poteryashka = null;
                        var inputStream = request.InputStream;
                        using (var streamReader = new StreamReader(inputStream))
                        {
                            poteryashka = JsonConvert.DeserializeObject<Poteryashka>(streamReader.ReadToEnd());
                        }
                        if (poteryashka != null)
                        {
                            dbContext.Poteryashkas.Add(poteryashka);
                            await dbContext.SaveChangesAsync();
                            var dataString = JsonConvert.SerializeObject(poteryashka);
                            var outputStream = response.OutputStream;
                            using (var streamWriter = new StreamWriter(outputStream))
                            {
                                await streamWriter.WriteLineAsync(dataString);
                            }
                            response.StatusCode = 200;
                            response.Close();
                            continue;
                        }
                        response.StatusCode = 400;
                        response.Close();
                        continue;
                    }
                    else if (dataType == "haveseenpoteryashka")
                    {
                        Seen seen = null;
                        var inputStream = request.InputStream;
                        using (var streamReader = new StreamReader(inputStream))
                        {
                            seen = JsonConvert.DeserializeObject<Seen>(streamReader.ReadToEnd());
                        }
                        if (seen != null)
                        {
                            var poteryashkas = dbContext.Poteryashkas.Find(seen.Who.Id);
                            seen.Who = null;
                            poteryashkas.Seen.Add(seen);
                            await dbContext.SaveChangesAsync();
                            var dataString = JsonConvert.SerializeObject(seen, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                            var outputStream = response.OutputStream;
                            using (var streamWriter = new StreamWriter(outputStream))
                            {
                                await streamWriter.WriteLineAsync(dataString);
                            }
                            response.StatusCode = 200;
                            response.Close();
                            continue;
                        }
                        response.StatusCode = 400;
                        response.Close();
                        continue;
                    }
                    else
                    {
                        httpContext.Response.StatusCode = 404;
                        httpContext.Response.Close();
                        continue;
                    }
                }
                else if (request.HttpMethod == "PUT")
                {
                    var splitUrl = request.RawUrl.Split('/');
                    var dataType = splitUrl[1].ToLower();
                    if (dataType == "poteryashkafound")
                    {
                        FoundInfo info = null;
                        var stream = request.InputStream;
                        using (var streamReader = new StreamReader(stream))
                        {
                            info = JsonConvert.DeserializeObject<FoundInfo>(streamReader.ReadToEnd());
                        }
                        if (info != null)
                        {
                            var p = await dbContext.Poteryashkas.FindAsync(info.PoteryashkaId);
                            p.IsFound = true;
                            p.Found = info.Date;
                            await dbContext.SaveChangesAsync();
                            response.StatusCode = 200;
                            response.Close();
                            continue;
                        }
                        response.StatusCode = 400;
                        response.Close();
                    }
                    else if (dataType == "updatepoteryashka")
                    {
                        Poteryashka poteryashka = null;
                        var inputStream = request.InputStream;
                        using (var streamReader = new StreamReader(inputStream))
                        {
                            poteryashka = JsonConvert.DeserializeObject<Poteryashka>(streamReader.ReadToEnd());
                        }
                        if (poteryashka != null)
                        {
                            var originalPoteryashka = await dbContext.Poteryashkas.FindAsync(poteryashka.Id);
                            originalPoteryashka.Name = poteryashka.Name;
                            originalPoteryashka.Surname = poteryashka.Surname;
                            originalPoteryashka.Age = poteryashka.Age;
                            originalPoteryashka.AdditionalInfo = poteryashka.AdditionalInfo;
                            originalPoteryashka.Phone = poteryashka.Phone;
                            originalPoteryashka.Lost = poteryashka.Lost;
                            await dbContext.SaveChangesAsync();
                            response.StatusCode = 200;
                            response.Close();
                            continue;
                        }
                        response.StatusCode = 400;
                        response.Close();
                        continue;
                    }
                    else
                    {
                        httpContext.Response.StatusCode = 404;
                        httpContext.Response.Close();
                        continue;
                    }
                }
            }
        }
    }
}
