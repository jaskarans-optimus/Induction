using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Data;
namespace Assignment17
{
    public class UtilityFunctions
    {
        public static Dictionary<int, string> GetAllStreams()
        {
            Dictionary<int, string> streams = new Dictionary<int, string>();
            try
            {
                String sqlQuery = String.Format("Select * FROM Streams");
                String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        streams[Convert.ToInt32(dataReader["StreamID"])] = dataReader["Name"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                LogToEventLog(e);
            }
            return streams;
        }
        public static Dictionary<int, string> GetAllStates()
        {
            Dictionary<int, string> states = new Dictionary<int, string>();
            try
            {
                String sqlQuery = String.Format("Select * FROM [State]");
                String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        states[Convert.ToInt32(dataReader["StateID"])] = dataReader["Name"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                LogToEventLog(e);
            }
            return states;
        }
        public static string GetStateName(int stateID)
        {
            String stateName = "";
            try
            {
                String sqlQuery = String.Format("Select Name FROM [State] WHERE StateID={0}", stateID);
                String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        stateName = dataReader["Name"].ToString();
                    }
                }
            }
            catch (Exception e)
            {
                LogToEventLog(e);
            }
            return stateName;
        }
        public static string GetStreamName(int streamID)
        {
            String streamName = "";
            try
            {
                String sqlQuery = String.Format("Select Name FROM [Streams] WHERE StreamID={0}", streamID);
                String conString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
                SqlConnection connection = new SqlConnection(conString);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        streamName = dataReader["Name"].ToString();
                    }
                }
             
            }
            catch (Exception e)
            {
                LogToEventLog(e);
            }
            return streamName;
            
        }
        public static DataSet GetData(string queryString)
        {
            String connectionString = ConfigurationManager.ConnectionStrings["UniversityDB"].ConnectionString;
            DataSet dataSet = new DataSet();
            try
            {
                
                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter(queryString, connection);


                adapter.Fill(dataSet);

            }
            catch (Exception ex)
            {

                // The connection failed. Display an error message.
                LogToEventLog(ex);
            }
            return dataSet;
        }
        public static void LogToEventLog(Exception e)
        {
            EventLog.WriteEntry("In Application Log to Event :", e.Message + "Trace" +e.StackTrace, EventLogEntryType.Error, 121, short.MaxValue);
        }
    }
}