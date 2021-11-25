using FirebirdSql.Data.FirebirdClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInterface
{
    static class DatabaseConnection
    {
        public static int FindHighestIDinTableEmployees()
        {
            int licznikID;
            List<TableOfIds> listOfIds = new List<TableOfIds>();
            FbConnection fbConnection = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            FbDataReader myReader = null;
            string sql = "Select id from TableEmployees";
            FbCommand myCommand = new FbCommand(sql, fbConnection);
            fbConnection.Open();
            myCommand.CommandTimeout = 0;
            myReader = myCommand.ExecuteReader();
            while (myReader.Read())
            {
                listOfIds.Add(new TableOfIds { Id = (int)myReader["id"] });
            }
            fbConnection.Close();
            licznikID = listOfIds.Max(t => t.Id) + 1;
            return licznikID;
        }
        public static void InsertNewEmployeeToTableEmployees(int licznikID, byte[] content, string stSql)
        {
            FbConnection fbConn = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            fbConn.Open();
            FbTransaction fbTransaction = fbConn.BeginTransaction();
            FbCommand fbCmd = new FbCommand(stSql, fbConn, fbTransaction);
            fbCmd.Parameters.Add("@photo", FbDbType.Binary).Value = content;
            fbCmd.ExecuteNonQuery();
            fbTransaction.Commit();
            fbConn.Close();
        }
        public static dynamic SelectFromTableEmployeesByLastName(string lastNameFilter)
        {
            FbConnection fbConnection = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            FbDataAdapter fbDataAdapter = new FbDataAdapter("Select * from TableEmployees WHERE LastName LIKE '" + lastNameFilter + "';", fbConnection);
            fbConnection.Open();
            DataSet ds = new DataSet();
            fbDataAdapter.Fill(ds, "Select");
            DataTable dt = ds.Tables["Select"];
            dynamic result = ds.Tables["Select"];
            fbConnection.Close();
            return result;
        }
        public static void UpdateRecordInTableEmployees(byte[] content, string stSql)
        {
            FbConnection fbConn = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            fbConn.Open();
            FbTransaction fbTransaction = fbConn.BeginTransaction();
            FbCommand fbCmd = new FbCommand(stSql, fbConn, fbTransaction);
            fbCmd.Parameters.Add("@photo", FbDbType.Binary).Value = content;
            fbCmd.ExecuteNonQuery();
            fbTransaction.Commit();
            fbConn.Close();
        }
        public static void DeleteRecordFromTableEmployees(string stSql)
        {
            FbConnection fbConn = new FbConnection(@"Server=localhost;User=Stream1;Password=Pass123;Database=D:\dokumenty\StreamsoftEmployees.fdb");
            fbConn.Open();
            FbTransaction fbTransaction = fbConn.BeginTransaction();
            FbCommand fbCmd = new FbCommand(stSql, fbConn, fbTransaction);
            fbCmd.ExecuteNonQuery();
            fbTransaction.Commit();
            fbConn.Close();
        }
        public class TableOfIds
        {
            public int Id { get; set; }
        }
    }
}
