using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GesCom.utils
{
    class ImageConvert
    {
        /*
                * insert ou Update Image BD  
                *   FileName(chemin)  => byte[]  binaire
                *   
       */
        public static byte[] convertImageToByte(string fileName)
        {
            //Creation d'une Image à partir du Chemin
            Image imageIn = Image.FromFile(fileName);
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        /* 
               * Recuperation(select) d'une  Image BD 
               *  byte[] binaire => Image
       */

        public static Image convertByteToImage(byte[] data)
        {
            MemoryStream stream = new MemoryStream(data);
            return Image.FromStream(stream);
        }



        public static byte[] convertImgToByte(Image image)
        {
            
            MemoryStream stream = new MemoryStream();
            image.Save(stream, ImageFormat.Png);
            return stream.ToArray();
        }

    }
}
