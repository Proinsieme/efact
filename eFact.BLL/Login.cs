using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace eFact.BLL
{
    public class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public string CheckUserExists(string userName, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            string loginStatus = "";
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                password = Encrypt(password, userName);
                SqlCommand sqlCommand = new SqlCommand("usp_UserDetails_Validate", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = userName;
                sqlCommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = password;
                loginStatus = Convert.ToString(sqlCommand.ExecuteScalar());
                return loginStatus;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string Decrypt(string TextToBeDecrypted, string userId)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();

            string Password = "NESIMI" + userId;
            string DecryptedData;

            try
            {
                byte[] EncryptedData = Convert.FromBase64String(TextToBeDecrypted);

                byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());

                //Making of the key for decryption
                PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

                //Creates a symmetric Rijndael decryptor object.
                ICryptoTransform Decryptor = RijndaelCipher.CreateDecryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));

                MemoryStream memoryStream = new MemoryStream(EncryptedData);

                //Defines the cryptographics stream for decryption.THe stream contains decrpted data
                CryptoStream cryptoStream = new CryptoStream(memoryStream, Decryptor, CryptoStreamMode.Read);

                byte[] PlainText = new byte[EncryptedData.Length];
                int DecryptedCount = cryptoStream.Read(PlainText, 0, PlainText.Length);
                memoryStream.Close();
                cryptoStream.Close();

                //Converting to string
                DecryptedData = Encoding.Unicode.GetString(PlainText, 0, DecryptedCount);
            }
            catch
            {
                DecryptedData = TextToBeDecrypted;
            }
            return DecryptedData;
        }

        private string Encrypt(string TextToBeEncrypted, string userId)
        {
            RijndaelManaged RijndaelCipher = new RijndaelManaged();
            string Password = "NESIMI" + userId;

            byte[] PlainText = System.Text.Encoding.Unicode.GetBytes(TextToBeEncrypted);
            byte[] Salt = Encoding.ASCII.GetBytes(Password.Length.ToString());
            PasswordDeriveBytes SecretKey = new PasswordDeriveBytes(Password, Salt);

            //Creates a symmetric encryptor object. 
            ICryptoTransform Encryptor = RijndaelCipher.CreateEncryptor(SecretKey.GetBytes(32), SecretKey.GetBytes(16));
            MemoryStream memoryStream = new MemoryStream();

            //Defines a stream that links data streams to cryptographic transformations
            CryptoStream cryptoStream = new CryptoStream(memoryStream, Encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(PlainText, 0, PlainText.Length);

            //Writes the final state and clears the buffer
            cryptoStream.FlushFinalBlock();
            byte[] CipherBytes = memoryStream.ToArray();
            memoryStream.Close();
            cryptoStream.Close();
            string EncryptedData = Convert.ToBase64String(CipherBytes);

            return EncryptedData;
        }
    }
}
