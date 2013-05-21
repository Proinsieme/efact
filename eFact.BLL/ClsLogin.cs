using System;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;


namespace eFact
{
    class ClsLogin
    {

        ClsTransactionLog log = new ClsTransactionLog();

        private string userName;
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        private string userPassword;
        public string UserPassword
        {
            get { return userPassword; }
            set { userPassword = value; }
        }

        private DateTime userLstLoginDate;
        public DateTime UserLstLoginDate
        {
            get { return userLstLoginDate; }
            set { userLstLoginDate = value; }
        }

        private int numberOfLogins;
        public int NumberOfLogins
        {
            get { return numberOfLogins; }
            set { numberOfLogins = value; }
        }

        private int passwordExpireDays;
        public int PasswordExpireDays
        {
            get { return passwordExpireDays; }
            set { passwordExpireDays = value; }
        }

        private DateTime userProfileEndDate;
        public DateTime UserProfileEndDate
        {
            get { return userProfileEndDate; }
            set { userProfileEndDate = value; }
        }

        private DateTime userActivationDate;
        public DateTime UserActivationDate
        {
            get { return userActivationDate; }
            set { userActivationDate = value; }
        }

        private DateTime userPwdExpireDate;
        public DateTime UserPwdExpireDate
        {
            get { return userPwdExpireDate; }
            set { userPwdExpireDate = value; }
        }

        private Boolean userForcePwdChange;
        public Boolean UserForcePwdChange
        {
            get { return userForcePwdChange; }
            set { userForcePwdChange = value; }
        }

        private string userRecordStatus;
        public string UserRecordStatus
        {
            get { return userRecordStatus; }
            set { userRecordStatus = value; }
        }

        public Boolean ValidateUserName()
        {
            //Check for input of UserId for null string and lengt
            Boolean IsUserNameCorrect = true;
            if (UserName.Length == 0 || UserName.Length > 8 || string.IsNullOrWhiteSpace(UserName) ||
                string.IsNullOrEmpty(UserName))
            {
                MessageBox.Show("Username is empty or Username lenght is greater than 8 characters",
                    "User Login", MessageBoxButton.OK, MessageBoxImage.Error);
                IsUserNameCorrect = false;
            }

            return IsUserNameCorrect;
        }

        public Boolean ValidateUserPassword()
        {
            //Check for input of Password for null string and lengt
            Boolean IsUserPasswordCorrect = true;
            if (UserPassword.Length == 0 || string.IsNullOrWhiteSpace(UserPassword) || string.IsNullOrEmpty(UserPassword))
            {
                MessageBox.Show("Please enter valid password",
                    "User Login", MessageBoxButton.OK, MessageBoxImage.Error);
                IsUserPasswordCorrect = false;
            }

            return IsUserPasswordCorrect;
        }

