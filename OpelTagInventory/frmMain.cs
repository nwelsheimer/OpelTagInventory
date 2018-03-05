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
    public frmMain()
    {
      InitializeComponent();
      
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      functions.createDB();
    }

    private void setupToolStripMenuItem_Click(object sender, EventArgs e)
    {
      frmSetup f = new frmSetup();
      f.ShowDialog();
    }
  }
}
