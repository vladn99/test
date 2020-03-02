using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

class @base
{
    private static string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + Environment.CurrentDirectory.Replace(@"\bin\Debug", "") + "\\Database1.mdf;Integrated Security=True;";
    SqlConnection connection = new SqlConnection(ConnectionString);
    private string sqlExpression = "";
    public @base(string sqlExpression) 
    {
        smena_zaprosa(sqlExpression);
    }
    public void zapis_v_bd() 
    {
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        command.ExecuteNonQuery();
        connection.Close();
    }
    public int proverka_znachenei_v_bd()
    {
        int rez = 0;
        connection.Open();
        SqlCommand command = new SqlCommand(sqlExpression, connection);
        SqlDataReader reader = command.ExecuteReader();
        if (reader.HasRows)
        {
            while (reader.Read())
            {
                try
                {
                    rez += reader.GetInt32(0);
                }
                catch 
                {
                    break;
                }
            }
        }
        connection.Close();
        return rez;
    }
    public void smena_zaprosa(string sqlExpression) 
    {
        this.sqlExpression = sqlExpression;
    }
}

