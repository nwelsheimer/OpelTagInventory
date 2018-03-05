using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace OpelTagInventory
{
  class functions
  {
    private static SQLiteConnection con;
    private static SQLiteCommand cmd;

    private static void ConnectDB()
    {
      //Connect to the sqlite instance
      try
      {
        string dbName = Properties.Settings.Default.DBName;
        con = new SQLiteConnection("Data Source="+dbName+";Version=3;New=False;Compress=True");
      } catch (Exception ex)
      {
        MessageBox.Show("There was an error connecting to the local DB.\n Error:" + ex);
      }
    }

    public static void runQuery(string q)
    {
      //Execute a query without returning results
      try
      {
        ConnectDB();
        con.Open();
        cmd = con.CreateCommand();
        cmd.CommandText = q;
        cmd.ExecuteNonQuery();

        cmd.CommandText = "";
        con.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("There was an error executing the query.\n Query text: " + q + "\n Error: " + ex);
      }
    }

    public static DataSet getData(string q)
    {
      //Execute query and return the results
      DataSet ds = new DataSet();

      try
      {
        ConnectDB();
        con.Open();
        //cmd = con.CreateCommand();

        SQLiteDataAdapter dap = new SQLiteDataAdapter(q, con);
        ds.Reset();

        dap.Fill(ds);

        cmd.CommandText = "";
        con.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("There was an error executing the query.\n Query text: " + q + "\n Error: " + ex);
      }

      return ds;
    }

    public static void updateData(DataTable dt, string q)
    {
      ConnectDB();
      con.Open();
      SQLiteDataAdapter dap = new SQLiteDataAdapter(q, con);

      SQLiteCommandBuilder build = new SQLiteCommandBuilder(dap);

      dap.UpdateCommand = build.GetUpdateCommand();
      dap.InsertCommand = build.GetInsertCommand();
      dap.DeleteCommand = build.GetDeleteCommand();

      dap.Update(dt);
    }

    public static bool createDB()
    {
      //Setup tables for a clean database.
      string qt = "";

      qt = @"create table if not exists item 
        (id integer not null primary key autoincrement
        , itemDescription nvarchar(200) not null
        , itemDescription2 nvarchar(200) null)";
      runQuery(qt);

      qt = @"create table if not exists size 
        (id integer not null primary key autoincrement
        , sizeDescription nvarchar(200) not null
        , sizeDescription2 nvarchar(200) null)";
      runQuery(qt);

      qt = @"create table if not exists itemDetail 
        (id integer not null primary key autoincrement
        , itemId integer not null
        , sizeId integer not null
        , active tinyint not null)";
      runQuery(qt);

      qt = @"create table if not exists locations 
        (id integer not null primary key autoincrement
        , locationName nvarchar(20) not null)";
      runQuery(qt);

      qt = @"create table if not exists inventory 
        (id integer not null primary key autoincrement
        , itemDetailId integer not null
        , locationId integer not null)";
      runQuery(qt);

      return true;
    }
  }
}
