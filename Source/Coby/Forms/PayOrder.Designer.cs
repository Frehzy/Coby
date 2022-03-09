namespace Coby.Forms
{
    partial class PayOrder
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
            this.PayButton = new MaterialSkin.Controls.MaterialButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.RemainderTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.PaymentLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SumTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.OrderInfoListView = new Coby.Forms.CustomControls.CustomDataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DownButton = new MaterialSkin.Controls.MaterialButton();
            this.UpButton = new MaterialSkin.Controls.MaterialButton();
            this.PaymentTypeLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.PayButton.Location = new System.Drawing.Point(677, 0);
            this.PayButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PayButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PayButton.Name = "PayButton";
            this.PayButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PayButton.Size = new System.Drawing.Size(117, 45);
            this.PayButton.TabIndex = 2;
            this.PayButton.Text = "Close order";
            this.PayButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PayButton.UseAccentColor = false;
            this.PayButton.UseVisualStyleBackColor = true;
            this.PayButton.Click += new System.EventHandler(this.PayButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 45);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(794, 357);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.PaymentLayoutPanel, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(320, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 351);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.RemainderTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 304);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(226, 44);
            this.panel4.TabIndex = 0;
            // 
            // RemainderTextBox
            // 
            this.RemainderTextBox.AnimateReadOnly = true;
            this.RemainderTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemainderTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RemainderTextBox.Depth = 0;
            this.RemainderTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemainderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RemainderTextBox.HideSelection = true;
            this.RemainderTextBox.LeadingIcon = null;
            this.RemainderTextBox.Location = new System.Drawing.Point(0, 0);
            this.RemainderTextBox.MaxLength = 32767;
            this.RemainderTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.RemainderTextBox.Name = "RemainderTextBox";
            this.RemainderTextBox.PasswordChar = '\0';
            this.RemainderTextBox.PrefixSuffixText = null;
            this.RemainderTextBox.ReadOnly = true;
            this.RemainderTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemainderTextBox.SelectedText = "";
            this.RemainderTextBox.SelectionLength = 0;
            this.RemainderTextBox.SelectionStart = 0;
            this.RemainderTextBox.ShortcutsEnabled = true;
            this.RemainderTextBox.Size = new System.Drawing.Size(226, 48);
            this.RemainderTextBox.TabIndex = 3;
            this.RemainderTextBox.TabStop = false;
            this.RemainderTextBox.Text = "Remainder";
            this.RemainderTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RemainderTextBox.TrailingIcon = null;
            this.RemainderTextBox.UseAccent = false;
            this.RemainderTextBox.UseSystemPasswordChar = false;
            // 
            // PaymentLayoutPanel
            // 
            this.PaymentLayoutPanel.ColumnCount = 1;
            this.PaymentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PaymentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PaymentLayoutPanel.Name = "PaymentLayoutPanel";
            this.PaymentLayoutPanel.RowCount = 5;
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentLayoutPanel.Size = new System.Drawing.Size(226, 295);
            this.PaymentLayoutPanel.TabIndex = 1;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(311, 351);
            this.tableLayoutPanel2.TabIndex = 0;
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
            this.SumTextBox.Location = new System.Drawing.Point(3, 304);
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
            this.SumTextBox.Size = new System.Drawing.Size(305, 48);
            this.SumTextBox.TabIndex = 2;
            this.SumTextBox.TabStop = false;
            this.SumTextBox.Text = "Sum";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTextBox.TrailingIcon = null;
            this.SumTextBox.UseAccent = false;
            this.SumTextBox.UseSystemPasswordChar = false;
            // 
            // OrderInfoListView
            // 
            this.OrderInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfoListView.Location = new System.Drawing.Point(3, 3);
            this.OrderInfoListView.Name = "OrderInfoListView";
            this.OrderInfoListView.Size = new System.Drawing.Size(305, 295);
            this.OrderInfoListView.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.PaymentTypeLayoutPanel, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(558, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(233, 351);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.DownButton);
            this.panel3.Controls.Add(this.UpButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(227, 47);
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
            this.DownButton.Location = new System.Drawing.Point(41, 3);
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
            this.UpButton.Location = new System.Drawing.Point(113, 3);
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
            // PaymentTypeLayoutPanel
            // 
            this.PaymentTypeLayoutPanel.ColumnCount = 1;
            this.PaymentTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PaymentTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentTypeLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.PaymentTypeLayoutPanel.Name = "PaymentTypeLayoutPanel";
            this.PaymentTypeLayoutPanel.RowCount = 5;
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.PaymentTypeLayoutPanel.Size = new System.Drawing.Size(227, 292);
            this.PaymentTypeLayoutPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BackButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 45);
            this.panel1.TabIndex = 1;
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
            // PayOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PayOrder";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomControls.CustomDataGridView OrderInfoListView;
        private MaterialSkin.Controls.MaterialButton BackButton;
        private MaterialSkin.Controls.MaterialTextBox2 SumTextBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialButton DownButton;
        private MaterialSkin.Controls.MaterialButton UpButton;
        private System.Windows.Forms.TableLayoutPanel PaymentTypeLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox2 RemainderTextBox;
        private System.Windows.Forms.TableLayoutPanel PaymentLayoutPanel;
    }
}