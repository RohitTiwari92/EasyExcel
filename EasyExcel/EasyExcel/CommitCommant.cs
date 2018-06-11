using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyExcel
{
    public partial class CommitCommant : Form
    {
        public CommitCommant()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(commitmessage.Text))
            {
                GitVersionControl gitobj = new GitVersionControl(Globals.ThisAddIn.Application.ActiveWorkbook.FullName, commitmessage.Text);
                gitobj.commmit();
            }
            else
                MessageBox.Show("Please enter message for this commit");
        }
    }
}