        public Boolean CheckUserExistInDB()
        {
            ClsDatabaseReader efactDB = new ClsDatabaseReader();

            string queryStr = "SELECT * FROM Users WHERE UserId = \"" + UserName + "\"";
            Boolean IsUserExist = true;

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClsLoginCheckUserExistInDB"))
            {
                if (dr != null)
                {
                    dr.Read();
                    if (dr.HasRows)  // If any user found? Yes, check for correct User name and password
                    {
                        if (dr["UserId"].ToString() != UserName || dr["UserPwd"].ToString() != Encrypt(UserPassword, UserName))
                        {
                            MessageBox.Show("Username or Password is invalid",
                                            "User Login", MessageBoxButton.OK, MessageBoxImage.Error);

                            NumberOfLogins += 1;
                            IsUserExist = false;
                            log.Write_SysLog(UserName, "LOGIN", "", "Invalid User login", 0);
                        }
                        else
                        {
                            if (dr["Userstatus"].ToString() == "D")
                            {
                                MessageBox.Show("User is disabled. Contact your Security Officer",
                                                "User Login", MessageBoxButton.OK, MessageBoxImage.Error);
                                IsUserExist = false;
                                log.Write_SysLog(UserName, "LOGIN", "", "User is disabled", 0);
                            }
                            else
                            {
                                UserName = dr["UserId"].ToString();
                                UserPassword = dr["UserPwd"].ToString();
                                UserLstLoginDate = (DateTime)dr["UserLastLoginDate"];
                                UserActivationDate = (DateTime)dr["UserActivationDate"];
                                UserPwdExpireDate = (DateTime)dr["UserPwdExpireDate"];
                                UserForcePwdChange = (Boolean)dr["UserForcePwdChange"];
                                UserProfileEndDate = (DateTime)dr["UserProfileEndDate"];
                                UserRecordStatus = dr["UserRecordStatus"].ToString();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is invalid.",
                                        "User Login", MessageBoxButton.OK, MessageBoxImage.Error);

                        NumberOfLogins += 1;
                        IsUserExist = false;
                        log.Write_SysLog(UserName, "LOGIN", "", "Invalid User login", 0);
                    }
                }
                else
                {
                    // Database error, something wrong with the tables. Can not read the table
                    MessageBox.Show("Database pecific error",
                                    "User Login", MessageBoxButton.OK, MessageBoxImage.Error);
                    IsUserExist = false;
                }
            }

            return IsUserExist;
        }

        public string UpdateLastLoginDB()
        {
            ClsDatabaseReader efactDB = new ClsDatabaseReader();
            string queryStr = "";
            queryStr = "UPDATE Users SET UserLastLoginDate = \"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\" ";
            queryStr += "WHERE UserId = \"" + UserName + "\"";

            string returnStr = "";
            efactDB.ExecuteDBCommand(queryStr, "ClsLoginUpdateLastLoginDB1");

            queryStr = "";
            queryStr = "INSERT INTO CurrentUsers (";
            queryStr += "CurrentUserId, ";
            queryStr += "CurrentLastLoginDate) ";
            queryStr += "VALUES (";

            queryStr += "\"" + UserName + "\", ";
            queryStr += "\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\") ";

            returnStr = "";
            efactDB.ExecuteDBCommand(queryStr, "ClsLoginUpdateLastLoginDB2");

            return returnStr;
        }

        public Boolean CheckUserLoggedIn()
        {
            Boolean IsUserLoggedIn = false;
            ClsDatabaseReader efactDB = new ClsDatabaseReader();

            string queryStr = "SELECT * FROM CurrentUsers WHERE CurrentUserId = \"" + UserName + "\"";
            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "CLSLoginCheckUserLoggedIn"))
            {
                if (dr != null)
                {
                    dr.Read();
                    if (dr.HasRows)  // If any user found? 
                    {
                        MessageBox.Show("User " + UserName + " is already logged in ",
                                        "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        IsUserLoggedIn = true;
                    }
                }
            }

            return IsUserLoggedIn;
        }

        public Boolean CheckUserActivationDate()
        {
            Boolean IsUserActivationDateCorrect = true;
            if (UserActivationDate > DateTime.Today)
            {
                MessageBox.Show("User activation date is not reached. Activation date is " + UserActivationDate.ToString(),
                                "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                IsUserActivationDateCorrect = false;
            }
            return IsUserActivationDateCorrect;
        }

        public Boolean CheckUserPwdExpireDate()
        {
            Boolean IsUserExpireDateCorrect = true;
            if (UserPwdExpireDate > DateTime.Today)
            {
                IsUserExpireDateCorrect = false;
                if ((UserPwdExpireDate - DateTime.Today).Days <= PasswordExpireDays)
                {
                    MessageBox.Show("Password will expire about " + (UserPwdExpireDate - DateTime.Today).Days + " day(s)",
                                    "Password Expiry", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
            else
            {
                MessageBox.Show("Password is expired, please change your password",
                                "Password Expiry", MessageBoxButton.OK, MessageBoxImage.Information);
            }

            return IsUserExpireDateCorrect;
        }
        public Boolean CheckUnauthorizedUser()
        {
            Boolean IsUnauthorizedUser = true;
            if (UserRecordStatus == "U")
            {
                MessageBox.Show("User is in Unauthorized state. Please check this with your Security Officer(s)",
                                "User Unauthorized", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                IsUnauthorizedUser = false;
            }

            return IsUnauthorizedUser;
        }
        public Boolean CheckForceUserPassword()
        {
            Boolean IsForeceUserPasswordCorrect = true;
            if (UserForcePwdChange)
            {
                MessageBox.Show("Password is expired, change your password",
                                "Password Expiry", MessageBoxButton.OK, MessageBoxImage.Information);
                IsForeceUserPasswordCorrect = false;
            }

            return IsForeceUserPasswordCorrect;
        }

        public Boolean CheckUserProfileEndDate()
        {
            Boolean IsUserProfileEndDate = false;
            if (DateTime.Today > UserProfileEndDate)
            {
                MessageBox.Show("Your login profile date has expired, please contact your Security Officer(s)",
                                "User profile expired", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                IsUserProfileEndDate = true;
            }

            return IsUserProfileEndDate;
        }

        public static string Decrypt(string TextToBeDecrypted, string userId)
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


        public static string Encrypt(string TextToBeEncrypted, string userId)
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
