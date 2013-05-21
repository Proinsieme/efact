using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFact
{
    class ClsTransListDataGrid
    {
        public string TransactionId { get; set; }
        public string TransRecordKey { get; set; }
        public string InputUser { get; set; }
        public DateTime InputDate { get; set; }
        public string ApplModule { get; set; }
        public string ActionType { get; set; }
        public string ModNo { get; set; }
        public string RecordStatus { get; set; }
    }
}
