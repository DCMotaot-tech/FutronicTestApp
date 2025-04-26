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
using System.IO;
using FutronicTestApp.Data;
using Futronic.SDKHelper;

namespace FutronicTestApp.Vista
{
    public partial class EnrolarForm : Form
    {
        public EnrolarForm()
        {
            InitializeComponent();
        }

        private byte[] huellaCapturada = null;

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

        private void btnCapturarHuella_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text)) 
            {
                MessageBox.Show("Por favor ingresa un nombre antes de capturar la huella.");
                return;
            }

            FutronicHelper.EnrolarHuella(
                txtNombre.Text.Trim(),
                (huella) =>
                {
                    huellaCapturada = huella;
                    lblResultado.Text = "✅ Huella enrolada correctamente.";
                    lblResultado.ForeColor = Color.Green;

                    int width = 320;
                    int height = 480;
                    Bitmap bmp = ConvertirHuellaABitmap(huella, width, height);
                    pbHuella.Image = bmp;
                },
                (mensajeError) =>
                {
                    MessageBox.Show(mensajeError, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lblResultado.Text = "❌ Fallo al enrolar.";
                    lblResultado.ForeColor = Color.Red;
                });
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || huellaCapturada == null)
            {
                MessageBox.Show("Por favor ingresa el nombre y captura la huella.", "Aviso");
                return;
            }

            using (var conexion = ConexionSQLite.ObtenerConexion())
            {
                conexion.Open();

                string query = "INSERT INTO Usuarios (Nombre, Huella) VALUES (@nombre, @huella)";
                using (var cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.Add("@huella", DbType.Binary).Value = huellaCapturada;

                    cmd.ExecuteNonQuery();
                }
            }

            lblResultado.Text = "✅ Usuario registrado con éxito.";
            lblResultado.ForeColor = Color.Green;
            txtNombre.Clear();
            pbHuella.Image = null;
            huellaCapturada = null;
        }
    }
}
