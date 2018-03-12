using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpelTagInventory
{
  public partial class frmSetup : Form
  {
    //Grid datasets
    DataSet items;
    DataSet sizes;
    DataSet locations;
    //Grid Queries
    string itemQuery = "select * from item";
    string sizeQuery = "select * from size";
    string locationQuery = "select * from locations";

    public frmSetup()
    {
      InitializeComponent();
    }

    private void frmSetup_Load(object sender, EventArgs e)
    {
      //Get the current DB name from the application settings.
      //Future thoughts, we could manage multiple database with some sort of chooser
      txtDBName.Text = Properties.Settings.Default.DBName;

      loadGrid();
    }

    #region Grid building
    private void loadGrid()
    {
      //Run queries, fill datasets, populate and format the grids
      items = functions.getData(itemQuery);
      grdItems.DataSource = items.Tables[0];
      formatItemGrid();

      sizes = functions.getData(sizeQuery);
      grdSize.DataSource = sizes.Tables[0];
      formatSizeGrid();

      locations = functions.getData(locationQuery);
      grdLocation.DataSource = locations.Tables[0];
      formatLocGrid();
    }

    private void formatItemGrid()
    {
      if (grdItems.DisplayLayout.Bands[0].Columns.Count>0)
      {
        grdItems.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, true);

        grdItems.DisplayLayout.Bands[0].Columns["id"].Hidden = true;
        grdItems.DisplayLayout.Bands[0].Columns["id"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled;
      }
    }

    private void formatSizeGrid()
    {
      if (grdSize.DisplayLayout.Bands[0].Columns.Count > 0)
      {
        grdSize.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, true);

        grdSize.DisplayLayout.Bands[0].Columns["id"].Hidden = true;
        grdSize.DisplayLayout.Bands[0].Columns["id"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled;
      }
    }

    private void formatLocGrid()
    {
      if (grdLocation.DisplayLayout.Bands[0].Columns.Count > 0)
      {
        grdLocation.DisplayLayout.PerformAutoResizeColumns(false, Infragistics.Win.UltraWinGrid.PerformAutoSizeType.AllRowsInBand, true);

        grdLocation.DisplayLayout.Bands[0].Columns["id"].Hidden = true;
        grdLocation.DisplayLayout.Bands[0].Columns["id"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled;

        grdLocation.DisplayLayout.Bands[0].Columns["locationName"].Header.Caption = "Location Name";
      }
    }
    #endregion
    #region Button Pushing
    private void btnSave_Click(object sender, EventArgs e)
    {
      if (txtDBName.TextLength > 0)
        Properties.Settings.Default.DBName = txtDBName.Text;
      else
        MessageBox.Show("Database name not changed, please enter a valid name.");

      Properties.Settings.Default.Save();
    }

    private void btnInit_Click(object sender, EventArgs e)
    {
      if (MessageBox.Show("WARNING: This function initializes the indicated database. This means ALL data will be lost!", "WARNING!!!", MessageBoxButtons.OKCancel) == DialogResult.OK)
      {
        if (functions.promptForPin())
        {
          functions.initDB();
          //functions.runQuery("insert into inventory (itemId,sizeId,locId,qtyOnHand) values (1,1,1,200)"); Debugging
          MessageBox.Show("Database successfully initialized.");
          loadGrid();
        }
      }
    }

    private void grdItems_KeyDown(object sender, KeyEventArgs e)
    {
      functions.GridNavigation(grdItems, e);
    }

    private void grdSize_KeyDown(object sender, KeyEventArgs e)
    {
      functions.GridNavigation(grdSize, e);
    }

    private void grdLocation_KeyDown(object sender, KeyEventArgs e)
    {
      functions.GridNavigation(grdLocation, e);
    }
    #endregion
    #region Updates
    private void grdItems_AfterRowsDeleted(object sender, EventArgs e)
    {
      functions.updateData(items.Tables[0], itemQuery);
    }

    private void grdItems_AfterRowUpdate(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
    {
      functions.updateData(items.Tables[0], itemQuery);
    }

    private void grdSize_AfterRowUpdate(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
    {
      functions.updateData(sizes.Tables[0], sizeQuery);
    }

    private void grdSize_AfterRowsDeleted(object sender, EventArgs e)
    {
      functions.updateData(sizes.Tables[0], sizeQuery);
    }

    private void grdLocation_AfterRowsDeleted(object sender, EventArgs e)
    {
      functions.updateData(locations.Tables[0], locationQuery);
    }

    private void grdLocation_AfterRowUpdate(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
    {
      functions.updateData(locations.Tables[0], locationQuery);
    }

    #endregion
    private void lnExportItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      functions.xlGridExport(items.Tables[0]);
    }

    private void lnImportItems_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DataTable import = functions.xlGridImport();
      //import.Columns.Add("id", typeof(Int64)).SetOrdinal(0);
      items.Tables[0].Merge(import);
      functions.updateData(items.Tables[0], itemQuery);
    }

    private void lnExportSize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      functions.xlGridExport(sizes.Tables[0]);
    }

    private void lnImportSize_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DataTable import = functions.xlGridImport();
      //import.Columns.Add("id", typeof(Int64)).SetOrdinal(0);
      import.Columns[0].DataType = typeof(Int64);
      sizes.Tables[0].Merge(import);
      functions.updateData(sizes.Tables[0], sizeQuery);
    }

    private void lnImportLoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DataTable import = functions.xlGridImport();
      //import.Columns.Add("id", typeof(Int64)).SetOrdinal(0);
      locations.Tables[0].Merge(import);
      functions.updateData(locations.Tables[0], locationQuery);
    }

    private void lnExportLoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      functions.xlGridExport(locations.Tables[0]);
    }
  }
}
