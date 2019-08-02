namespace LostClient.View
{
    partial class Shadowing
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
            this.seenListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // seenListView
            // 
            this.seenListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.seenListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.seenListView.FullRowSelect = true;
            this.seenListView.GridLines = true;
            this.seenListView.Location = new System.Drawing.Point(0, 0);
            this.seenListView.MultiSelect = false;
            this.seenListView.Name = "seenListView";
            this.seenListView.ShowGroups = false;
            this.seenListView.Size = new System.Drawing.Size(478, 247);
            this.seenListView.TabIndex = 0;
            this.seenListView.UseCompatibleStateImageBehavior = false;
            this.seenListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 26;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Where";
            this.columnHeader2.Width = 311;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "When";
            this.columnHeader3.Width = 116;
            // 
            // Shadowing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 247);
            this.Controls.Add(this.seenListView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Shadowing";
            this.ShowIcon = false;
            this.Text = "Shadowing";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView seenListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}