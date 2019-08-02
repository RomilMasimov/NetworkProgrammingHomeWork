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
    public partial class PoteryashkaForm : Form
    {
        public Poteryashka Poteryashka { get; set; }

        public PoteryashkaForm()
        {
            InitializeComponent();
            Poteryashka = new Poteryashka();
        }

        public PoteryashkaForm(Poteryashka poteryashka)
        {
            InitializeComponent();
            Poteryashka = poteryashka;

            this.nameTextBox.Text = Poteryashka.Name;
            this.subnameTextBox.Text = Poteryashka.Surname;
            this.ageMaskedTextBox.Text = Poteryashka.Age.ToString();
            this.infoTextBox.Text = Poteryashka.AdditionalInfo;
            this.phoneMaskedTextBox.Text = Poteryashka.Phone;
            this.lostFromMaskedTextBox.Text = Poteryashka.Lost?.ToShortDateString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var flag = false;

            if (!string.IsNullOrWhiteSpace(this.nameTextBox.Text))
                Poteryashka.Name = this.nameTextBox.Text;
            else flag = true;
            if (!string.IsNullOrWhiteSpace(this.subnameTextBox.Text))
                Poteryashka.Surname = this.subnameTextBox.Text;
            else flag = true;
            if (this.ageMaskedTextBox.MaskCompleted)
                Poteryashka.Age = int.Parse(this.ageMaskedTextBox.Text);
            else flag = true;
            if (this.phoneMaskedTextBox.MaskCompleted)
                Poteryashka.Phone = this.phoneMaskedTextBox.Text;
            else flag = true;
            if (this.lostFromMaskedTextBox.MaskCompleted)
                if (DateTime.TryParse(this.lostFromMaskedTextBox.Text, out var outDate))
                    Poteryashka.Lost = outDate;
                else flag = true;
            else flag = true;
            Poteryashka.AdditionalInfo = this.infoTextBox.Text;

            if (!flag) this.DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Poteryashka = null;
        }
    }
}
