using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace eFact.BLL
{
    public class DocumentType
    {
        public int DocumentTypeId { get; set; }
        public string DocumentTypeName { get; set; }
        public string DocumentDescription { get; set; }
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public string Comments { get; set; }
        public string DocumentLink { get; set; }

        string connStr = ConfigurationManager.ConnectionStrings["DBconnStr"].ToString();
        string appPath = ConfigurationManager.AppSettings["AttachFilePath"].ToString();

        public List<DocumentType> GetDocumentType()
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<DocumentType> documentTypeList = new List<DocumentType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetDocumentType", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    DocumentType documentType = new DocumentType
                    {
                        DocumentTypeId = (Convert.ToInt32(sqlReader["DocumentTypeId"])),
                        DocumentTypeName = sqlReader["DocumentType"].ToString(),
                        DocumentDescription = sqlReader["DocumentTypeDescription"].ToString()
                    };
                    documentTypeList.Add(documentType);
                }
                return documentTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int SaveDocumentDetails(DocumentType documentType, int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_SaveDocumentDetails", sqlConnection);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.Int).Value = employeeId;
                sqlCommand.Parameters.Add("@DocumentId", SqlDbType.Int).Value = DocumentId;
                sqlCommand.Parameters.Add("@DocumentTypeId", SqlDbType.Int).Value = DocumentTypeId;
                sqlCommand.Parameters.Add("@DocumentName", SqlDbType.VarChar).Value = DocumentName;
                sqlCommand.Parameters.Add("@Comments", SqlDbType.VarChar).Value = Comments;
                sqlCommand.Parameters.Add("@DocumentLink", SqlDbType.VarChar).Value = DocumentLink;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DocumentType> GetDocumentDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<DocumentType> documentTypeList = new List<DocumentType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetDocumentDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    DocumentType documentType = new DocumentType
                    {
                        DocumentId = (Convert.ToInt32(sqlReader["DocumentId"])),
                        DocumentTypeId = (Convert.ToInt32(sqlReader["DocumentTypeId"])),
                        DocumentTypeName = sqlReader["DocumentType"].ToString(),
                        DocumentName = sqlReader["DocumentName"].ToString(),
                        DocumentLink = appPath + sqlReader["DocumentLink"].ToString(),
                        Comments = sqlReader["Comments"].ToString()
                    };
                    documentTypeList.Add(documentType);
                }
                return documentTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DocumentType> GetSalaryDocumentDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<DocumentType> documentTypeList = new List<DocumentType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetSalaryDocumentDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    DocumentType documentType = new DocumentType
                    {
                        DocumentId = (Convert.ToInt32(sqlReader["DocumentId"])),
                        DocumentTypeId = (Convert.ToInt32(sqlReader["DocumentTypeId"])),
                        DocumentTypeName = sqlReader["DocumentType"].ToString(),
                        DocumentName = sqlReader["DocumentName"].ToString(),
                        DocumentLink = appPath + sqlReader["DocumentLink"].ToString(),
                        Comments = sqlReader["Comments"].ToString()
                    };
                    documentTypeList.Add(documentType);
                }
                return documentTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<DocumentType> GetAppraisalDocumentDetailsByEmployeeId(int employeeId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            SqlDataReader sqlReader;
            List<DocumentType> documentTypeList = new List<DocumentType>();
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_GetAppraisalDocumentDetailsByEmployeeId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlReader = sqlCommand.ExecuteReader();
                while (sqlReader.Read())
                {
                    DocumentType documentType = new DocumentType
                    {
                        DocumentId = (Convert.ToInt32(sqlReader["DocumentId"])),
                        DocumentTypeId = (Convert.ToInt32(sqlReader["DocumentTypeId"])),
                        DocumentTypeName = sqlReader["DocumentType"].ToString(),
                        DocumentName = sqlReader["DocumentName"].ToString(),
                        DocumentLink = appPath + sqlReader["DocumentLink"].ToString(),
                        Comments = sqlReader["Comments"].ToString()
                    };
                    documentTypeList.Add(documentType);
                }
                return documentTypeList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteDocumentDetailsByDocumentId(int employeeId, int documentId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output = 0;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_DeleteDocumentDetailsByDocumentId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@DocumentId", SqlDbType.VarChar).Value = documentId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int DeleteImportedDocumentDetailsByDocumentId(int employeeId, int documentId)
        {
            SqlConnection sqlConnection = new SqlConnection(connStr);
            int output = 0;
            try
            {
                if (sqlConnection.State == ConnectionState.Closed)
                {
                    sqlConnection.Open();
                }

                SqlCommand sqlCommand = new SqlCommand("usp_DeleteImportedDocumentByDocumentId", sqlConnection);
                sqlCommand.Parameters.Add("@EmployeeId", SqlDbType.VarChar).Value = employeeId;
                sqlCommand.Parameters.Add("@DocumentId", SqlDbType.VarChar).Value = documentId;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                output = Convert.ToInt32(sqlCommand.ExecuteScalar());
                return output;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
