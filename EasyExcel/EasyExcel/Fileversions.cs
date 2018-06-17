using EasyExcel.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyExcel
{
    public partial class Fileversions : Form
    {
        public Fileversions()
        {
            GitVersionControlpull pullobj = new GitVersionControlpull(@Globals.ThisAddIn.Application.ActiveWorkbook.FullName);
            List<GitlogModel> model = pullobj.GetGitlog();       
            InitializeComponent();
            Versongrid.DataSource = model;
            Versongrid.CellClick += Versongrid_CellClick;
            DataGridViewButtonColumn getversioncolumn = new DataGridViewButtonColumn();
            getversioncolumn.Name = "Getfileversions";
            getversioncolumn.HeaderText = "Click to get file versions";
            getversioncolumn.Text = "Get This Version";
            getversioncolumn.DefaultCellStyle.BackColor = Color.White;
            getversioncolumn.UseColumnTextForButtonValue = true;
            int columnIndex = 3;
            if (Versongrid.Columns["Getfileversions"] == null)
            {
                Versongrid.Columns.Insert(columnIndex, getversioncolumn);
            }
        }

        private void Versongrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == Versongrid.Columns["Getfileversions"].Index)
            {
                GitVersionControlpull pullobj = new GitVersionControlpull(@Globals.ThisAddIn.Application.ActiveWorkbook.FullName);
                string sha = Convert.ToString(Versongrid[3, e.RowIndex].Value);
                string filepath=pullobj.GetFile(sha);
                string newfile = Path.GetDirectoryName(filepath) + @"\" + Path.GetFileNameWithoutExtension(filepath) + DateTime.Now.ToString("ddMMyyyyHHmmss") + Path.GetExtension(filepath);
                File.Copy(filepath, newfile);
                Process.Start(newfile);
            }
        }
    }
}
