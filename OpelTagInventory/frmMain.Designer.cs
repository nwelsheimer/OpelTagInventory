namespace OpelTagInventory
{
  partial class frmMain
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
      Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.grdItems = new Infragistics.Win.UltraWinGrid.UltraGrid();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txtSearchItems = new System.Windows.Forms.TextBox();
      this.txtSearchBins = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
      this.menuStrip1.Size = new System.Drawing.Size(684, 24);
      this.menuStrip1.TabIndex = 0;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportsToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // reportsToolStripMenuItem
      // 
      this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
      this.reportsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.reportsToolStripMenuItem.Text = "Reports";
      // 
      // setupToolStripMenuItem
      // 
      this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
      this.setupToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.setupToolStripMenuItem.Text = "Setup";
      this.setupToolStripMenuItem.Click += new System.EventHandler(this.setupToolStripMenuItem_Click);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.exitToolStripMenuItem.Text = "Exit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // grdItems
      // 
      appearance1.BackColor = System.Drawing.SystemColors.Window;
      appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
      this.grdItems.DisplayLayout.Appearance = appearance1;
      this.grdItems.DisplayLayout.AutoFitStyle = Infragistics.Win.UltraWinGrid.AutoFitStyle.ResizeAllColumns;
      this.grdItems.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      this.grdItems.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
      appearance2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      appearance2.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance2.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
      appearance2.BorderColor = System.Drawing.SystemColors.Window;
      this.grdItems.DisplayLayout.GroupByBox.Appearance = appearance2;
      appearance3.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdItems.DisplayLayout.GroupByBox.BandLabelAppearance = appearance3;
      this.grdItems.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
      appearance4.BackColor = System.Drawing.SystemColors.ControlLightLight;
      appearance4.BackColor2 = System.Drawing.SystemColors.Control;
      appearance4.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance4.ForeColor = System.Drawing.SystemColors.GrayText;
      this.grdItems.DisplayLayout.GroupByBox.PromptAppearance = appearance4;
      this.grdItems.DisplayLayout.MaxColScrollRegions = 1;
      this.grdItems.DisplayLayout.MaxRowScrollRegions = 1;
      appearance5.BackColor = System.Drawing.SystemColors.Window;
      appearance5.ForeColor = System.Drawing.SystemColors.ControlText;
      this.grdItems.DisplayLayout.Override.ActiveCellAppearance = appearance5;
      appearance6.BackColor = System.Drawing.SystemColors.Highlight;
      appearance6.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.grdItems.DisplayLayout.Override.ActiveRowAppearance = appearance6;
      this.grdItems.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.TemplateOnTopWithTabRepeat;
      this.grdItems.DisplayLayout.Override.AllowDelete = Infragistics.Win.DefaultableBoolean.True;
      this.grdItems.DisplayLayout.Override.AllowRowFiltering = Infragistics.Win.DefaultableBoolean.True;
      this.grdItems.DisplayLayout.Override.AllowUpdate = Infragistics.Win.DefaultableBoolean.True;
      this.grdItems.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
      this.grdItems.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
      appearance7.BackColor = System.Drawing.SystemColors.Window;
      this.grdItems.DisplayLayout.Override.CardAreaAppearance = appearance7;
      appearance8.BorderColor = System.Drawing.Color.Silver;
      appearance8.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
      this.grdItems.DisplayLayout.Override.CellAppearance = appearance8;
      this.grdItems.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.EditAndSelectText;
      this.grdItems.DisplayLayout.Override.CellPadding = 0;
      this.grdItems.DisplayLayout.Override.FilterClearButtonLocation = Infragistics.Win.UltraWinGrid.FilterClearButtonLocation.Cell;
      this.grdItems.DisplayLayout.Override.FilterEvaluationTrigger = Infragistics.Win.UltraWinGrid.FilterEvaluationTrigger.OnCellValueChange;
      this.grdItems.DisplayLayout.Override.FilterOperatorDefaultValue = Infragistics.Win.UltraWinGrid.FilterOperatorDefaultValue.Contains;
      this.grdItems.DisplayLayout.Override.FilterUIType = Infragistics.Win.UltraWinGrid.FilterUIType.FilterRow;
      appearance9.BackColor = System.Drawing.SystemColors.Control;
      appearance9.BackColor2 = System.Drawing.SystemColors.ControlDark;
      appearance9.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
      appearance9.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
      appearance9.BorderColor = System.Drawing.SystemColors.Window;
      this.grdItems.DisplayLayout.Override.GroupByRowAppearance = appearance9;
      appearance10.TextHAlignAsString = "Left";
      this.grdItems.DisplayLayout.Override.HeaderAppearance = appearance10;
      this.grdItems.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
      this.grdItems.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
      appearance11.BackColor = System.Drawing.SystemColors.Window;
      appearance11.BorderColor = System.Drawing.Color.Silver;
      this.grdItems.DisplayLayout.Override.RowAppearance = appearance11;
      this.grdItems.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
      appearance12.BackColor = System.Drawing.SystemColors.ControlLight;
      this.grdItems.DisplayLayout.Override.TemplateAddRowAppearance = appearance12;
      this.grdItems.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
      this.grdItems.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
      this.grdItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grdItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.grdItems.Location = new System.Drawing.Point(0, 96);
      this.grdItems.Margin = new System.Windows.Forms.Padding(2);
      this.grdItems.Name = "grdItems";
      this.grdItems.Size = new System.Drawing.Size(684, 425);
      this.grdItems.TabIndex = 1;
      this.grdItems.Text = "Items";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.txtSearchBins);
      this.panel1.Controls.Add(this.txtSearchItems);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 24);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(684, 72);
      this.panel1.TabIndex = 2;
      // 
      // txtSearchItems
      // 
      this.txtSearchItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSearchItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSearchItems.Location = new System.Drawing.Point(12, 23);
      this.txtSearchItems.Name = "txtSearchItems";
      this.txtSearchItems.Size = new System.Drawing.Size(482, 44);
      this.txtSearchItems.TabIndex = 0;
      // 
      // txtSearchBins
      // 
      this.txtSearchBins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSearchBins.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtSearchBins.Location = new System.Drawing.Point(500, 23);
      this.txtSearchBins.Name = "txtSearchBins";
      this.txtSearchBins.Size = new System.Drawing.Size(172, 44);
      this.txtSearchBins.TabIndex = 1;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(12, 3);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(102, 17);
      this.label4.TabIndex = 2;
      this.label4.Text = "Search Items";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(497, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(95, 17);
      this.label1.TabIndex = 3;
      this.label1.Text = "Search Bins";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(684, 521);
      this.Controls.Add(this.grdItems);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.menuStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "frmMain";
      this.Text = "Tag Inventory";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private Infragistics.Win.UltraWinGrid.UltraGrid grdItems;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txtSearchBins;
    private System.Windows.Forms.TextBox txtSearchItems;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
  }
}

