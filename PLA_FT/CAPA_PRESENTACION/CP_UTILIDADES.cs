using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace CAPA_PRESENTACION
{
    public class CP_UTILIDADES
    {
        public static class DATOS_USUARIO
        {
            public static string USUARIO;
            public static string NOMBRE;
            public static int OPCION;
        }

        public static void MENSAJE_INFORMACION(string mensaje, Form obj)
        {
            MetroFramework.MetroMessageBox.Show(obj,mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void MENSAJE_ERROR(string mensaje, Form obj)
        {
            MetroFramework.MetroMessageBox.Show(obj, mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static string ENCRIPTAR_CLAVE(string clave)
        {
            TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider Hashmd5 = new MD5CryptoServiceProvider();
            string Encriptar = "";

            string MyKey = "MyKey2012";

            if ((clave.Trim() == ""))
            {
                Encriptar = "";
            }
            else
            {
                Des.Key = Hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(MyKey));
                Des.Mode = CipherMode.ECB;
                ICryptoTransform encrypt = Des.CreateEncryptor();
                byte[] buff = UnicodeEncoding.ASCII.GetBytes(clave);
                Encriptar = Convert.ToBase64String(encrypt.TransformFinalBlock(buff, 0, buff.Length));
            }
            return Encriptar;
        }

        public static string DESENCRIPTAR_CLAVE(string clave)
        {
            TripleDESCryptoServiceProvider Des = new TripleDESCryptoServiceProvider();
            MD5CryptoServiceProvider Hashmd5 = new MD5CryptoServiceProvider();
            string MyKey = "MyKey2012";
            string Desencriptar = "";
            if ((clave.Trim() == ""))
            {
                Desencriptar = "";
            }
            else
            {
                Des.Key = Hashmd5.ComputeHash(new UnicodeEncoding().GetBytes(MyKey));
                Des.Mode = CipherMode.ECB;
                ICryptoTransform desencrypta = Des.CreateDecryptor();
                byte[] buff = Convert.FromBase64String(clave);
                Desencriptar = UnicodeEncoding.ASCII.GetString(desencrypta.TransformFinalBlock(buff, 0, buff.Length));
                buff.GetLength(0);
            }

            return Desencriptar;
        }

        public static void PERMITIR_NUMERO_Y_PUNTO(object sender, KeyPressEventArgs e, MetroFramework.Controls.MetroTextBox text)
        {
            if (((e.KeyChar) < 48) && ((e.KeyChar) != 8) || ((e.KeyChar) > 57))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.')
                //si ya hay un punto no permite un nuevo ingreso de este
                if (text.Text.Contains("."))
                    e.Handled = true;
                else
                    e.Handled = false;
        }

        public static void PERMITIR_NUMERO(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar) < 48) && ((e.KeyChar) != 8) || ((e.KeyChar) > 57))
            {
                e.Handled = true;
            }
        }

        public static bool VALIDAR_FECHA(MaskedTextBox masked)
        {
            DateTime fecha;
            if (DateTime.TryParse(masked.Text, out fecha))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool VALIDAR_CORREO(string correo)
        {
            String Expresion;
            Expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(correo, Expresion))
            {
                if (Regex.Replace(correo, Expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
