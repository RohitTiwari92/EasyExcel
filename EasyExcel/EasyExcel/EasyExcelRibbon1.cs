using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace EasyExcel
{
    public partial class EasyExcelRibbon1
    {
        private void EasyExcelRibbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            var saveDialog = new SaveFileDialog()
            {
                Title = "Save As",
                Filter = "Excel WorkBook (*.xlsx)|(*.xls)",
                AddExtension = true,
                CheckPathExists = true
            };

            if (saveDialog.ShowDialog() == DialogResult.OK)
                Globals.ThisAddIn.Application.ActiveWorkbook.SaveCopyAs(saveDialog.FileName);


        }
    }
}
