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
    DataSet items;
    string itemQuery = "select itemDescription, itemDescription2 from item";

    public frmSetup()
    {
      InitializeComponent();
    }

    private void frmSetup_Load(object sender, EventArgs e)
    {
      txtDBName.Text = Properties.Settings.Default.DBName;

      items = functions.getData(itemQuery);
      grdItems.DataSource = items.Tables[0];
    }

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
      functions.createDB();
      MessageBox.Show("Database successfully created.");
    }

    private void grdItems_AfterRowInsert(object sender, Infragistics.Win.UltraWinGrid.RowEventArgs e)
    {
      functions.updateData(items.Tables[0], itemQuery);
    }
  }
}
