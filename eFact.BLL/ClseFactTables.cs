using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eFact
{
    class ClseFactTables
    {
    }

    class eFacSysLog
    {
        public eFacSysLog()
        {
            UserId = "";
            FunctionId = "";
            FunctionKey = "";
            ActionType = "";
            RecordModNo = 0;
            DateStamp = DateTime.Now;
        }

        public string UserId { get; set; }
        public string FunctionId { get; set; }
        public string FunctionKey { get; set; }
        public string ActionType { get; set; }
        public int RecordModNo { get; set; }
        public DateTime DateStamp { get; set; }
    }

    class eFactBudget
    {
        public string BudgetCatName { get; set; }
        public string ButgetCatDeciption { get; set; }
        public DateTime BudStartDate { get; set; }
        public DateTime BudEndDate { get; set; }
        public string BudAmount { get; set; }
        public string BudStatus { get; set; }
        public string BudNotes { get; set; }
        public string BudModNo { get; set; }
        public string BudRecStat { get; set; }
        public DateTime BudInputDate { get; set; }
        public string BudInputName { get; set; }
        public DateTime BudAuthDate { get; set; }
        public string BudAuthName { get; set; }
    }


    class eFactServices
    {
        public string ServiceId { get; set; }
        public string ServiceDescription { get; set; }
        public string ServiceNotes { get; set; }
        public DateTime ServiceCreationDate { get; set; }
        public string ServiceModNo { get; set; }
        public string ServiceRecordStatus { get; set; }
        public DateTime ServiceInputDate { get; set; }
        public string ServiceInputName { get; set; }
        public DateTime ServiceAuthDate { get; set; }
        public string ServiceAuthName { get; set; }
    }

    class eFactSuppliers
    {
        public string SuppId { get; set; }
        public string ServiceId { get; set; }
        public string SuppName { get; set; }
        public string SuppAddress { get; set; }
        public string SuppCity { get; set; }
        public string SuppCountry { get; set; }
        public string SuppContactName { get; set; }
        public string SuppTelNo { get; set; }
        public string SuppEmail { get; set; }
        public string SuppResidency { get; set; }
        public string SuppCOC { get; set; }
        public string SuppVAT { get; set; }
        public string SuppBankName { get; set; }
        public string SuppBIC { get; set; }
        public string SuppAccNo { get; set; }
        public string SuppIBAN { get; set; }
        public string SuppCorrpBank { get; set; }
        public string SuppSortCode { get; set; }
        public string SuppBranch { get; set; }
        public string SuppCorrpInternAccNo { get; set; }
        public string SuppCreditorNoIntern { get; set; }
        public string SuppDebitorNoExtern { get; set; }
        public string SuppRelatedDept { get; set; }
        public string SuppRecurning { get; set; }
        public string SuppBudgetCategory { get; set; }
        public string SuppDebitGL { get; set; }
        public string SuppCreditGL { get; set; }
        public string SuppCreditAccNo { get; set; }
        public string SuppNotes { get; set; }
        public DateTime SuppCreationDate { get; set; }
        public string SuppStatus { get; set; }
        public string SuppModNo { get; set; }
        public string SuppRecordStatus { get; set; }
        public DateTime SuppInputDate { get; set; }
        public string SuppInputName { get; set; }
        public DateTime SuppAuthDate { get; set; }
        public string SuppAuthName { get; set; }
    }

    class eFactInvoiceMaster
    {
        public string InvoiceId { get; set; }
        public string InvoiceNo { get; set; }
        public string InvSuppId { get; set; }
        public string SuppName { get; set; } //Only needed for the datagrid is not included in InvoiceMaster Table
        public string InvFixAssetNo { get; set; }
        public string InvCCY { get; set; }
        public string InvOrgCCY { get; set; }
        public string InvOrgAmount { get; set; }
        public DateTime InvDate { get; set; }
        public DateTime InvPayDate { get; set; }
        public string InvPayMethod { get; set; }
        public string InvOurRef { get; set; }
        public string InvOpexCat { get; set; }
        public string InvBudCatActive { get; set; }
        public string InvBudCat { get; set; }
        public string InvDebitGL { get; set; }
        public string InvCreditGL { get; set; }
        public string InvConfirmed { get; set; }
        public string InvReverseCharge { get; set; }
        public string InvVATExcl { get; set; }
        public string InvCycleYear { get; set; }
        public string InwCycleQtr { get; set; }
        public string InvType1 { get; set; }
        public string InvType2 { get; set; }
        public string InvNotes { get; set; }
        public string InvModNo { get; set; }
        public string InvRecStat { get; set; }
        public DateTime InvInputDate { get; set; }
        public string InvInputName { get; set; }
        public DateTime InvAuthDate { get; set; }
        public string InvAuthName { get; set; }
    }

    class eFactInvoiceDetails
    {
        public eFactInvoiceDetails()
        {
            InvDetId = "";
            InvDetLCYAmount = "";
            InvDetFCYAmount = "";
            InvdetDebitGL = "";
            InvDetVATPerc = "";
            InvDetVATAmount = "";
            InvDetDesc = "";
        }

        public string InvDetId { get; set; }
        public string InvDetLCYAmount { get; set; }
        public string InvDetFCYAmount { get; set; }
        public string InvdetDebitGL { get; set; }
        public string InvDetVATPerc { get; set; }
        public string InvDetVATAmount { get; set; }
        public string InvDetDesc { get; set; }
    }

    class eFactGLClass
    {
        public string GLClassId { get; set; }
        public string GLClassDescription { get; set; }
        public DateTime GLClassCreationDate { get; set; }
        public string GLClassModNo { get; set; }
        public string GLClassRecordStatus { get; set; }
        public DateTime GLClassInputDate { get; set; }
        public string GLClassInputName { get; set; }
        public DateTime GLClassAuthDate { get; set; }
        public string GLClassAuthName { get; set; }
    }

    class eFactFixedAssets
    {
        public string FixedAssetsNo { get; set; }
        public string FixedAssetsName { get; set; }
        public string FixedAssetsDescr { get; set; }
        public string FixedAssetsType { get; set; }
        public string FixedAssetsMethod { get; set; }
        public string FixedAssetsCreateDate { get; set; }
        public string FixedAssetsModNo { get; set; }
        public string FixedAssetsRecStat { get; set; }
        public DateTime FixedAssetsInputDate { get; set; }
        public string FixedAssetsInputName { get; set; }
        public DateTime FixedAssetsAuthDate { get; set; }
        public string FixedAssetsAuthName { get; set; }
    }
}
