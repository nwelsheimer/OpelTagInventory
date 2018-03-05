namespace OpelTagInventory
{
  partial class frmSetup
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbItems = new System.Windows.Forms.TabPage();
      this.grdItems = new Infragistics.Win.UltraWinGrid.UltraGrid();
      this.tbSizes = new System.Windows.Forms.TabPage();
      this.tbLocation = new System.Windows.Forms.TabPage();
      this.tbSettings = new System.Windows.Forms.TabPage();
      this.btnInit = new System.Windows.Forms.Button();
      this.btnSave = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtDBName = new System.Windows.Forms.TextBox();
      this.tabControl1.SuspendLayout();
      this.tbItems.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
      this.tbSettings.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.tabControl1.Controls.Add(this.tbItems);
      this.tabControl1.Controls.Add(this.tbSizes);
      this.tabControl1.Controls.Add(this.tbLocation);
      this.tabControl1.Controls.Add(this.tbSettings);
      this.tabControl1.Location = new System.Drawing.Point(12, 39);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(851, 587);
      this.tabControl1.TabIndex = 0;
      // 
      // tbItems
      // 
      this.tbItems.Controls.Add(this.grdItems);
      this.tbItems.Location = new System.Drawing.Point(4, 29);
      this.tbItems.Name = "tbItems";
      this.tbItems.Padding = new System.Windows.Forms.Padding(3);
      this.tbItems.Size = new System.Drawing.Size(843, 554);
      this.tbItems.TabIndex = 0;
      this.tbItems.Text = "Items";
      this.tbItems.UseVisualStyleBackColor = true;
      // 
      // grdItems
      // 
      appearance1.BackColor = System.Drawing.SystemColors.Window;
      appearance1.BorderColor = System.Drawing.SystemColors.InactiveCaption;
      this.grdItems.DisplayLayout.Appearance = appearance1;
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
      this.grdItems.Location = new System.Drawing.Point(3, 3);
      this.grdItems.Name = "grdItems";
      this.grdItems.Size = new System.Drawing.Size(837, 548);
      this.grdItems.TabIndex = 0;
      this.grdItems.Text = "ultraGrid1";
      this.grdItems.AfterRowInsert += new Infragistics.Win.UltraWinGrid.RowEventHandler(this.grdItems_AfterRowInsert);
      // 
      // tbSizes
      // 
      this.tbSizes.Location = new System.Drawing.Point(4, 29);
      this.tbSizes.Name = "tbSizes";
      this.tbSizes.Padding = new System.Windows.Forms.Padding(3);
      this.tbSizes.Size = new System.Drawing.Size(843, 554);
      this.tbSizes.TabIndex = 1;
      this.tbSizes.Text = "Size/Type";
      this.tbSizes.UseVisualStyleBackColor = true;
      // 
      // tbLocation
      // 
      this.tbLocation.Location = new System.Drawing.Point(4, 29);
      this.tbLocation.Name = "tbLocation";
      this.tbLocation.Size = new System.Drawing.Size(843, 554);
      this.tbLocation.TabIndex = 2;
      this.tbLocation.Text = "Locations";
      this.tbLocation.UseVisualStyleBackColor = true;
      // 
      // tbSettings
      // 
      this.tbSettings.Controls.Add(this.btnInit);
      this.tbSettings.Controls.Add(this.btnSave);
      this.tbSettings.Controls.Add(this.label3);
      this.tbSettings.Controls.Add(this.label2);
      this.tbSettings.Controls.Add(this.label1);
      this.tbSettings.Controls.Add(this.txtDBName);
      this.tbSettings.Location = new System.Drawing.Point(4, 29);
      this.tbSettings.Name = "tbSettings";
      this.tbSettings.Size = new System.Drawing.Size(843, 554);
      this.tbSettings.TabIndex = 3;
      this.tbSettings.Text = "System Settings";
      this.tbSettings.UseVisualStyleBackColor = true;
      // 
      // btnInit
      // 
      this.btnInit.Location = new System.Drawing.Point(10, 306);
      this.btnInit.Name = "btnInit";
      this.btnInit.Size = new System.Drawing.Size(105, 53);
      this.btnInit.TabIndex = 5;
      this.btnInit.Text = "Initialize DB";
      this.btnInit.UseVisualStyleBackColor = true;
      this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(218, 306);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(105, 53);
      this.btnSave.TabIndex = 4;
      this.btnSave.Text = "Save Settings";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 123);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(129, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Database Name:";
      // 
      // label2
      // 
      this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.Red;
      this.label2.Location = new System.Drawing.Point(3, 52);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(837, 30);
      this.label2.TabIndex = 2;
      this.label2.Text = "WARNING: MODIFYING THESE SETTINGS INCORRECTLY COULD POTENTIALLY CAUSE DATA LOSS!";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(3, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(837, 48);
      this.label1.TabIndex = 1;
      this.label1.Text = "System Settings";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtDBName
      // 
      this.txtDBName.Location = new System.Drawing.Point(139, 120);
      this.txtDBName.Name = "txtDBName";
      this.txtDBName.Size = new System.Drawing.Size(184, 26);
      this.txtDBName.TabIndex = 0;
      // 
      // frmSetup
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(875, 638);
      this.Controls.Add(this.tabControl1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmSetup";
      this.Text = "System Setup";
      this.Load += new System.EventHandler(this.frmSetup_Load);
      this.tabControl1.ResumeLayout(false);
      this.tbItems.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
      this.tbSettings.ResumeLayout(false);
      this.tbSettings.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tbItems;
    private System.Windows.Forms.TabPage tbSizes;
    private System.Windows.Forms.TabPage tbLocation;
    private System.Windows.Forms.TabPage tbSettings;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtDBName;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnInit;
    private Infragistics.Win.UltraWinGrid.UltraGrid grdItems;
  }
}