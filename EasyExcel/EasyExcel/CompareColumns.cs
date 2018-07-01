using EasyExcel.Compare;
using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyExcel
{
    public partial class CompareColumns : Form
    {
        public CompareColumns()
        {
            InitializeComponent();
            FunctionCB.DataSource = Enum.GetValues(typeof(CompareFunctionEnum))
        .Cast<Enum>()
        .Select(value => new
        {
            (Attribute.GetCustomAttribute(value.GetType().GetField(value.ToString()), typeof(DescriptionAttribute)) as DescriptionAttribute).Description,
            value
        })
        .OrderBy(item => item.value)
        .ToList();
            FunctionCB.DisplayMember = "Description";
            FunctionCB.ValueMember = "value";
        }

        private void Comparebtn_Click(object sender, EventArgs e)
        {
            if (velidate())
            {
                List<string> column1 = GetcolumnData(ColumnLetterToColumnIndex(Columnnamevalue1.Text), Convert.ToInt32(startrownumvalue1.Text), Convert.ToInt32(Endrownumvalue1.Text));
                List<string> column2 = GetcolumnData(ColumnLetterToColumnIndex(Columnnamevalue2.Text), Convert.ToInt32(startrownumvalue2.Text), Convert.ToInt32(Endrownumvalue2.Text));
                int selvalue = Convert.ToInt32(FunctionCB.SelectedValue);
                CompareFunctionEnum function;
                Enum.TryParse<CompareFunctionEnum>(FunctionCB.SelectedValue.ToString(), out function);
                CompareProcess processobj = new CompareProcess(column1, column2, function);
                List<string> output = processobj.Compare();
                fillcolumnData(ColumnLetterToColumnIndex(columnResult.Text), Convert.ToInt32(resultrow.Text), output);
            }
            else
            {
                MessageBox.Show("All fields are Mandatory");
            }
        }

        private bool velidate()
        {
            if (string.IsNullOrEmpty(Columnnamevalue1.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Columnnamevalue2.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(startrownumvalue1.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Endrownumvalue1.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(startrownumvalue2.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(Endrownumvalue2.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(columnResult.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(resultrow.Text))
            {
                return false;
            }
         
            return true;
        }

        static int ColumnLetterToColumnIndex(string columnLetter)
        {
            columnLetter = columnLetter.ToUpper();
            int sum = 0;

            for (int i = 0; i < columnLetter.Length; i++)
            {
                sum *= 26;
                sum += (columnLetter[i] - 'A' + 1);
            }
            return sum;
        }

        private List<string> GetcolumnData(int column, int rowStartIndex, int rowEndIndex)
        {
           
            List<string> cdata = new List<string>();
            Microsoft.Office.Interop.Excel.Application ExcelApp = Globals.ThisAddIn.Application;
            Worksheet sheet = null;
            Range range = null;
            string colLetter = string.Empty;

            try
            {

                sheet = (Worksheet)ExcelApp.ActiveSheet;
                for (int i = rowStartIndex; i <= rowEndIndex; i++)
                {
                    range = sheet.Cells[i, column] as Microsoft.Office.Interop.Excel.Range;
                    //colLetter = range.Address[false, false, XlReferenceStyle.xlA1];
                    cdata.Add(range.Text);
                }
                
            }
            finally
            {
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (range != null) Marshal.ReleaseComObject(range);
               
            }
            return cdata;
        }
        private void fillcolumnData(int column, int rowStartIndex, List<string> data)
        {
            List<string> cdata = new List<string>();
            Microsoft.Office.Interop.Excel.Application ExcelApp = Globals.ThisAddIn.Application;
            Worksheet sheet = null;
            Range range = null;
            string colLetter = string.Empty;

            try
            {

                sheet = (Worksheet)ExcelApp.ActiveSheet;
               
                for (int i = 0; i < data.Count; i++)
                {
                    range = sheet.Cells[rowStartIndex+i, column] as Microsoft.Office.Interop.Excel.Range;
                    foreach (object cell in range)

                    {
                        ((Range)cell).Value2 = data[i];
                    }
                    
                }

            }
            finally
            {
                if (sheet != null) Marshal.ReleaseComObject(sheet);
                if (range != null) Marshal.ReleaseComObject(range);

            }
        }


    }
}
