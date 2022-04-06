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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.PayButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.OrderInfoListView = new Coby.Forms.CustomControls.CustomDataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SumTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.DeleteButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DownButton = new MaterialSkin.Controls.MaterialButton();
            this.UpButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CreateGuestButton = new MaterialSkin.Controls.MaterialButton();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PayButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(794, 45);
            this.panel2.TabIndex = 2;
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
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 357);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.OrderInfoListView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 351);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // OrderInfoListView
            // 
            this.OrderInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfoListView.Location = new System.Drawing.Point(3, 3);
            this.OrderInfoListView.Name = "OrderInfoListView";
            this.OrderInfoListView.Size = new System.Drawing.Size(305, 295);
            this.OrderInfoListView.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SumTextBox);
            this.panel4.Controls.Add(this.DeleteButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 44);
            this.panel4.TabIndex = 2;
            // 
            // SumTextBox
            // 
            this.SumTextBox.AnimateReadOnly = true;
            this.SumTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SumTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SumTextBox.Depth = 0;
            this.SumTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.SumTextBox.HideSelection = true;
            this.SumTextBox.LeadingIcon = null;
            this.SumTextBox.Location = new System.Drawing.Point(0, 0);
            this.SumTextBox.MaxLength = 32767;
            this.SumTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.PasswordChar = '\0';
            this.SumTextBox.PrefixSuffixText = null;
            this.SumTextBox.ReadOnly = true;
            this.SumTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumTextBox.SelectedText = "";
            this.SumTextBox.SelectionLength = 0;
            this.SumTextBox.SelectionStart = 0;
            this.SumTextBox.ShortcutsEnabled = true;
            this.SumTextBox.Size = new System.Drawing.Size(241, 48);
            this.SumTextBox.TabIndex = 1;
            this.SumTextBox.TabStop = false;
            this.SumTextBox.Text = "Sum";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTextBox.TrailingIcon = null;
            this.SumTextBox.UseAccent = false;
            this.SumTextBox.UseSystemPasswordChar = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteButton.HighEmphasis = true;
            this.DeleteButton.Icon = null;
            this.DeleteButton.Location = new System.Drawing.Point(241, 0);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteButton.Size = new System.Drawing.Size(64, 44);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "X";
            this.DeleteButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteButton.UseAccentColor = false;
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
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
            this.tableLayoutPanel3.Size = new System.Drawing.Size(471, 351);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DownButton);
            this.panel3.Controls.Add(this.UpButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 47);
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
            this.DownButton.Location = new System.Drawing.Point(160, 3);
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
            this.UpButton.Location = new System.Drawing.Point(232, 3);
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
            this.ProductLayoutPanel.Size = new System.Drawing.Size(465, 292);
            this.ProductLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CreateGuestButton);
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 45);
            this.panel1.TabIndex = 1;
            // 
            // CreateGuestButton
            // 
            this.CreateGuestButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CreateGuestButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CreateGuestButton.Depth = 0;
            this.CreateGuestButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CreateGuestButton.HighEmphasis = true;
            this.CreateGuestButton.Icon = null;
            this.CreateGuestButton.Location = new System.Drawing.Point(64, 0);
            this.CreateGuestButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CreateGuestButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CreateGuestButton.Name = "CreateGuestButton";
            this.CreateGuestButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CreateGuestButton.Size = new System.Drawing.Size(125, 45);
            this.CreateGuestButton.TabIndex = 5;
            this.CreateGuestButton.Text = "Create Guest";
            this.CreateGuestButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CreateGuestButton.UseAccentColor = false;
            this.CreateGuestButton.UseVisualStyleBackColor = true;
            this.CreateGuestButton.Click += new System.EventHandler(this.CreateGuestButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.BackButton.Depth = 0;
            this.BackButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.BackButton.HighEmphasis = true;
            this.BackButton.Icon = null;
            this.BackButton.Location = new System.Drawing.Point(0, 0);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BackButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.BackButton.Name = "BackButton";
            this.BackButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.BackButton.Size = new System.Drawing.Size(64, 45);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "<-";
            this.BackButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BackButton.UseAccentColor = false;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialButton PayButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton DownButton;
        private MaterialSkin.Controls.MaterialButton UpButton;
        private System.Windows.Forms.TableLayoutPanel ProductLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.CustomDataGridView OrderInfoListView;
        private MaterialSkin.Controls.MaterialButton CreateGuestButton;
        private MaterialSkin.Controls.MaterialButton BackButton;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox2 SumTextBox;
        private MaterialSkin.Controls.MaterialButton DeleteButton;
    }
}