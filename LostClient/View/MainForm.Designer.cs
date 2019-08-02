namespace LostClient.View
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addPoteryashkaButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.lostToMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lostFromMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.poteryashkasListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.poteryashkasContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wasFoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.allSeensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wasSeenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.poteryashkasContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(962, 485);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.addPoteryashkaButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(775, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 479);
            this.panel1.TabIndex = 0;
            // 
            // addPoteryashkaButton
            // 
            this.addPoteryashkaButton.Location = new System.Drawing.Point(10, 228);
            this.addPoteryashkaButton.Name = "addPoteryashkaButton";
            this.addPoteryashkaButton.Size = new System.Drawing.Size(168, 23);
            this.addPoteryashkaButton.TabIndex = 11;
            this.addPoteryashkaButton.Text = "Add Pteryashka";
            this.addPoteryashkaButton.UseVisualStyleBackColor = true;
            this.addPoteryashkaButton.Click += new System.EventHandler(this.AddPoteryashkaButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(9, 179);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(150, 23);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // lostToMaskedTextBox
            // 
            this.lostToMaskedTextBox.Location = new System.Drawing.Point(9, 153);
            this.lostToMaskedTextBox.Mask = "00/00/0000";
            this.lostToMaskedTextBox.Name = "lostToMaskedTextBox";
            this.lostToMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this.lostToMaskedTextBox.TabIndex = 9;
            this.lostToMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "LostTo";
            // 
            // lostFromMaskedTextBox
            // 
            this.lostFromMaskedTextBox.Location = new System.Drawing.Point(9, 114);
            this.lostFromMaskedTextBox.Mask = "00/00/0000";
            this.lostFromMaskedTextBox.Name = "lostFromMaskedTextBox";
            this.lostFromMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this.lostFromMaskedTextBox.TabIndex = 7;
            this.lostFromMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LostFrom";
            // 
            // AgeMaskedTextBox
            // 
            this.AgeMaskedTextBox.Location = new System.Drawing.Point(9, 75);
            this.AgeMaskedTextBox.Mask = "00";
            this.AgeMaskedTextBox.Name = "AgeMaskedTextBox";
            this.AgeMaskedTextBox.Size = new System.Drawing.Size(150, 20);
            this.AgeMaskedTextBox.TabIndex = 4;
            this.AgeMaskedTextBox.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Surname";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(9, 36);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.surnameTextBox.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.poteryashkasListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(766, 479);
            this.panel2.TabIndex = 1;
            // 
            // poteryashkasListView
            // 
            this.poteryashkasListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.poteryashkasListView.ContextMenuStrip = this.poteryashkasContextMenuStrip;
            this.poteryashkasListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.poteryashkasListView.FullRowSelect = true;
            this.poteryashkasListView.GridLines = true;
            this.poteryashkasListView.HideSelection = false;
            this.poteryashkasListView.Location = new System.Drawing.Point(0, 0);
            this.poteryashkasListView.MultiSelect = false;
            this.poteryashkasListView.Name = "poteryashkasListView";
            this.poteryashkasListView.Size = new System.Drawing.Size(766, 479);
            this.poteryashkasListView.TabIndex = 0;
            this.poteryashkasListView.UseCompatibleStateImageBehavior = false;
            this.poteryashkasListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 44;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 204;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Age";
            this.columnHeader3.Width = 44;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Info";
            this.columnHeader4.Width = 197;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.Width = 126;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Lost";
            this.columnHeader6.Width = 90;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Found";
            this.columnHeader7.Width = 63;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "IsFound";
            // 
            // poteryashkasContextMenuStrip
            // 
            this.poteryashkasContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.wasFoundToolStripMenuItem,
            this.toolStripSeparator1,
            this.allSeensToolStripMenuItem,
            this.wasSeenToolStripMenuItem});
            this.poteryashkasContextMenuStrip.Name = "poteryashkasContextMenuStrip";
            this.poteryashkasContextMenuStrip.ShowImageMargin = false;
            this.poteryashkasContextMenuStrip.Size = new System.Drawing.Size(109, 98);
            this.poteryashkasContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.PoteryashkasContextMenuStrip_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // wasFoundToolStripMenuItem
            // 
            this.wasFoundToolStripMenuItem.Name = "wasFoundToolStripMenuItem";
            this.wasFoundToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.wasFoundToolStripMenuItem.Text = "Was Found";
            this.wasFoundToolStripMenuItem.Click += new System.EventHandler(this.WasFoundToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(152, 6);
            // 
            // allSeensToolStripMenuItem
            // 
            this.allSeensToolStripMenuItem.Name = "allSeensToolStripMenuItem";
            this.allSeensToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.allSeensToolStripMenuItem.Text = "Shadowing";
            this.allSeensToolStripMenuItem.Click += new System.EventHandler(this.AllSeensToolStripMenuItem_Click);
            // 
            // wasSeenToolStripMenuItem
            // 
            this.wasSeenToolStripMenuItem.Name = "wasSeenToolStripMenuItem";
            this.wasSeenToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.wasSeenToolStripMenuItem.Text = "Was Seen";
            this.wasSeenToolStripMenuItem.Click += new System.EventHandler(this.WasSeenToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.AgeMaskedTextBox);
            this.groupBox1.Controls.Add(this.lostToMaskedTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lostFromMaskedTextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 213);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 485);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.poteryashkasContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MaskedTextBox lostToMaskedTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox lostFromMaskedTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox AgeMaskedTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addPoteryashkaButton;
        private System.Windows.Forms.ListView poteryashkasListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip poteryashkasContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wasFoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem allSeensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wasSeenToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

