namespace EasyExcel
{
    partial class Fileversions
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
            this.Versongrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Versongrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Versongrid
            // 
            this.Versongrid.AllowUserToAddRows = false;
            this.Versongrid.AllowUserToDeleteRows = false;
            this.Versongrid.AllowUserToOrderColumns = true;
            this.Versongrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Versongrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Versongrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Versongrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Versongrid.Location = new System.Drawing.Point(0, 0);
            this.Versongrid.MultiSelect = false;
            this.Versongrid.Name = "Versongrid";
            this.Versongrid.ReadOnly = true;
            this.Versongrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Versongrid.Size = new System.Drawing.Size(613, 176);
            this.Versongrid.TabIndex = 0;
            // 
            // Fileversions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 176);
            this.Controls.Add(this.Versongrid);
            this.Name = "Fileversions";
            this.Text = "File versions";
            ((System.ComponentModel.ISupportInitialize)(this.Versongrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Versongrid;
    }
}