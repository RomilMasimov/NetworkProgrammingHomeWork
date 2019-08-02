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
    public partial class FoundForm : Form
    {
        public DateTime Date { get; set; }

        public FoundForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (this.dateMaskedTextBox.MaskCompleted)
                if (DateTime.TryParse(this.dateMaskedTextBox.Text, out var outDate))
                {
                    Date = outDate;
                    this.DialogResult = DialogResult.OK;
                }
        }
    }
}
