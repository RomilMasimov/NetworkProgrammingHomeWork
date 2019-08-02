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
    public partial class SeenForm : Form
    {
        public Seen Seen { get; set; }

        public SeenForm(Poteryashka poteryashka)
        {
            InitializeComponent();
            Seen = new Seen() { Who = poteryashka };
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (!string.IsNullOrWhiteSpace(this.whereTextBox.Text))
                Seen.Where = this.whereTextBox.Text;
            else flag = true;
            if (this.whenMaskedTextBox.MaskCompleted)
                if (DateTime.TryParse(this.whenMaskedTextBox.Text, out var outDate))
                    Seen.When = outDate;
                else flag = true;
            else flag = true;

            if (!flag) this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Seen = null;
        }
    }
}
