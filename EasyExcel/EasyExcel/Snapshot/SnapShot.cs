using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyExcel.Snapshot
{
    public class SnapShot
    {
        public SnapShot()
        {

        }
        public void CreateSnapShot()
        {
            Range selection = Globals.ThisAddIn.Application.Selection as Range;
            selection.CopyPicture(XlPictureAppearance.xlScreen, XlCopyPictureFormat.xlBitmap);
            //System.Drawing.Image image = Clipboard.GetImage();
           
            //image.Save(@"d:\testimg.JPEG");

        }
        public System.Drawing.Image GetClipboardImage()
        {
            System.Drawing.Image returnImage = null;
            if (System.Windows.Forms.Clipboard.ContainsImage())
            {
                returnImage = System.Windows.Forms.Clipboard.GetImage();
               
            }
            return returnImage;
        }
    }
}
