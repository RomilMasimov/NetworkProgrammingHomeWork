namespace LostClient.View
{
    partial class PoteryashkaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.subnameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ageMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lostFromMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(12, 25);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(330, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // subnameTextBox
            // 
            this.subnameTextBox.Location = new System.Drawing.Point(12, 64);
            this.subnameTextBox.Name = "subnameTextBox";
            this.subnameTextBox.Size = new System.Drawing.Size(330, 20);
            this.subnameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Age";
            // 
            // ageMaskedTextBox
            // 
            this.ageMaskedTextBox.Location = new System.Drawing.Point(12, 103);
            this.ageMaskedTextBox.Mask = "00";
            this.ageMaskedTextBox.Name = "ageMaskedTextBox";
            this.ageMaskedTextBox.Size = new System.Drawing.Size(330, 20);
            this.ageMaskedTextBox.TabIndex = 5;
            this.ageMaskedTextBox.ValidatingType = typeof(int);
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 142);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(330, 111);
            this.infoTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Info";
            // 
            // phoneMaskedTextBox
            // 
            this.phoneMaskedTextBox.Location = new System.Drawing.Point(12, 272);
            this.phoneMaskedTextBox.Mask = "(999) 000-0000";
            this.phoneMaskedTextBox.Name = "phoneMaskedTextBox";
            this.phoneMaskedTextBox.Size = new System.Drawing.Size(330, 20);
            this.phoneMaskedTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Phone";
            // 
            // lostFromMaskedTextBox
            // 
            this.lostFromMaskedTextBox.Location = new System.Drawing.Point(12, 311);
            this.lostFromMaskedTextBox.Mask = "00/00/0000";
            this.lostFromMaskedTextBox.Name = "lostFromMaskedTextBox";
            this.lostFromMaskedTextBox.Size = new System.Drawing.Size(330, 20);
            this.lostFromMaskedTextBox.TabIndex = 11;
            this.lostFromMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lost from";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(267, 361);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(186, 361);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // PoteryashkaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 396);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lostFromMaskedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneMaskedTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ageMaskedTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subnameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "PoteryashkaForm";
            this.ShowIcon = false;
            this.Text = "Poteryashka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox subnameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox ageMaskedTextBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox phoneMaskedTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox lostFromMaskedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}