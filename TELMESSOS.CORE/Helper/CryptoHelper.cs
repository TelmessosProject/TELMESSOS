using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TELMESSOS.CORE.Helper
{
	public static class CryptoHelper
	{
        public static string Message = "aasdfghjklklfjırejookszdlgnjkelowwrpe fejosd sdfom56415 aodkes78sdjk asofıje<sd623 askl"; 
        public static string Encrypt(this string encryptData, string message)
        {
            if (encryptData == null) return null;
            var encryptDataToByte = Encoding.UTF8.GetBytes(encryptData);
            var keyToByte = Encoding.UTF8.GetBytes(message);

            keyToByte = SHA256.Create().ComputeHash(keyToByte);

            byte[] encryptedData = null;

            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(keyToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(encryptDataToByte, 0, encryptDataToByte.Length);
                        cs.Close();
                    }

                    encryptedData = ms.ToArray();
                }
            }

            return Convert.ToBase64String(encryptedData);
        }

        public static string Decrypt(this string decryptData, string message)
        {
            if (decryptData == null) return null;
            var decryptDataToByte = Convert.FromBase64String(decryptData);
            var keyToByte = Encoding.UTF8.GetBytes(message);

            keyToByte = SHA256.Create().ComputeHash(keyToByte);

            byte[] decryptedDataToByte = null;

            var saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (var ms = new MemoryStream())
            {
                using (var aes = new RijndaelManaged())
                {
                    var key = new Rfc2898DeriveBytes(keyToByte, saltBytes, 1000);

                    aes.KeySize = 256;
                    aes.BlockSize = 128;
                    aes.Key = key.GetBytes(aes.KeySize / 8);
                    aes.IV = key.GetBytes(aes.BlockSize / 8);

                    aes.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(decryptDataToByte, 0, decryptDataToByte.Length);
                        cs.Close();
                    }

                    decryptedDataToByte = ms.ToArray();
                }
            }

            return Encoding.UTF8.GetString(decryptedDataToByte);
        }

    }
}
