using MySql.Data.MySqlClient;
using Storage.Enums;
using System;
using System.Data;

namespace Storage.DataBase;

public class DBInteraction
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

    #region Использовать в формате: using (MySqlConnection myConnection = GetDBConnection())
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
    #endregion

    #region методы для проверки соединения с бд
    public DataBaseStatus CheckDB()
    {
        using MySqlConnection myConnection = GetDBConnection(1);
        try
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            return DataBaseStatus.Success;
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return DataBaseStatus.Error;
        }
    }
    #endregion

    #region Метод для создания запросов для получения ТАБЛИЦЫ
    public DataTable QueryDBForTable(string query)
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
    #endregion

    #region Метод для создания запросов для добавления, удаления и тд
    public bool DBNonQuery(string query)
    {
        using MySqlConnection myConnection = GetDBConnection();
        try
        {
            if (myConnection.State == ConnectionState.Closed)
                myConnection.Open();

            MySqlCommand command = new(query, myConnection);
            command.ExecuteNonQuery();
            return true;
        }
        catch (Exception ex)
        {
            Log.Error(ex.ToString());
            return false;
        }
    }
    #endregion

    #region Метод для создания запросов для добавления, удаления и тд
    public string DBScalar(string query)
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
    #endregion
}