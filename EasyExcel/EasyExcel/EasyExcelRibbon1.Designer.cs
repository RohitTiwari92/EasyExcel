﻿namespace EasyExcel
{
    partial class EasyExcelRibbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public EasyExcelRibbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyExcelRibbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.SaveWorkBook = this.Factory.CreateRibbonButton();
            this.GetallVersion = this.Factory.CreateRibbonButton();
            this.security = this.Factory.CreateRibbonGroup();
            this.Encrypt = this.Factory.CreateRibbonButton();
            this.Decrypt = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.group1.SuspendLayout();
            this.security.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.security);
            this.tab1.Label = "Easy Excel";
            this.tab1.Name = "tab1";
            // 
            // group1
            // 
            this.group1.Items.Add(this.SaveWorkBook);
            this.group1.Items.Add(this.GetallVersion);
            this.group1.Label = "worksheets and Sheets ";
            this.group1.Name = "group1";
            // 
            // SaveWorkBook
            // 
            this.SaveWorkBook.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.SaveWorkBook.Image = ((System.Drawing.Image)(resources.GetObject("SaveWorkBook.Image")));
            this.SaveWorkBook.Label = "State save";
            this.SaveWorkBook.Name = "SaveWorkBook";
            this.SaveWorkBook.ShowImage = true;
            this.SaveWorkBook.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // GetallVersion
            // 
            this.GetallVersion.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.GetallVersion.Image = ((System.Drawing.Image)(resources.GetObject("GetallVersion.Image")));
            this.GetallVersion.Label = "Get all states";
            this.GetallVersion.Name = "GetallVersion";
            this.GetallVersion.ShowImage = true;
            this.GetallVersion.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.GetallVersion_Click);
            // 
            // security
            // 
            this.security.Items.Add(this.Encrypt);
            this.security.Items.Add(this.Decrypt);
            this.security.Label = "security";
            this.security.Name = "security";
            // 
            // Encrypt
            // 
            this.Encrypt.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Encrypt.Image = ((System.Drawing.Image)(resources.GetObject("Encrypt.Image")));
            this.Encrypt.Label = "Encrypt";
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.ShowImage = true;
            this.Encrypt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.Decrypt.Image = ((System.Drawing.Image)(resources.GetObject("Decrypt.Image")));
            this.Decrypt.Label = "Decrypt";
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.ShowImage = true;
            this.Decrypt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Decrypt_Click);
            // 
            // EasyExcelRibbon1
            // 
            this.Name = "EasyExcelRibbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.EasyExcelRibbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.security.ResumeLayout(false);
            this.security.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton SaveWorkBook;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton GetallVersion;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup security;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Encrypt;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton Decrypt;
    }

    partial class ThisRibbonCollection
    {
        internal EasyExcelRibbon1 EasyExcelRibbon1
        {
            get { return this.GetRibbon<EasyExcelRibbon1>(); }
        }
    }
}
