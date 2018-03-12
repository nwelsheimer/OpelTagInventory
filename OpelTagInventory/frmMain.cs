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
      buildGrid();
      addFilterColumn();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      grdItems.DrawFilter = new noIconFilter();
      txtSearchItems.Focus();
    }

    #region grid building
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
    }

    private void addFilterColumn()
    {
      grdItems.AfterRowUpdate -= new RowEventHandler(grdItems_AfterRowUpdate);
      foreach (UltraGridRow r in grdItems.Rows)
      {
        r.Cells["itemKey"].Value = r.Cells["itemId"].Text + " " + r.Cells["sizeId"].Text;
        r.Update();
      }
      grdItems.AfterRowUpdate += new RowEventHandler(grdItems_AfterRowUpdate);
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
      //Add filter column
      grdItems.DisplayLayout.Bands[0].Columns.Add("itemKey");
      grdItems.DisplayLayout.Bands[0].Columns["itemKey"].Hidden = true;
      grdItems.DisplayLayout.Bands[0].Columns["itemKey"].CellActivation = Activation.Disabled;
    }

    private void grdItems_InitializeTemplateAddRow(object sender, Infragistics.Win.UltraWinGrid.InitializeTemplateAddRowEventArgs e)
    {
      foreach (UltraGridCell c in e.TemplateAddRow.Cells)
      {
        c.IgnoreRowColActivation = true;
        c.Activation = Activation.AllowEdit;
      }
      
    }
    #endregion
    #region search box events
    private void txtSearchItems_TextChanged(object sender, EventArgs e)
    {
        string search = "*" + txtSearchItems.Text.Replace(' ','*') + "*";
        grdItems.DisplayLayout.Bands[0].ColumnFilters["itemKey"].FilterConditions.Clear();
        grdItems.DisplayLayout.Bands[0].ColumnFilters["itemKey"].FilterConditions.Add(FilterComparisionOperator.Like, search);
    }

    private void txtSearchBins_TextChanged(object sender, EventArgs e)
    {
      string search = "*" + txtSearchBins.Text.Replace(' ', '*') + "*";
      grdItems.DisplayLayout.Bands[0].ColumnFilters["locId"].FilterConditions.Clear();
      grdItems.DisplayLayout.Bands[0].ColumnFilters["locId"].FilterConditions.Add(FilterComparisionOperator.Like, search);
    }
    #endregion
    #region button pushing
    private void grdItems_KeyDown(object sender, KeyEventArgs e)
    {
      
      functions.GridNavigation(grdItems, e);
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void setupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (functions.promptForPin())
      {
        frmSetup f = new frmSetup();
        f.ShowDialog();
        loadGrid();
      }
      else
      {
        MessageBox.Show("Invalid PIN number. Please contact your supervisor for assitance with this area.");
      }
    }
    #endregion
    #region updates
    private void grdItems_AfterRowUpdate(object sender, RowEventArgs e)
    {
      functions.updateData(inventory.Tables[0], inventoryQuery);
      loadGrid();
      addFilterColumn();
    }

    private void grdItems_AfterRowsDeleted(object sender, EventArgs e)
    {
      functions.updateData(inventory.Tables[0], inventoryQuery);
    }
    #endregion

    private void grdItems_BeforeRowsDeleted(object sender, BeforeRowsDeletedEventArgs e)
    {
      if (!functions.promptForPin())
        e.Cancel = true;
    }

    private void grdItems_BeforeRowUpdate(object sender, CancelableRowEventArgs e)
    {
      if (e.Row.Cells["itemId"].Value.ToString().Length == 0 || e.Row.Cells["sizeId"].Value.ToString().Length == 0
        || e.Row.Cells["locId"].Value.ToString().Length == 0)
        e.Cancel = true;
    }
  }
  #region overrides
  public class noIconFilter : IUIElementDrawFilter
  {
    bool IUIElementDrawFilter.DrawElement(DrawPhase drawPhase, ref UIElementDrawParams drawParams)
    {
      return true;
    }

    DrawPhase IUIElementDrawFilter.GetPhasesToFilter(ref UIElementDrawParams drawParams)
    {
      if (drawParams.Element is FilterDropDownButtonUIElement)
      {
        return DrawPhase.BeforeDrawElement;
      }

      return DrawPhase.None;
    }
  }
  #endregion
}
