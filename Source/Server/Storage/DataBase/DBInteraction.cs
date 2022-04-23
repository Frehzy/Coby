using MySql.Data.MySqlClient;
using Shared;
using Shared.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Storage.DataBase;

internal class DBInteraction
{
    public string Host { get; }

    public string DataBaseName { get; }

    public int Port { get; }

    public string Username { get; }

    public string Password { get; }

    public DBInteraction(string host, string dataBaseName, int port, string username, string password)
    {
        Host = host;
        DataBaseName = dataBaseName;
        Port = port;
        Username = username;
        Password = password;
    }

    public MySqlConnection GetDBConnection(int timeOut = 30)
    {
        string connString = "Server=" + Host
            + ";Database=" + DataBaseName
            + ";port=" + Port
            + ";User Id=" + Username
            + ";password=" + Password
            + ";Connection Timeout=" + timeOut;

        MySqlConnection conn = new(connString);

        return conn;
    }

    public DBConnectionStatus CheckDB()
    {
        using MySqlConnection myConnection = GetDBConnection(1);
        try
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            return DBConnectionStatus.Success;
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return DBConnectionStatus.Error;
        }
    }

    public DataTable GetDBTableByQuery(string query)
    {
        using MySqlConnection myConnection = GetDBConnection();
        try
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            DataTable table = new();
            MySqlDataAdapter adapter = new();
            MySqlCommand command = new(query, myConnection);

            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return null;
        }
    }

    public List<T> SqlQuery<T>(string query)
    {
        var result = new List<T>();

        using (MySqlConnection connection = GetDBConnection(1))
        {
            connection.Open();
            using var command = connection.CreateCommand();
            command.CommandText = query;
            using var reader = command.ExecuteReader();
            var columns = Enumerable.Range(0, reader.FieldCount).Select(reader.GetName).ToArray();
            var properties = typeof(T).GetProperties();

            while (reader.Read())
            {
                var data = new object[reader.FieldCount];
                reader.GetValues(data);

                var instance = (T)Activator.CreateInstance(typeof(T));

                for (var i = 0; i < data.Length; ++i)
                {
                    if (data[i] == DBNull.Value)
                        data[i] = null;

                    var property = properties.SingleOrDefault(x => x.Name.Equals(columns[i], StringComparison.InvariantCultureIgnoreCase));

                    if (property is not null)
                    {
                        var dataValue = Guid.TryParse(data[i].ToString(), out Guid res) is true ? res : data[i];
                        property.SetValue(instance, Convert.ChangeType(dataValue, property.PropertyType));
                    }
                }
                result.Add(instance);
            }
        }
        return result;
    }

    public DBResponseStatus ExecuteNonQuery(string query)
    {
        using MySqlConnection myConnection = GetDBConnection();
        try
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            MySqlCommand command = new(query, myConnection);
            command.ExecuteNonQuery();
            return DBResponseStatus.OK;
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return DBResponseStatus.Error;
        }
    }

    public string ExecuteScalar(string query)
    {
        using MySqlConnection myConnection = GetDBConnection();
        try
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            MySqlCommand command = new(query, myConnection);
            return command.ExecuteScalar().ToString();
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return "";
        }
    }
}