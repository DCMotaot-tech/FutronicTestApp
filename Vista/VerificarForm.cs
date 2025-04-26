using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FutronicTestApp.Biometrico;
using FutronicTestApp.Data;

namespace FutronicTestApp.Vista
{
    public partial class VerificarForm : Form
    {
        public VerificarForm()
        {
            InitializeComponent();
        }

        
        

        private void btnVerificarHuella_Click(object sender, EventArgs e)
        {

        }

        private void VerificarContraBD(byte[] huella)
        {
            
        }

        private Bitmap ConvertirHuellaABitmap(byte[] datosHuella, int width, int height)
        {
            Bitmap imagen = new Bitmap(width, height, PixelFormat.Format8bppIndexed);

            ColorPalette paleta = imagen.Palette;
            for (int i = 0; i < 256; i++)
                paleta.Entries[i] = Color.FromArgb(i, i, i);
            imagen.Palette = paleta;

            BitmapData data = imagen.LockBits(new Rectangle(0, 0, width, height),
                ImageLockMode.WriteOnly, PixelFormat.Format8bppIndexed);

            Marshal.Copy(datosHuella, 0, data.Scan0, datosHuella.Length);
            imagen.UnlockBits(data);

            return imagen;
        }
    }
}
