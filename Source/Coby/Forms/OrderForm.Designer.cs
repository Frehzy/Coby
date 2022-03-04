namespace Coby.Forms
{
    partial class OrderForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.SaveButton = new MaterialSkin.Controls.MaterialButton();
            this.PayButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SumTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.OrderInfoListView = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DownButton = new MaterialSkin.Controls.MaterialButton();
            this.UpButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CreateGuestButton = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoListView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SaveButton);
            this.panel2.Controls.Add(this.PayButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 45);
            this.panel2.TabIndex = 2;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.SaveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.SaveButton.Depth = 0;
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.SaveButton.HighEmphasis = true;
            this.SaveButton.Icon = null;
            this.SaveButton.Location = new System.Drawing.Point(666, 0);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.SaveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.SaveButton.Size = new System.Drawing.Size(64, 45);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.SaveButton.UseAccentColor = false;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // PayButton
            // 
            this.PayButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PayButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PayButton.Depth = 0;
            this.PayButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.PayButton.HighEmphasis = true;
            this.PayButton.Icon = null;
            this.PayButton.Location = new System.Drawing.Point(730, 0);
            this.PayButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PayButton.Name = "PayButton";
            this.PayButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PayButton.Size = new System.Drawing.Size(64, 45);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Pay";
            this.PayButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PayButton.UseAccentColor = false;
            this.PayButton.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 69);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 333);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SumTextBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.OrderInfoListView, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 327);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // SumTextBox
            // 
            this.SumTextBox.AnimateReadOnly = false;
            this.SumTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SumTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SumTextBox.Depth = 0;
            this.SumTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SumTextBox.HideSelection = true;
            this.SumTextBox.LeadingIcon = null;
            this.SumTextBox.Location = new System.Drawing.Point(3, 280);
            this.SumTextBox.MaxLength = 32767;
            this.SumTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.PasswordChar = '\0';
            this.SumTextBox.PrefixSuffixText = null;
            this.SumTextBox.ReadOnly = false;
            this.SumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumTextBox.SelectedText = "";
            this.SumTextBox.SelectionLength = 0;
            this.SumTextBox.SelectionStart = 0;
            this.SumTextBox.ShortcutsEnabled = true;
            this.SumTextBox.Size = new System.Drawing.Size(305, 48);
            this.SumTextBox.TabIndex = 0;
            this.SumTextBox.TabStop = false;
            this.SumTextBox.Text = "Sum";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTextBox.TrailingIcon = null;
            this.SumTextBox.UseSystemPasswordChar = false;
            // 
            // OrderInfoListView
            // 
            this.OrderInfoListView.AllowUserToAddRows = false;
            this.OrderInfoListView.AllowUserToDeleteRows = false;
            this.OrderInfoListView.AllowUserToResizeColumns = false;
            this.OrderInfoListView.AllowUserToResizeRows = false;
            this.OrderInfoListView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderInfoListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfoListView.Location = new System.Drawing.Point(3, 3);
            this.OrderInfoListView.Name = "OrderInfoListView";
            this.OrderInfoListView.ReadOnly = true;
            this.OrderInfoListView.RowHeadersVisible = false;
            this.OrderInfoListView.RowHeadersWidth = 51;
            this.OrderInfoListView.RowTemplate.Height = 24;
            this.OrderInfoListView.Size = new System.Drawing.Size(305, 271);
            this.OrderInfoListView.TabIndex = 1;
            this.OrderInfoListView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderInfoListView_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ProductLayoutPanel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(320, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(471, 327);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DownButton);
            this.panel3.Controls.Add(this.UpButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 280);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 44);
            this.panel3.TabIndex = 0;
            // 
            // DownButton
            // 
            this.DownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DownButton.Depth = 0;
            this.DownButton.HighEmphasis = true;
            this.DownButton.Icon = null;
            this.DownButton.Location = new System.Drawing.Point(160, 2);
            this.DownButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DownButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownButton.Name = "DownButton";
            this.DownButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DownButton.Size = new System.Drawing.Size(64, 36);
            this.DownButton.TabIndex = 5;
            this.DownButton.Text = "↓";
            this.DownButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DownButton.UseAccentColor = false;
            this.DownButton.UseVisualStyleBackColor = true;
            this.DownButton.Click += new System.EventHandler(this.DownButton_Click);
            // 
            // UpButton
            // 
            this.UpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpButton.Depth = 0;
            this.UpButton.HighEmphasis = true;
            this.UpButton.Icon = null;
            this.UpButton.Location = new System.Drawing.Point(232, 2);
            this.UpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpButton.Name = "UpButton";
            this.UpButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpButton.Size = new System.Drawing.Size(64, 36);
            this.UpButton.TabIndex = 4;
            this.UpButton.Text = "↑";
            this.UpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpButton.UseAccentColor = false;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // ProductLayoutPanel
            // 
            this.ProductLayoutPanel.ColumnCount = 3;
            this.ProductLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.ProductLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ProductLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.ProductLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ProductLayoutPanel.Name = "ProductLayoutPanel";
            this.ProductLayoutPanel.RowCount = 10;
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ProductLayoutPanel.Size = new System.Drawing.Size(465, 271);
            this.ProductLayoutPanel.TabIndex = 1;
            // 
            // CreateGuestButton
            // 
            this.CreateGuestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateGuestButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateGuestButton.Depth = 0;
            this.CreateGuestButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreateGuestButton.HighEmphasis = true;
            this.CreateGuestButton.Icon = null;
            this.CreateGuestButton.Location = new System.Drawing.Point(0, 0);
            this.CreateGuestButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateGuestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateGuestButton.Name = "CreateGuestButton";
            this.CreateGuestButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateGuestButton.Size = new System.Drawing.Size(125, 45);
            this.CreateGuestButton.TabIndex = 2;
            this.CreateGuestButton.Text = "Create Guest";
            this.CreateGuestButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateGuestButton.UseAccentColor = false;
            this.CreateGuestButton.UseVisualStyleBackColor = true;
            this.CreateGuestButton.Click += new System.EventHandler(this.CreateGuestButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateGuestButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 45);
            this.panel1.TabIndex = 1;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoListView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton SaveButton;
        private MaterialSkin.Controls.MaterialButton PayButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton CreateGuestButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton DownButton;
        private MaterialSkin.Controls.MaterialButton UpButton;
        private System.Windows.Forms.TableLayoutPanel ProductLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialTextBox2 SumTextBox;
        private System.Windows.Forms.DataGridView OrderInfoListView;
    }
}