using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;

namespace OpelTagInventory
{
  class functions
  {
    /// <summary>
    /// Collection of functions for doing useful things in the program. Reworked most of the data IO
    /// methods from my typical SQL server setup to work with SQLite. There are probably better ways to handle
    /// some of this when working with local DBs.
    /// </summary>
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
      //Use command builder to generate update commands and push the db
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
        , Mother nvarchar(200) not null
        , Baby nvarchar(200) null
        , Comments nvarchar(200) null)";
      runQuery(qt);

      qt = @"create table if not exists size 
        (id integer not null primary key autoincrement
        , Type nvarchar(200) not null
        , Comments nvarchar(200) null)";
      runQuery(qt);
      
      qt = @"create table if not exists locations 
        (id integer not null primary key autoincrement
        , locationName nvarchar(20) not null
        , Comments nvarchar(200) null)";
      runQuery(qt);

      qt = @"create table if not exists inventory 
        (id integer not null primary key autoincrement
        , itemId integer not null
        , sizeId integer not null
        , locId integer not null
        , qtyOnHand integer not null)";
      runQuery(qt);

      return true;
    }

    public static bool initDB()
    {
      string q = "drop table ";
      runQuery(q + "item");
      runQuery(q + "size");
      runQuery(q + "locations");
      runQuery(q + "inventory");
      createDB();
      return true;
    }

    public static void GridNavigation(UltraGrid grid, KeyEventArgs e)
    {
      //Navigate the grid with arrow keys
      switch (e.KeyCode)
      {
        case Keys.Up:
          grid.PerformAction(UltraGridAction.ExitEditMode, false, false);
          grid.PerformAction(UltraGridAction.AboveCell, false, false);
          e.Handled = true;
          grid.PerformAction(UltraGridAction.EnterEditMode, false, false);
          break;
        case Keys.Down:
          grid.PerformAction(UltraGridAction.ExitEditMode, false, false);
          grid.PerformAction(UltraGridAction.BelowCell, false, false);
          e.Handled = true;
          grid.PerformAction(UltraGridAction.EnterEditMode, false, false);
          break;
        case Keys.Left:
          grid.PerformAction(UltraGridAction.ExitEditMode, false, false);
          grid.PerformAction(UltraGridAction.PrevCell, false, false);
          e.Handled = true;
          grid.PerformAction(UltraGridAction.EnterEditMode, false, false);
          break;
        case Keys.Right:
          grid.PerformAction(UltraGridAction.ExitEditMode, false, false);
          grid.PerformAction(UltraGridAction.NextCell, false, false);
          e.Handled = true;
          grid.PerformAction(UltraGridAction.EnterEditMode, false, false);
          break;
        case Keys.Enter:
          grid.PerformAction(UltraGridAction.ExitEditMode, false, false);
          grid.PerformAction(UltraGridAction.BelowCell, false, false);
          e.Handled = true;
          grid.PerformAction(UltraGridAction.EnterEditMode, false, false);
          break;
      }
    }
  }
}
