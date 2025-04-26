using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Futronic.SDKHelper;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace FutronicTestApp.Biometrico
{
    public static class FutronicHelper
    {
        public static FutronicEnrollment Enrolador;

        public static void EnrolarHuella(string nombreUsuario, Action<byte[]> onSuccess, Action<string> onError) 
        {
            try
            {
                var enrolador = new FutronicEnrollment
                {
                    FakeDetection = false,
                    FFDControl = true,
                    Version = VersionCompatible.ftr_version_compatible,
                    FastMode = false,
                    MIOTControlOff = false,
                    MaxModels = 5
                };

                enrolador.OnPutOn += (FTR_PROGRESS p) =>
                {
                    Console.WriteLine("👉 Coloca el dedo en el lector.");
                };

                enrolador.OnTakeOff += (FTR_PROGRESS p) =>
                {
                    Console.WriteLine("👆 Retira el dedo del lector.");
                };

                enrolador.OnFakeSource += (FTR_PROGRESS p) =>
                {
                    Console.WriteLine("⚠️ Dedo falso detectado.");
                    return true; // Abortamos si se detecta dedo falso
                };

                enrolador.OnEnrollmentComplete += (bool bSuccess, int nResult) =>
                {
                    if (!bSuccess)
                    {
                        onError?.Invoke($"❌ Fallo en el enrolamiento. Código: {nResult}");
                        return;
                    }

                    var template = enrolador.Template;
                    if (template == null)
                    {
                        onError?.Invoke("❌ No se obtuvo ninguna plantilla de huella.");
                        return;
                    }

                    onSuccess?.Invoke((byte[])template);
                };

                Console.WriteLine("🔄 Iniciando proceso de enrolamiento...");
                enrolador.Enrollment();
            }
            catch (Exception ex) 
            {
                onError?.Invoke("❌ Error durante enrolamiento: " + ex.Message);
            }
        }
    }    
}
