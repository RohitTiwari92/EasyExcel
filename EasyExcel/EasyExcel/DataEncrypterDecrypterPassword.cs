using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using EasyExcel.DataEncrypterDecrypter;

namespace EasyExcel
{
    public partial class DataEncrypterDecrypterPassword : Form
    {
        public DataEncrypterDecrypterPassword(int i)
        {

            InitializeComponent();
            if (i == 1)
            {
                Encrypt.Visible = false;
            }
            else
            {
                Decrypt.Visible = false;
            }
        }

        private void Process_Click(object sender, EventArgs e)
        {

        }

        private void Encrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Please Enter the correct Password");
            }
            else
            {
                if (PasswordBox.Text.Length != 16)
                {
                    MessageBox.Show("Please Enter the correct Password");
                }
                else
                {
                    Range selection = Globals.ThisAddIn.Application.Selection as Range;
                    foreach (object cell in selection.Cells)

                    {

                        try

                        {
                            string data = Convert.ToString(((Range)cell).Value2);
                            string edata = DataEncrypter.Encrypt(data, PasswordBox.Text);
                            ((Range)cell).Value2 = edata;
                        }
                        catch (Exception ex)
                        {

                            //MessageBox.Show("NULL VALUE");

                        }


                    }
                }
            }
        }

        private void Decrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PasswordBox.Text))
            {
                MessageBox.Show("Please Enter the Password");
            }
            else
            {
                Range selection = Globals.ThisAddIn.Application.Selection as Range;
                foreach (object cell in selection.Cells)

                {

                    try

                    {

                        string data = Convert.ToString(((Range)cell).Value2);
                        string edata = DataDecrypter.Decrypt(data, PasswordBox.Text);
                        ((Range)cell).Value2 = edata;
                    }

                    catch

                    {

                        //   MessageBox.Show("NULL VALUE");

                    }


                }
            }
        }
    }
}
