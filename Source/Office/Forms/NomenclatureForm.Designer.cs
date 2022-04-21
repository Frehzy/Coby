namespace Office.Forms
{
    partial class NomenclatureForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NomenclatureForm));
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.CreateProductButton = new MaterialSkin.Controls.MaterialButton();
            this.RemoveNomenclatureButton = new MaterialSkin.Controls.MaterialButton();
            this.AddNomenclatureButton = new MaterialSkin.Controls.MaterialButton();
            this.NomenclatureUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.NomenclatureDgv = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChildInfoTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.ParentInfoTextBox = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.NomenclatureExcelButton = new MaterialSkin.Controls.MaterialButton();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomenclatureDgv)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.CreateProductButton);
            this.ButtonsPanel.Controls.Add(this.RemoveNomenclatureButton);
            this.ButtonsPanel.Controls.Add(this.AddNomenclatureButton);
            this.ButtonsPanel.Controls.Add(this.NomenclatureUpdateButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 193);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(916, 54);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // CreateProductButton
            // 
            this.CreateProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreateProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateProductButton.Depth = 0;
            this.CreateProductButton.HighEmphasis = true;
            this.CreateProductButton.Icon = null;
            this.CreateProductButton.Location = new System.Drawing.Point(683, 9);
            this.CreateProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateProductButton.Name = "CreateProductButton";
            this.CreateProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateProductButton.Size = new System.Drawing.Size(76, 36);
            this.CreateProductButton.TabIndex = 18;
            this.CreateProductButton.Text = "Create";
            this.CreateProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateProductButton.UseAccentColor = false;
            this.CreateProductButton.UseVisualStyleBackColor = true;
            this.CreateProductButton.Click += new System.EventHandler(this.CreateProductButton_Click);
            // 
            // RemoveNomenclatureButton
            // 
            this.RemoveNomenclatureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveNomenclatureButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveNomenclatureButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemoveNomenclatureButton.Depth = 0;
            this.RemoveNomenclatureButton.HighEmphasis = true;
            this.RemoveNomenclatureButton.Icon = null;
            this.RemoveNomenclatureButton.Location = new System.Drawing.Point(839, 9);
            this.RemoveNomenclatureButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveNomenclatureButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveNomenclatureButton.Name = "RemoveNomenclatureButton";
            this.RemoveNomenclatureButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemoveNomenclatureButton.Size = new System.Drawing.Size(73, 36);
            this.RemoveNomenclatureButton.TabIndex = 17;
            this.RemoveNomenclatureButton.Text = "Delete";
            this.RemoveNomenclatureButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveNomenclatureButton.UseAccentColor = false;
            this.RemoveNomenclatureButton.UseVisualStyleBackColor = true;
            this.RemoveNomenclatureButton.Click += new System.EventHandler(this.RemoveNomenclatureButton_Click);
            // 
            // AddNomenclatureButton
            // 
            this.AddNomenclatureButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddNomenclatureButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddNomenclatureButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddNomenclatureButton.Depth = 0;
            this.AddNomenclatureButton.HighEmphasis = true;
            this.AddNomenclatureButton.Icon = null;
            this.AddNomenclatureButton.Location = new System.Drawing.Point(767, 9);
            this.AddNomenclatureButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddNomenclatureButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddNomenclatureButton.Name = "AddNomenclatureButton";
            this.AddNomenclatureButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddNomenclatureButton.Size = new System.Drawing.Size(64, 36);
            this.AddNomenclatureButton.TabIndex = 16;
            this.AddNomenclatureButton.Text = "Add";
            this.AddNomenclatureButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddNomenclatureButton.UseAccentColor = false;
            this.AddNomenclatureButton.UseVisualStyleBackColor = true;
            this.AddNomenclatureButton.Click += new System.EventHandler(this.AddNomenclatureButton_Click);
            // 
            // NomenclatureUpdateButton
            // 
            this.NomenclatureUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NomenclatureUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.NomenclatureUpdateButton.Depth = 0;
            this.NomenclatureUpdateButton.HighEmphasis = true;
            this.NomenclatureUpdateButton.Icon = null;
            this.NomenclatureUpdateButton.Location = new System.Drawing.Point(4, 9);
            this.NomenclatureUpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NomenclatureUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NomenclatureUpdateButton.Name = "NomenclatureUpdateButton";
            this.NomenclatureUpdateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.NomenclatureUpdateButton.Size = new System.Drawing.Size(197, 36);
            this.NomenclatureUpdateButton.TabIndex = 15;
            this.NomenclatureUpdateButton.Text = "Nomenclature update";
            this.NomenclatureUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NomenclatureUpdateButton.UseAccentColor = false;
            this.NomenclatureUpdateButton.UseVisualStyleBackColor = true;
            this.NomenclatureUpdateButton.Click += new System.EventHandler(this.NomenclatureUpdateButton_Click);
            // 
            // NomenclatureDgv
            // 
            this.NomenclatureDgv.AllowUserToAddRows = false;
            this.NomenclatureDgv.AllowUserToDeleteRows = false;
            this.NomenclatureDgv.AllowUserToResizeRows = false;
            this.NomenclatureDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NomenclatureDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.NomenclatureDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NomenclatureDgv.Location = new System.Drawing.Point(3, 247);
            this.NomenclatureDgv.Name = "NomenclatureDgv";
            this.NomenclatureDgv.ReadOnly = true;
            this.NomenclatureDgv.RowHeadersWidth = 51;
            this.NomenclatureDgv.RowTemplate.Height = 24;
            this.NomenclatureDgv.Size = new System.Drawing.Size(916, 286);
            this.NomenclatureDgv.TabIndex = 16;
            this.NomenclatureDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NomenclatureDgv_CellContentClick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChildInfoTextBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ParentInfoTextBox, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 129);
            this.tableLayoutPanel1.TabIndex = 17;
            // 
            // ChildInfoTextBox
            // 
            this.ChildInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChildInfoTextBox.AnimateReadOnly = true;
            this.ChildInfoTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChildInfoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ChildInfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ChildInfoTextBox.Depth = 0;
            this.ChildInfoTextBox.HideSelection = true;
            this.ChildInfoTextBox.Location = new System.Drawing.Point(461, 3);
            this.ChildInfoTextBox.MaxLength = 32767;
            this.ChildInfoTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ChildInfoTextBox.Name = "ChildInfoTextBox";
            this.ChildInfoTextBox.PasswordChar = '\0';
            this.ChildInfoTextBox.ReadOnly = true;
            this.ChildInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChildInfoTextBox.SelectedText = "";
            this.ChildInfoTextBox.SelectionLength = 0;
            this.ChildInfoTextBox.SelectionStart = 0;
            this.ChildInfoTextBox.ShortcutsEnabled = true;
            this.ChildInfoTextBox.Size = new System.Drawing.Size(452, 123);
            this.ChildInfoTextBox.TabIndex = 19;
            this.ChildInfoTextBox.TabStop = false;
            this.ChildInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ChildInfoTextBox.UseAccent = false;
            this.ChildInfoTextBox.UseSystemPasswordChar = false;
            // 
            // ParentInfoTextBox
            // 
            this.ParentInfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentInfoTextBox.AnimateReadOnly = true;
            this.ParentInfoTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ParentInfoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ParentInfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ParentInfoTextBox.Depth = 0;
            this.ParentInfoTextBox.HideSelection = true;
            this.ParentInfoTextBox.Location = new System.Drawing.Point(3, 3);
            this.ParentInfoTextBox.MaxLength = 32767;
            this.ParentInfoTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ParentInfoTextBox.Name = "ParentInfoTextBox";
            this.ParentInfoTextBox.PasswordChar = '\0';
            this.ParentInfoTextBox.ReadOnly = true;
            this.ParentInfoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ParentInfoTextBox.SelectedText = "";
            this.ParentInfoTextBox.SelectionLength = 0;
            this.ParentInfoTextBox.SelectionStart = 0;
            this.ParentInfoTextBox.ShortcutsEnabled = true;
            this.ParentInfoTextBox.Size = new System.Drawing.Size(452, 123);
            this.ParentInfoTextBox.TabIndex = 18;
            this.ParentInfoTextBox.TabStop = false;
            this.ParentInfoTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ParentInfoTextBox.UseAccent = false;
            this.ParentInfoTextBox.UseSystemPasswordChar = false;
            // 
            // NomenclatureExcelButton
            // 
            this.NomenclatureExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.NomenclatureExcelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NomenclatureExcelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.NomenclatureExcelButton.Depth = 0;
            this.NomenclatureExcelButton.HighEmphasis = true;
            this.NomenclatureExcelButton.Icon = null;
            this.NomenclatureExcelButton.Location = new System.Drawing.Point(854, 542);
            this.NomenclatureExcelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.NomenclatureExcelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.NomenclatureExcelButton.Name = "NomenclatureExcelButton";
            this.NomenclatureExcelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.NomenclatureExcelButton.Size = new System.Drawing.Size(65, 36);
            this.NomenclatureExcelButton.TabIndex = 18;
            this.NomenclatureExcelButton.Text = "Excel";
            this.NomenclatureExcelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.NomenclatureExcelButton.UseAccentColor = false;
            this.NomenclatureExcelButton.UseVisualStyleBackColor = true;
            this.NomenclatureExcelButton.Click += new System.EventHandler(this.NomenclatureExcelButton_Click);
            // 
            // NomenclatureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.NomenclatureExcelButton);
            this.Controls.Add(this.NomenclatureDgv);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "NomenclatureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomenclature";
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NomenclatureDgv)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.DataGridView NomenclatureDgv;
        private MaterialSkin.Controls.MaterialButton RemoveNomenclatureButton;
        private MaterialSkin.Controls.MaterialButton AddNomenclatureButton;
        private MaterialSkin.Controls.MaterialButton NomenclatureUpdateButton;
        private MaterialSkin.Controls.MaterialButton CreateProductButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ChildInfoTextBox;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 ParentInfoTextBox;
        private MaterialSkin.Controls.MaterialButton NomenclatureExcelButton;
    }
}