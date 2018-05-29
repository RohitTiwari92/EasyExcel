using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Tools.Ribbon;

namespace EasyExcel
{
    public partial class EasyExcelRibbon1
    {
        private void EasyExcelRibbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void SaveWorkBook_Click(object sender, RibbonControlEventArgs e)
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
