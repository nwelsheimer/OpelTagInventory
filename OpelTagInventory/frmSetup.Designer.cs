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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSetup));
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tbItems = new System.Windows.Forms.TabPage();
      this.tbSizes = new System.Windows.Forms.TabPage();
      this.tbLocation = new System.Windows.Forms.TabPage();
      this.tbSettings = new System.Windows.Forms.TabPage();
      this.txtDBName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnInit = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
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
      this.tbItems.Location = new System.Drawing.Point(4, 29);
      this.tbItems.Name = "tbItems";
      this.tbItems.Padding = new System.Windows.Forms.Padding(3);
      this.tbItems.Size = new System.Drawing.Size(843, 554);
      this.tbItems.TabIndex = 0;
      this.tbItems.Text = "Items";
      this.tbItems.UseVisualStyleBackColor = true;
      // 
      // tbSizes
      // 
      this.tbSizes.Location = new System.Drawing.Point(4, 29);
      this.tbSizes.Name = "tbSizes";
      this.tbSizes.Padding = new System.Windows.Forms.Padding(3);
      this.tbSizes.Size = new System.Drawing.Size(1221, 935);
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
      // txtDBName
      // 
      this.txtDBName.Location = new System.Drawing.Point(139, 120);
      this.txtDBName.Name = "txtDBName";
      this.txtDBName.Size = new System.Drawing.Size(184, 26);
      this.txtDBName.TabIndex = 0;
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
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 123);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(129, 20);
      this.label3.TabIndex = 3;
      this.label3.Text = "Database Name:";
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
  }
}