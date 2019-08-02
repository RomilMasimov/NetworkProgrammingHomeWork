using LostClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LostClient.View
{
    public partial class MainForm : Form
    {
        public Client clien = new Client("http://localhost:27001/");
        public MainForm()
        {
            InitializeComponent();
            LoadPoteryashkas();
        }

        private async Task LoadPoteryashkas(string surname = null,
                                            int? age = 0,
                                            DateTime? lostTo = null,
                                            DateTime? lostFrom = null)
        {
            var poteryashkas = await clien.GetPoteryashkasAsync(surname, age, lostTo, lostFrom);

            this.poteryashkasListView.Items.Clear();
            foreach (var p in poteryashkas)
            {
                var item = new ListViewItem(
                    new string[]
                    {
                        p.Id.ToString(),
                        p.Name + " " + p.Surname,
                        p.Age.ToString(),
                        p.AdditionalInfo,
                        p.Phone,
                        p.Lost?.ToShortDateString(),
                        p.Found?.ToShortDateString(),
                        p.IsFound.ToString()
                    });
                item.Tag = p;
                this.poteryashkasListView.Items.Add(item);
            }
        }

        private void LoadPoteryashkasWithFormParams()
        {
            int? age = null;
            if (this.AgeMaskedTextBox.MaskCompleted)
                age = int.Parse(this.AgeMaskedTextBox.Text);
            DateTime? lostFrom = null;
            if (this.lostFromMaskedTextBox.MaskCompleted)
                if (DateTime.TryParse(this.lostFromMaskedTextBox.Text, out var outLostFrom))
                    lostFrom = outLostFrom;
            DateTime? lostTo = null;
            if (this.lostToMaskedTextBox.MaskCompleted)
                if (DateTime.TryParse(this.lostToMaskedTextBox.Text, out var outLostTo))
                    lostTo = outLostTo;

            LoadPoteryashkas(
                this.surnameTextBox.Text,
                age,
                lostTo,
                lostFrom);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            LoadPoteryashkasWithFormParams();
        }

        private async void AddPoteryashkaButton_Click(object sender, EventArgs e)
        {
            var createPoteryashka = new PoteryashkaForm();
            if (createPoteryashka.ShowDialog() == DialogResult.OK)
            {
                await clien.AddPoteryashkaAsync(createPoteryashka.Poteryashka);
                LoadPoteryashkasWithFormParams();
            }
        }

        private async void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poteryashka = this.poteryashkasListView.SelectedItems[0].Tag as Poteryashka;
            var createPoteryashka = new PoteryashkaForm(poteryashka);
            if (createPoteryashka.ShowDialog() == DialogResult.OK)
            {
                await clien.UpdatePoteryashkaAsync(createPoteryashka.Poteryashka);
                LoadPoteryashkasWithFormParams();
            }
        }

        private async void WasFoundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poteryashka = this.poteryashkasListView.SelectedItems[0].Tag as Poteryashka;
            var foundPoteryashka = new FoundForm();
            if (foundPoteryashka.ShowDialog() == DialogResult.OK)
            {
                var founInfo = new FoundInfo()
                {
                    PoteryashkaId = poteryashka.Id,
                    Date = foundPoteryashka.Date
                };
                await clien.PoteryashkaFoundAsync(founInfo);
                LoadPoteryashkasWithFormParams();
            }
        }

        private async void WasSeenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poteryashka = this.poteryashkasListView.SelectedItems[0].Tag as Poteryashka;
            var seenForm = new SeenForm(poteryashka);
            if (seenForm.ShowDialog() == DialogResult.OK)
            {
                await clien.HaveSeenPoteryashkaAsync(seenForm.Seen);
                LoadPoteryashkasWithFormParams();
            }
        }

        private async void AllSeensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var poteryashka = this.poteryashkasListView.SelectedItems[0].Tag as Poteryashka;
            var seen = await clien.GetPoteryashkaSeenAsync(poteryashka.Id);
            new Shadowing(seen).ShowDialog();
        }

        private void PoteryashkasContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (this.poteryashkasListView.SelectedItems.Count <= 0)
            {
                e.Cancel = true;
                return;
            }
            var p = this.poteryashkasListView.SelectedItems[0].Tag as Poteryashka;
            this.wasFoundToolStripMenuItem.Enabled = !p.IsFound;
            this.wasSeenToolStripMenuItem.Enabled = !p.IsFound;
            this.allSeensToolStripMenuItem.Enabled = p.Seen?.Count() > 0 ? true : false;
        }
    }
}
