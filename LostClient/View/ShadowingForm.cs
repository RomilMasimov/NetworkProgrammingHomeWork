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
    public partial class Shadowing : Form
    {
        readonly IEnumerable<Seen> seen;

        public Shadowing(IEnumerable<Seen> seen)
        {
            InitializeComponent();
            this.seen = seen;
            LoadSeen();
        }

        private void LoadSeen()
        {
            foreach (var s in seen)
            {
                this.seenListView.Items.Add(new ListViewItem(
                    new string[]
                    {
                        s.Id.ToString(),
                        s.Where,
                        s.When.ToShortDateString()
                    }));
            }
        }
    }
}
