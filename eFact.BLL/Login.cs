﻿using System;
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
        public DateTime LastLoginDate { get; set; }
        public DateTime ActivationDate { get; set; }
        public DateTime PasswordExpireDate { get; set; }
        public DateTime ProfileEndDate { get; set; }
        public bool ForcePasswordChange { get; set; }
        public string RecordStatus { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();

        public string CheckUserExists(string userName, string password, out Login objLogin)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            DataSet dataSet = new DataSet();
            string Output = "0";
            objLogin = null;
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
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dataSet);

                if (dataSet != null && dataSet.Tables.Count != 0)
                {
                    foreach (DataRowView drvUserDetail in dataSet.Tables[0].DefaultView)
                    {
                        Output = Convert.ToString(drvUserDetail["OUTPUT"]);
                    }
                    if (Output == "1" && dataSet.Tables.Count == 2)
                    {
                        foreach (DataRowView drvUserDetail in dataSet.Tables[1].DefaultView)
                        {
                            objLogin = new Login
                            {
                                LastLoginDate = Convert.ToDateTime(drvUserDetail["UserLastLoginDate"]),
                                ActivationDate = Convert.ToDateTime(drvUserDetail["UserActivationDate"]),
                                PasswordExpireDate = Convert.ToDateTime(drvUserDetail["UserPwdExpireDate"]),
                                ForcePasswordChange = Convert.ToBoolean(drvUserDetail["UserForcePwdChange"]),
                                ProfileEndDate = Convert.ToDateTime(drvUserDetail["UserProfileEndDate"]),
                                RecordStatus = Convert.ToString(drvUserDetail["UserRecordStatus"])
                            };
                        }
                    }
                }
                return Output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool SaveUserPassword(string userName, string password)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            bool isSuccess = false;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }
                password = Encrypt(password, userName);
                SqlCommand sqlCommand = new SqlCommand("usp_SaveChangePassword", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@USERNAME", SqlDbType.VarChar).Value = userName;
                sqlCommand.Parameters.Add("@PASSWORD", SqlDbType.VarChar).Value = password;
                isSuccess = Convert.ToBoolean(sqlCommand.ExecuteScalar());
                return isSuccess;
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
