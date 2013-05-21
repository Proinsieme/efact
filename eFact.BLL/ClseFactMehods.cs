using System;
using System.Configuration;
using System.Data.SqlClient;

namespace eFact
{
    class ClseFactMehods
    {
        ClsDatabaseReader efactDB = new ClsDatabaseReader();
        ClsTransactionLog log = new ClsTransactionLog();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="recId"></param>
        /// Record Id of the mutation record
        /// <param name="actionType"></param>
        /// The Tpye of mutation: Input, Update or Delete
        /// <param name="moduleCode"></param>
        /// The module to be logged
        /// <param name="recStat"></param>
        /// The Tpye of mutation: Input, Update or Delete
        /// <param name="seqKey"></param>
        /// Is used for getting the sequence numbers (TNX= Transaction, KEY=Record Id sequence number)
        public void BuildTransactionData(string recId, string actionType, string moduleCode, string modNo, string recStat, string seqKey)
        {
            DateTime dt = DateTime.Today;
            log.LogModuleCode = moduleCode;
            log.LogModNo = modNo;
            log.LogActionType = actionType;
            log.LogRecordKey = recId;
            log.LogRecordstatus = recStat;
            log.LogTransactionDate = DateTime.Now;
            log.LogUserId = ConfigurationManager.AppSettings["GlbUserId"].ToString();
            string modSeqNo = GetModuleSequenceNumber(log.LogModuleCode, seqKey);
            log.LogTransactionId = log.LogModuleCode + dt.Year + dt.DayOfYear.ToString("D3") + modSeqNo;

            CreateUnauthorizedTransactionRecord();

            log.WriteTransLog();
        }

        public string GetModuleSequenceNumber(string strModuleName, string seqType)
        {
            //If the seqType = Key, we are going to form a key of 7 char for a entity else
            // we are dealing with a transaction of 4 char.
            int modSeqNo = 1;
            string queryStr = "";

            queryStr = "SELECT * FROM SequenceNos where SequenceId = \"" + strModuleName + "\"";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClseFactMethodsGetModuleSequenceNumber1"))
            {
                if (dr.HasRows)
                {
                    dr.Read();
                    modSeqNo = (int)dr["SeqNoValue"] + 1;
                }
            }

            queryStr = "UPDATE SequenceNos SET SeqNoValue = \"" + modSeqNo + "\" ";
            queryStr += "WHERE SequenceId = \"" + strModuleName + "\"";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClseFactMethodsGetModuleSequenceNumber2")) { };

            if (seqType == "KEY")
                return (modSeqNo - 1).ToString("D7");
            else
                return (modSeqNo - 1).ToString("D4");
        }

        /// <summary>
        /// Standard Routine for creating transaction records to be authorized
        /// The LogTransactionId should be updated alway before calling this method.
        /// </summary>
        public void CreateUnauthorizedTransactionRecord()
        {
            //Delete first the record pending for authorization wit the same Id
            string queryStr = "";
            queryStr = "DELETE FROM UnauthorizedTransactions ";
            queryStr += "WHERE TransRecordKey = \"" + log.LogRecordKey + "\"";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClseFactMethodsCreateUnauthorizedTransactionRecord1")) { };

            //Insert UnauthorizedTransactions record
            queryStr = "INSERT INTO UnauthorizedTransactions (";
            queryStr += "TransactionId, ";
            queryStr += "TransRecordKey, ";
            queryStr += "InputUser, ";
            queryStr += "InputDate, ";
            queryStr += "ApplModule, ";
            queryStr += "ActionType, ";
            queryStr += "ModNo, ";
            queryStr += "RecordStatus) ";
            queryStr += "VALUES (";

            queryStr += "\"" + log.LogTransactionId + "\", ";
            queryStr += "\"" + log.LogRecordKey + "\", ";
            queryStr += "\"" + log.LogUserId + "\", ";
            queryStr += "\"" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\", ";
            queryStr += "\"" + log.LogModuleCode + "\", ";
            queryStr += "\"" + log.LogActionType + "\", ";
            queryStr += "\"" + log.LogModNo + "\", ";
            queryStr += "\"U\")";

            using (SqlDataReader dr = efactDB.ExecuteDBCommand(queryStr, "ClseFactMethodsCreateUnauthorizedTransactionRecord2")) { };
        }
    }
}
