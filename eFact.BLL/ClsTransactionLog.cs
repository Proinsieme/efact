using System;
using System.Data.SqlClient;

namespace eFact
{
    public class ClsTransactionLog
    {
        public string LogTransactionId { get; set; }
        public string LogModuleCode { get; set; }
        public DateTime LogTransactionDate { get; set; }
        public string LogRecordKey { get; set; }
        public string LogUserId { get; set; }
        public string LogActionType { get; set; }
        public string LogModNo { get; set; }
        public string ModNo { get; set; }
        public string LogRecordstatus { get; set; }

        ClsDatabaseReader efactDB = new ClsDatabaseReader();

        /// <summary>
        /// Write SysLog file of User actions
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="functionId"></param>
        /// <param name="functionKey"></param>
        /// <param name="actionType"></param>
        /// <param name="recModNo"></param>
        public void Write_SysLog(string userId, string functionId, string functionKey, string actionType, int recModNo)
        {
            string queryStr = "";
            DateTime dt = DateTime.Today;

            //Insert SysLog record
            queryStr = "INSERT INTO SysLog (";
            queryStr += "UserId, ";
            queryStr += "FunctionId, ";
            queryStr += "FunctionKey, ";
            queryStr += "ActionType, ";
            queryStr += "RecordModNo, ";
            queryStr += "DateStamp) ";
            queryStr += "VALUES (";

            queryStr += "'" + userId + "', ";
            queryStr += "'" + functionId + "', ";
            queryStr += "'" + functionKey + "', ";
            queryStr += "'" + actionType + "', ";
            queryStr += recModNo + ", ";
            queryStr += "'" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "') ";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClsTransactionLogWrite_SysLog")) { };
        }

        public void WriteTransLog()
        {
            string queryStr = "";

            //Insert TransactionsLog record
            queryStr = "INSERT INTO TransactionLog (";
            queryStr += "LogTransactionId, ";
            queryStr += "LogModuleCode, ";
            queryStr += "LogTransactionDate, ";
            queryStr += "LogRecordKey, ";
            queryStr += "LogUserId, ";
            queryStr += "LogActionType, ";
            queryStr += "LogRecordstatus) ";
            queryStr += "VALUES (";

            queryStr += "\"" + LogTransactionId + "\", ";
            queryStr += "\"" + LogModuleCode + "\", ";
            queryStr += "\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\", ";
            queryStr += "\"" + LogRecordKey + "\", ";
            queryStr += "\"" + LogUserId + "\", ";
            queryStr += "\"" + LogActionType + "\", ";
            queryStr += "\"" + LogRecordstatus + "\") ";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClsTransactionLogWriteTransLog")) { };
        }

        public string GetModuleSequenceNumber(string strModuleName, string seqType)
        {
            //If the seqType = Key, we are going to form a key of 7 char for a entity else
            // we are dealing with a transaction of 4 char.
            int modSeqNo = 1;
            string queryStr = "";

            queryStr = "SELECT * FROM SequenceNos where SequenceId = \"" + strModuleName + "\"";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClsTransactionLogGetModuleSequenceNumber1"))
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    modSeqNo = (int)dr["SeqNoValue"] + 1;
                }
            }

            queryStr = "UPDATE SequenceNos SET SeqNoValue = \"" + modSeqNo + "\" ";
            queryStr += "WHERE SequenceId = \"" + strModuleName + "\"";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClsTransactionLogGetModuleSequenceNumber2")) { };

            if (seqType == "KEY")
                return (modSeqNo - 1).ToString("D7");
            else
                return (modSeqNo - 1).ToString("D4");
        }
    }
}
