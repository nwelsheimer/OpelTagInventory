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
using Infragistics.Win.UltraWinGrid;

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
      //combo boxes
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].ValueList = new BindableValueList(items,"","itemName","id",this.grdItems);
      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].ValueList = new BindableValueList(sizes, "", "Type", "id", this.grdItems);
      grdItems.DisplayLayout.Bands[0].Columns["locId"].Style = Infragistics.Win.UltraWinGrid.ColumnStyle.DropDownValidate;
      grdItems.DisplayLayout.Bands[0].Columns["locId"].AutoCompleteMode = Infragistics.Win.AutoCompleteMode.SuggestAppend;
      grdItems.DisplayLayout.Bands[0].Columns["locId"].ValueList = new BindableValueList(locs, "", "locationName", "id", this.grdItems);
      //id column is off limits
      grdItems.DisplayLayout.Bands[0].Columns["id"].Hidden = true;
      grdItems.DisplayLayout.Bands[0].Columns["id"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.Disabled;
      //Change header names
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].Header.Caption = "Item Description";
      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].Header.Caption = "Type Description";
      grdItems.DisplayLayout.Bands[0].Columns["locId"].Header.Caption = "Bin";
      grdItems.DisplayLayout.Bands[0].Columns["qtyOnHand"].Header.Caption = "Qty on Hand";
      //Disable editing on everything but qty column
      grdItems.DisplayLayout.Bands[0].Columns["itemId"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
      grdItems.DisplayLayout.Bands[0].Columns["sizeId"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
      grdItems.DisplayLayout.Bands[0].Columns["locId"].CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void setupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      string pin = Microsoft.VisualBasic.Interaction.InputBox("Please enter admin PIN to continue. 9548", "Secure Area", "");
      if (pin == "9548")
      {
        frmSetup f = new frmSetup();
        f.ShowDialog();
        loadGrid();
      } else
      {
        MessageBox.Show("Invalid PIN number. Please contact your supervisor for assitance with this area.");
      }
    }

    private void grdItems_AfterRowInsert(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
    {
      functions.updateData(inventory.Tables[0], inventoryQuery);
    }

    private void grdItems_AfterRowsDeleted(object sender, EventArgs e)
    {
      functions.updateData(inventory.Tables[0], inventoryQuery);
    }

    private void grdItems_InitializeTemplateAddRow(object sender, Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs e)
    {
        foreach (UltraGridCell c in e.TemplateAddRow.Cells)
      {
        c.IgnoreRowColActivation = true;
        c.Activation = Activation.AllowEdit;
      }
    }

    private void txtSearchItems_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (txtSearchItems.TextLength > 0)
      {
        string search = txtSearchItems.Text;
        inventory.Tables[0].DefaultView.RowFilter = "itemId='" + search + "'";
      }
    }
  }
}
