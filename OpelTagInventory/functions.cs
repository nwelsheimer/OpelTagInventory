using System;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using Infragistics.Win.UltraWinGrid;
using OfficeOpenXml;

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
    private static string PIN = "9548";

    #region db functions
    private static void ConnectDB()
    {
      //Connect to the sqlite instance
      try
      {
        string dbName = Properties.Settings.Default.DBName;
        con = new SQLiteConnection("Data Source=" + dbName + ";Version=3;New=False;Compress=True");
      }
      catch (Exception ex)
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
        , qtyOnHand integer null)";
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
    #endregion
    #region grid stuff
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

    public static void xlGridExport(DataTable export)
    {
      SaveFileDialog sf = new SaveFileDialog();
      sf.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      sf.AddExtension = true;
      sf.Filter = "Excel file (*.xlsx)|*.xlsx";
      if (sf.ShowDialog() == DialogResult.OK)
      {
        const int startRow = 1;
        string fileName = sf.FileName;

        if (fileName != "")
        {
          try
          {
            //Delete the old file if it exists
            if (File.Exists(fileName)) File.Delete(fileName);
            FileInfo newFile = new FileInfo(fileName);
            
            int totalColumns = export.Columns.Count;
            Char lastColumn = LetterToNum(totalColumns);

            // Build the workbook
            using (ExcelPackage xlPackage = new ExcelPackage(newFile))
            {
              ExcelWorksheet worksheet = xlPackage.Workbook.Worksheets.Add("Export");
              int row = startRow;

              //output column headings
              for (int i = 1; i <= totalColumns; i++)
              {
                worksheet.Cells[LetterToNum(i) + row.ToString()].Value = export.Columns[i - 1].ColumnName;
              }
              row++;

              // get the data and fill onwards
              foreach (DataRow dr in export.Rows)
              {
                int col = 1;
                for (int i = 0; i < totalColumns; i++)
                {
                  // do not bother filling cell with blank data (also useful if we have a formula in a cell)
                  worksheet.Cells[row, i + 1].Value = dr[i];
                  col++;
                }
                row++;
              }
              // save the new spreadsheet
              xlPackage.Save();
            }
            if (MessageBox.Show("Do you want to open the file?", "Excel", MessageBoxButtons.YesNo) == DialogResult.Yes)
              System.Diagnostics.Process.Start(sf.FileName);
          }
          catch (Exception x) //Somehting went wrong
          {
            MessageBox.Show("There was a problem processing the export: " + x);
          }
        }
      }
    }

    public static DataTable xlGridImport()
    {
      DataTable tbl = new DataTable();
      OpenFileDialog of = new OpenFileDialog();
      of.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
      of.Filter = "Excel file (*.xlsx)|*.xlsx";
      of.RestoreDirectory = true;
      if (of.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        var stream = File.OpenRead(of.FileName);

        using (ExcelPackage pck = new ExcelPackage(stream))
        {
          var ws = pck.Workbook.Worksheets[1];
          
          foreach (var firstRowCell in ws.Cells[1, 1, 1, ws.Dimension.End.Column])
          {
            tbl.Columns.Add(firstRowCell.Text);
          }

          tbl.Columns[0].DataType = typeof(Int64);//make the first column int for dealing with IDs

          for (int rowNum = 2; rowNum <= ws.Dimension.End.Row; rowNum++)
          {
            var wsRow = ws.Cells[rowNum, 1, rowNum, ws.Dimension.End.Column];
            DataRow row = tbl.Rows.Add();
            foreach (var cell in wsRow)
            {
              row[cell.Start.Column - 1] = cell.Text;
            }
          }
        }
      }
      return tbl;
    }
    #endregion
    #region misc
    public static bool promptForPin()
    {
      string pin = Microsoft.VisualBasic.Interaction.InputBox("Please enter admin PIN to continue. 9548", "Secure Operation", "");
      if (pin == PIN)
        return true;
      else
        return false;
    }

    public static char LetterToNum(int column)
    {
      Char colLetter = (Char)(65 + (column - 1));
      return colLetter;
    }
    #endregion
  }
}
