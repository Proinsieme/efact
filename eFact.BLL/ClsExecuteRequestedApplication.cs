using System;
using System.Windows;
using System.Windows.Controls;
using System.Configuration;

namespace eFact
{
    class ClsExecuteRequestedApplication
    {
        private Window secManUserListFrm = null;
        private Window budgetDetFrm = null;
        private Window clrUserListFrm = null;
        private Window deptFrm = null;
        private Window fixedAssetsDetFrm = null;
        private Window fixedAssetsLstFrm = null;
        private Window glClassListFrm = null;
        private Window glClassDetailFrm = null;
        private Window invoicesDetFrm = null;
        private Window invoicesLstFrm = null;
        private Window usersFrm = null;
        private Window userProfileListFrm = null;
        private Window userProfileFrm = null;
        private Window reportingFrm = null;
        private Window secManParamsFrm = null;
        private Window systemLogFrm = null;
        private Window transAuthFrm = null;
        private Window serviceListFrm = null;
        private Window serviceDetailsFrm = null;
        private Window supplierListFrm = null;
        private Window suppDetailsFrm = null;
        private Window transactionLogFrm = null;
        private Window applSettingsFrm = null;
        private Window activitiesAndAttentionsFrm = null;
        private Window humanResourceFrm = null;

        /// <summary>
        /// Execution of the requested Main application from the mainwindow 
        /// </summary>
        /// <param name="reqAplicationName"></param>
        public void ExecuteMainApplication(string reqAplicationName)
        {
            reqAplicationName = reqAplicationName.Replace(" ", ""); //Remove all spaces

            if (ConfigurationManager.AppSettings["SysBlock"].ToString() == "YeS")
            {
                reqAplicationName = "XXXXOEPSXXXX"; // We will block the system till the security param is authorized.
            }


            switch (reqAplicationName)
            {

                case "Budget":
                    if (budgetDetFrm == null || !budgetDetFrm.ShowActivated)
                    {
                        budgetDetFrm = new FrmBudgetList();
                        budgetDetFrm.Show();
                    }
                    else if (budgetDetFrm.ShowActivated)
                    {
                        if (budgetDetFrm.WindowState == WindowState.Minimized)
                        {
                            budgetDetFrm.WindowState = WindowState.Normal;
                        }
                        budgetDetFrm.Activate();
                        budgetDetFrm.Show();
                    }
                    break;
                case "ApplicationSettings":
                    if (applSettingsFrm == null || !applSettingsFrm.ShowActivated)
                    {
                        applSettingsFrm = new FrmApplicationSettings();
                        applSettingsFrm.Show();
                    }
                    else if (applSettingsFrm.ShowActivated)
                    {
                        if (applSettingsFrm.WindowState == WindowState.Minimized)
                        {
                            applSettingsFrm.WindowState = WindowState.Normal;
                        }
                        applSettingsFrm.Activate();
                        applSettingsFrm.Show();
                    }
                    break;
                case "ClearUsers":
                    if (clrUserListFrm == null || !clrUserListFrm.ShowActivated)
                    {
                        clrUserListFrm = new FrmCurrentLogedUsers();
                        clrUserListFrm.Show();
                    }
                    else if (clrUserListFrm.ShowActivated)
                    {
                        if (clrUserListFrm.WindowState == WindowState.Minimized)
                        {
                            clrUserListFrm.WindowState = WindowState.Normal;
                        }
                        clrUserListFrm.Activate();
                        clrUserListFrm.Show();
                    }
                    break;
                case "CreditorInvoiceProcessing":
                    if (invoicesLstFrm == null || !invoicesLstFrm.ShowActivated)
                    {
                        invoicesLstFrm = new FrmInvoiceList();
                        invoicesLstFrm.Show();
                    }
                    else if (invoicesLstFrm.ShowActivated)
                    {
                        if (invoicesLstFrm.WindowState == WindowState.Minimized)
                        {
                            invoicesLstFrm.WindowState = WindowState.Normal;
                        }
                        invoicesLstFrm.Activate();
                        invoicesLstFrm.Show();
                    }
                    break;
                case "FixedAssets":
                    if (fixedAssetsLstFrm == null || !fixedAssetsLstFrm.ShowActivated)
                    {
                        fixedAssetsLstFrm = new FrmFixedAssetList();
                        fixedAssetsLstFrm.Show();
                    }
                    else if (fixedAssetsLstFrm.ShowActivated)
                    {
                        if (fixedAssetsLstFrm.WindowState == WindowState.Minimized)
                        {
                            fixedAssetsLstFrm.WindowState = WindowState.Normal;
                        }
                        fixedAssetsLstFrm.Activate();
                        fixedAssetsLstFrm.Show();
                    }
                    break;
                case "GLClassifications":
                    if (glClassListFrm == null || !glClassListFrm.ShowActivated)
                    {
                        glClassListFrm = new FrmGLClassificationsList();
                        glClassListFrm.Show();
                    }
                    else if (glClassListFrm.ShowActivated)
                    {
                        if (glClassListFrm.WindowState == WindowState.Minimized)
                        {
                            glClassListFrm.WindowState = WindowState.Normal;
                        }
                        glClassListFrm.Activate();
                        glClassListFrm.Show();
                    }
                    break;
                case "Reporting":
                    if (reportingFrm == null || !reportingFrm.ShowActivated)
                    {
                        reportingFrm = new FrmReporting();
                        reportingFrm.Show();
                    }
                    else if (reportingFrm.ShowActivated)
                    {
                        if (reportingFrm.WindowState == WindowState.Minimized)
                        {
                            reportingFrm.WindowState = WindowState.Normal;
                        }
                        reportingFrm.Activate();
                        reportingFrm.Show();
                    }
                    break;
                case "SecurityManagement":
                    if (secManUserListFrm == null || !secManUserListFrm.ShowActivated)
                    {
                        secManUserListFrm = new UserListFrm();
                        secManUserListFrm.Show();
                    }
                    else if (secManUserListFrm.ShowActivated)
                    {
                        if (secManUserListFrm.WindowState == WindowState.Minimized)
                        {
                            secManUserListFrm.WindowState = WindowState.Normal;
                        }
                        secManUserListFrm.Activate();
                        secManUserListFrm.Show();
                    }
                    break;
                case "SecurityManagementUsers":
                    if (secManUserListFrm == null || !secManUserListFrm.ShowActivated)
                    {
                        secManUserListFrm = new UserListFrm();
                        secManUserListFrm.Show();
                    }
                    else if (secManUserListFrm.ShowActivated)
                    {
                        if (secManUserListFrm.WindowState == WindowState.Minimized)
                        {
                            secManUserListFrm.WindowState = WindowState.Normal;
                        }
                        secManUserListFrm.Activate();
                        secManUserListFrm.Show();
                    }
                    break;
                case "SecurityManagementProfiles":
                    if (userProfileListFrm == null || !userProfileListFrm.ShowActivated)
                    {
                        userProfileListFrm = new UserProfileListFrm();
                        userProfileListFrm.Show();
                    }
                    else if (userProfileListFrm.ShowActivated)
                    {
                        if (userProfileListFrm.WindowState == WindowState.Minimized)
                        {
                            userProfileListFrm.WindowState = WindowState.Normal;
                        }
                        userProfileListFrm.Activate();
                        userProfileListFrm.Show();
                    }
                    break;
                case "Services":
                    if (serviceListFrm == null || !serviceListFrm.ShowActivated)
                    {
                        serviceListFrm = new FrmServiceList();
                        serviceListFrm.Show();
                    }
                    else if (serviceListFrm.ShowActivated)
                    {
                        if (serviceListFrm.WindowState == WindowState.Minimized)
                        {
                            serviceListFrm.WindowState = WindowState.Normal;
                        }
                        serviceListFrm.Activate();
                        serviceListFrm.Show();
                    }
                    break;
                case "Suppliers":
                    if (supplierListFrm == null || !supplierListFrm.ShowActivated)
                    {
                        supplierListFrm = new FrmSupplierList();
                        supplierListFrm.Show();
                    }
                    else if (supplierListFrm.ShowActivated)
                    {
                        if (supplierListFrm.WindowState == WindowState.Minimized)
                        {
                            supplierListFrm.WindowState = WindowState.Normal;
                        }
                        supplierListFrm.Activate();
                        supplierListFrm.Show();
                    }
                    break;
                case "SystemLog":
                    if (systemLogFrm == null || !systemLogFrm.ShowActivated)
                    {
                        systemLogFrm = new FrmSystemLog();
                        systemLogFrm.Show();
                    }
                    else if (systemLogFrm.ShowActivated)
                    {
                        if (systemLogFrm.WindowState == WindowState.Minimized)
                        {
                            systemLogFrm.WindowState = WindowState.Normal;
                        }
                        systemLogFrm.Activate();
                        systemLogFrm.Show();
                    }
                    break;
                case "TransactionLog":
                    if (transactionLogFrm == null || !transactionLogFrm.ShowActivated)
                    {
                        transactionLogFrm = new FrmTransactionLog();
                        transactionLogFrm.Show();
                    }
                    else if (transactionLogFrm.ShowActivated)
                    {
                        if (transactionLogFrm.WindowState == WindowState.Minimized)
                        {
                            transactionLogFrm.WindowState = WindowState.Normal;
                        }
                        transactionLogFrm.Activate();
                        transactionLogFrm.Show();
                    }
                    break;
                case "TransactionApproval":
                    if (transAuthFrm == null || !transAuthFrm.ShowActivated)
                    {
                        transAuthFrm = new UnAuthorizedTransactionsFrm();
                        transAuthFrm.Show();
                    }
                    else if (transAuthFrm.ShowActivated)
                    {
                        if (transAuthFrm.WindowState == WindowState.Minimized)
                        {
                            transAuthFrm.WindowState = WindowState.Normal;
                        }
                        transAuthFrm.Activate();
                        transAuthFrm.Show();
                    }
                    break;
                case "HumanResource":
                     //activitiesAndAttentionsFrm = new FrmHRMActivitiesandAttentions();
                     //activitiesAndAttentionsFrm.Show();
                    if (activitiesAndAttentionsFrm == null || !activitiesAndAttentionsFrm.ShowActivated)
                    {
                        activitiesAndAttentionsFrm = new FrmHumanResource();
                        activitiesAndAttentionsFrm.Show();
                    }
                    else if (activitiesAndAttentionsFrm.ShowActivated)
                    {
                        if (activitiesAndAttentionsFrm.WindowState == WindowState.Normal)
                        {
                            activitiesAndAttentionsFrm.Close();
                            activitiesAndAttentionsFrm = new FrmHumanResource();
                            activitiesAndAttentionsFrm.Show();

                            //if (activitiesAndAttentionsFrm.WindowState == WindowState.Minimized)
                            //{
                            //    activitiesAndAttentionsFrm.WindowState = WindowState.Normal;
                            //}
                            //activitiesAndAttentionsFrm.Activate();
                            //activitiesAndAttentionsFrm.Show();
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Execution of sub application selected from the current running application
        /// </summary>
        /// <param name="reqAplicationName"></param>
        /// <param name="recordId"></param>
        public void ExecuteSubApplication(string reqAplicationName, DataGrid ParamListDataGrid, string requestedAction, string recordId)
        {
            if (ConfigurationManager.AppSettings["SysBlock"].ToString() == "YeS")
            {
                reqAplicationName = "XXXXOEPSXXXX"; // We will block the system till the security param is authorized.
            }

            switch (reqAplicationName)
            {
                case "SecurityParams":
                    if (secManParamsFrm == null || !secManParamsFrm.ShowActivated)
                    {
                        secManParamsFrm = new SecurityParamFrm(ParamListDataGrid, requestedAction, recordId);
                        secManParamsFrm.Show();
                    }
                    else if (secManParamsFrm.ShowActivated)
                    {
                        if (secManParamsFrm.WindowState == WindowState.Minimized)
                        {
                            secManParamsFrm.WindowState = WindowState.Normal;
                        }
                        secManParamsFrm.Activate();
                        secManParamsFrm.Show();
                    }
                    break;
                case "Users":
                    if (usersFrm == null || !usersFrm.ShowActivated)
                    {
                        usersFrm = new UsersFrm(ParamListDataGrid, requestedAction, recordId);
                        usersFrm.Show();
                    }
                    else if (usersFrm.ShowActivated)
                    {
                        usersFrm.Close();
                        usersFrm = new UsersFrm(ParamListDataGrid, requestedAction, recordId);
                        usersFrm.Show();
                    }
                    break;
                case "UserProfileList":
                    if (userProfileListFrm == null || !userProfileListFrm.ShowActivated)
                    {
                        userProfileListFrm = new UserProfileListFrm();
                        userProfileListFrm.Show();
                    }
                    else if (userProfileListFrm.ShowActivated)
                    {
                        if (userProfileListFrm.WindowState == WindowState.Minimized)
                        {
                            userProfileListFrm.WindowState = WindowState.Normal;
                        }
                        userProfileListFrm.Activate();
                        userProfileListFrm.Show();
                    }
                    break;
                case "UserProfile":
                    if (userProfileFrm == null || !userProfileFrm.ShowActivated)
                    {
                        userProfileFrm = new UserProfileFrm(ParamListDataGrid, requestedAction, recordId);
                        userProfileFrm.Show();
                    }
                    else if (userProfileFrm.ShowActivated)
                    {
                        userProfileFrm.Close();
                        userProfileFrm = new UserProfileFrm(ParamListDataGrid, requestedAction, recordId);
                        userProfileFrm.Show();
                    }
                    break;
                default:
                    break;
            }
        }


        public void ExecuteApplicationFrms(string reqAplicationName, DataGrid ParamListDataGrid, string requestedAction)
        {
            if (ConfigurationManager.AppSettings["SysBlock"].ToString() == "YeS")
            {
                reqAplicationName = "XXXXOEPSXXXX"; // We will block the system till the security param is authorized.
            }

            switch (reqAplicationName)
            {
                case "BudgetDetails":
                    if (budgetDetFrm == null || !budgetDetFrm.ShowActivated)
                    {
                        budgetDetFrm = new FrmBudgetDetails(ParamListDataGrid, requestedAction);
                        budgetDetFrm.Show();
                    }
                    else if (budgetDetFrm.ShowActivated)
                    {
                        budgetDetFrm.Close();
                        budgetDetFrm = new FrmBudgetDetails(ParamListDataGrid, requestedAction);
                        budgetDetFrm.Show();
                    }
                    break;
                case "Departments":
                    if (deptFrm == null || !deptFrm.ShowActivated)
                    {
                        deptFrm = new FrmDepartment(ParamListDataGrid, requestedAction);
                        deptFrm.Show();
                    }
                    else if (deptFrm.ShowActivated)
                    {
                        deptFrm.Close();
                        deptFrm = new FrmDepartment(ParamListDataGrid, requestedAction);
                        deptFrm.Show();
                    }
                    break;
                case "FixedAssetsDetails":
                    if (fixedAssetsDetFrm == null || !fixedAssetsDetFrm.ShowActivated)
                    {
                        fixedAssetsDetFrm = new FrmFixedAssetDetails(ParamListDataGrid, requestedAction);
                        fixedAssetsDetFrm.Show();
                    }
                    else if (fixedAssetsDetFrm.ShowActivated)
                    {
                        fixedAssetsDetFrm.Close();
                        fixedAssetsDetFrm = new FrmFixedAssetDetails(ParamListDataGrid, requestedAction);
                        fixedAssetsDetFrm.Show();
                    }
                    break;
                case "GLClassDetails":
                    if (glClassDetailFrm == null || !glClassDetailFrm.ShowActivated)
                    {
                        glClassDetailFrm = new FrmGLClassifications(ParamListDataGrid, requestedAction);
                        glClassDetailFrm.Show();
                    }
                    else if (glClassDetailFrm.ShowActivated)
                    {
                        glClassDetailFrm.Close();
                        glClassDetailFrm = new FrmGLClassifications(ParamListDataGrid, requestedAction);
                        glClassDetailFrm.Show();
                    }
                    break;
                case "ServiceDetails":
                    if (serviceDetailsFrm == null || !serviceDetailsFrm.ShowActivated)
                    {
                        serviceDetailsFrm = new FrmServiceDetails(ParamListDataGrid, requestedAction);
                        serviceDetailsFrm.Show();
                    }
                    else if (serviceDetailsFrm.ShowActivated)
                    {
                        serviceDetailsFrm.Close();
                        serviceDetailsFrm = new FrmServiceDetails(ParamListDataGrid, requestedAction);
                        serviceDetailsFrm.Show();
                    }
                    break;
                case "SupplierDetails":
                    if (suppDetailsFrm == null || !suppDetailsFrm.ShowActivated)
                    {
                        suppDetailsFrm = new FrmSupplierDetails(ParamListDataGrid, requestedAction);
                        suppDetailsFrm.Show();
                    }
                    else if (suppDetailsFrm.ShowActivated)
                    {
                        suppDetailsFrm.Close();
                        suppDetailsFrm = new FrmSupplierDetails(ParamListDataGrid, requestedAction);
                        suppDetailsFrm.Show();
                    }
                    break;
                case "InvoiceDetails":
                    if (invoicesDetFrm == null || !invoicesDetFrm.ShowActivated)
                    {
                        invoicesDetFrm = new FrmInvoiceDetails(ParamListDataGrid, requestedAction);
                        invoicesDetFrm.Show();
                    }
                    else if (invoicesDetFrm.ShowActivated)
                    {
                        invoicesDetFrm.Close();
                        invoicesDetFrm = new FrmInvoiceDetails(ParamListDataGrid, requestedAction);
                        invoicesDetFrm.Show();
                    }
                    break;
                case "HumanResource":
                    if (humanResourceFrm == null || !humanResourceFrm.ShowActivated)
                    {
                        humanResourceFrm = new FrmHumanResource();
                        humanResourceFrm.Show();
                    }
                    else if (humanResourceFrm.ShowActivated)
                    {
                        humanResourceFrm.Close();
                        humanResourceFrm = new FrmHumanResource();
                        humanResourceFrm.Show();
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
