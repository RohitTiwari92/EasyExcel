using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using EasyExcel.Snapshot;

namespace EasyExcel
{
    public partial class EasyExcelRibbon1
    {
        private void EasyExcelRibbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {

            if (Globals.ThisAddIn.Application.ActiveWorkbook.Saved && !string.IsNullOrEmpty(Globals.ThisAddIn.Application.ActiveWorkbook.Path))
            {
                CommitCommant ccobj = new CommitCommant();
                ccobj.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please save your work. press {Ctrl+s}");
            }
        }

        private void GetallVersion_Click(object sender, RibbonControlEventArgs e)
        {
            if (Globals.ThisAddIn.Application.ActiveWorkbook.Saved && !string.IsNullOrEmpty(Globals.ThisAddIn.Application.ActiveWorkbook.Path))
            {
                Fileversions fileversions = new Fileversions();
                fileversions.Show();
            }
            else
            {
                MessageBox.Show("Please save your work. press {Ctrl+s}");
            }
        }

        private void Encrypt_Click(object sender, RibbonControlEventArgs e)
        {
            DataEncrypterDecrypterPassword edobj = new DataEncrypterDecrypterPassword(0);
            edobj.Show();          
        }

        private void Decrypt_Click(object sender, RibbonControlEventArgs e)
        {
            DataEncrypterDecrypterPassword edobj = new DataEncrypterDecrypterPassword(1);
            edobj.Show();
        }

        private void Comparebtn_Click(object sender, RibbonControlEventArgs e)
        {
            CompareColumns comcolobj = new CompareColumns();
            comcolobj.Show();
        }

        private void Click_1(object sender, RibbonControlEventArgs e)
        {
            Snapshot.SnapShot snapShot = new SnapShot();
            snapShot.CreateSnapShot();
        }
    }
}
