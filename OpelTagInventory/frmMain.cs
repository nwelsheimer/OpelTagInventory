using Infragistics.Win;
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
  public partial class frmMain : Form
  {
    DataSet inventory;

    DataTable items;
    DataTable sizes;
    DataTable locs;

    string inventoryQuery = "select * from inventory";

    public frmMain()
    {
      InitializeComponent();

      //Creates any tables that don't already exist
      functions.createDB();
      loadGrid();
    }

    private void loadBindingTables()
    {
      items = functions.getData("select id, (mother || \" \" || baby) as itemName from item").Tables[0];
      sizes = functions.getData("select id, Type from size").Tables[0];
      locs = functions.getData("select id, locationName from locations").Tables[0];
    }

    private void loadGrid()
    {
      loadBindingTables();

      inventory = functions.getData(inventoryQuery);
      grdItems.DataSource = inventory.Tables[0];

      buildGrid();
    }

    private void buildGrid()
    {
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].ValueList = new BindableValueList(items,"","itemName","id",this.grdItems);

      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].ValueList = new BindableValueList(sizes, "", "Type", "id", this.grdItems);

      grdItems.DisplayLayout.Bands[0].Columns["locId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownList;
      grdItems.DisplayLayout.Bands[0].Columns["locId"].ValueList = new BindableValueList(locs, "", "locationName", "id", this.grdItems);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void setupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmSetup f = new frmSetup();
      f.ShowDialog();
      loadGrid();
    }
  }
}
