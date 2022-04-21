﻿namespace Office.Forms
{
    partial class ReportsForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.RevisionPage = new System.Windows.Forms.TabPage();
            this.UpdateRevisionButton = new MaterialSkin.Controls.MaterialButton();
            this.RevisionDgv = new System.Windows.Forms.DataGridView();
            this.DangerousOperationsPage = new System.Windows.Forms.TabPage();
            this.WaiterComboBoxClearButton = new MaterialSkin.Controls.MaterialButton();
            this.WaitersComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.UpdateDangerousOperationsButton = new MaterialSkin.Controls.MaterialButton();
            this.DangerousDgv = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.EndDateTimePicker = new Office.Forms.CustomControls.CustomDateTimePicker();
            this.StartDateTimePicker = new Office.Forms.CustomControls.CustomDateTimePicker();
            this.RevisionExcelButton = new MaterialSkin.Controls.MaterialButton();
            this.TabControl.SuspendLayout();
            this.RevisionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevisionDgv)).BeginInit();
            this.DangerousOperationsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DangerousDgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.RevisionPage);
            this.TabControl.Controls.Add(this.DangerousOperationsPage);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 104);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(794, 393);
            this.TabControl.TabIndex = 0;
            // 
            // RevisionPage
            // 
            this.RevisionPage.Controls.Add(this.RevisionExcelButton);
            this.RevisionPage.Controls.Add(this.UpdateRevisionButton);
            this.RevisionPage.Controls.Add(this.RevisionDgv);
            this.RevisionPage.Location = new System.Drawing.Point(4, 25);
            this.RevisionPage.Name = "RevisionPage";
            this.RevisionPage.Padding = new System.Windows.Forms.Padding(3);
            this.RevisionPage.Size = new System.Drawing.Size(786, 364);
            this.RevisionPage.TabIndex = 5;
            this.RevisionPage.Text = "Revision";
            this.RevisionPage.UseVisualStyleBackColor = true;
            // 
            // UpdateRevisionButton
            // 
            this.UpdateRevisionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateRevisionButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateRevisionButton.Depth = 0;
            this.UpdateRevisionButton.HighEmphasis = true;
            this.UpdateRevisionButton.Icon = null;
            this.UpdateRevisionButton.Location = new System.Drawing.Point(12, 9);
            this.UpdateRevisionButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateRevisionButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateRevisionButton.Name = "UpdateRevisionButton";
            this.UpdateRevisionButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateRevisionButton.Size = new System.Drawing.Size(77, 36);
            this.UpdateRevisionButton.TabIndex = 13;
            this.UpdateRevisionButton.Text = "Update";
            this.UpdateRevisionButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateRevisionButton.UseAccentColor = false;
            this.UpdateRevisionButton.UseVisualStyleBackColor = true;
            this.UpdateRevisionButton.Click += new System.EventHandler(this.UpdateRevisionButton_Click);
            // 
            // RevisionDgv
            // 
            this.RevisionDgv.AllowUserToAddRows = false;
            this.RevisionDgv.AllowUserToDeleteRows = false;
            this.RevisionDgv.AllowUserToResizeRows = false;
            this.RevisionDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RevisionDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.RevisionDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RevisionDgv.Location = new System.Drawing.Point(12, 54);
            this.RevisionDgv.Name = "RevisionDgv";
            this.RevisionDgv.ReadOnly = true;
            this.RevisionDgv.RowHeadersWidth = 51;
            this.RevisionDgv.RowTemplate.Height = 24;
            this.RevisionDgv.Size = new System.Drawing.Size(768, 259);
            this.RevisionDgv.TabIndex = 12;
            // 
            // DangerousOperationsPage
            // 
            this.DangerousOperationsPage.Controls.Add(this.WaiterComboBoxClearButton);
            this.DangerousOperationsPage.Controls.Add(this.WaitersComboBox);
            this.DangerousOperationsPage.Controls.Add(this.UpdateDangerousOperationsButton);
            this.DangerousOperationsPage.Controls.Add(this.DangerousDgv);
            this.DangerousOperationsPage.Location = new System.Drawing.Point(4, 25);
            this.DangerousOperationsPage.Name = "DangerousOperationsPage";
            this.DangerousOperationsPage.Padding = new System.Windows.Forms.Padding(3);
            this.DangerousOperationsPage.Size = new System.Drawing.Size(786, 364);
            this.DangerousOperationsPage.TabIndex = 6;
            this.DangerousOperationsPage.Text = "Dangerous operations";
            this.DangerousOperationsPage.UseVisualStyleBackColor = true;
            // 
            // WaiterComboBoxClearButton
            // 
            this.WaiterComboBoxClearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WaiterComboBoxClearButton.AutoSize = false;
            this.WaiterComboBoxClearButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.WaiterComboBoxClearButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.WaiterComboBoxClearButton.Depth = 0;
            this.WaiterComboBoxClearButton.HighEmphasis = true;
            this.WaiterComboBoxClearButton.Icon = null;
            this.WaiterComboBoxClearButton.Location = new System.Drawing.Point(657, 9);
            this.WaiterComboBoxClearButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.WaiterComboBoxClearButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.WaiterComboBoxClearButton.Name = "WaiterComboBoxClearButton";
            this.WaiterComboBoxClearButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.WaiterComboBoxClearButton.Size = new System.Drawing.Size(123, 49);
            this.WaiterComboBoxClearButton.TabIndex = 16;
            this.WaiterComboBoxClearButton.Text = "Waiter clear";
            this.WaiterComboBoxClearButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.WaiterComboBoxClearButton.UseAccentColor = false;
            this.WaiterComboBoxClearButton.UseVisualStyleBackColor = true;
            this.WaiterComboBoxClearButton.Click += new System.EventHandler(this.WaiterComboBoxClearButton_Click);
            // 
            // WaitersComboBox
            // 
            this.WaitersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitersComboBox.AutoResize = false;
            this.WaitersComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.WaitersComboBox.Depth = 0;
            this.WaitersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.WaitersComboBox.DropDownHeight = 174;
            this.WaitersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WaitersComboBox.DropDownWidth = 121;
            this.WaitersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.WaitersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WaitersComboBox.FormattingEnabled = true;
            this.WaitersComboBox.IntegralHeight = false;
            this.WaitersComboBox.ItemHeight = 43;
            this.WaitersComboBox.Location = new System.Drawing.Point(129, 9);
            this.WaitersComboBox.MaxDropDownItems = 4;
            this.WaitersComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.WaitersComboBox.Name = "WaitersComboBox";
            this.WaitersComboBox.Size = new System.Drawing.Size(521, 49);
            this.WaitersComboBox.StartIndex = 0;
            this.WaitersComboBox.TabIndex = 15;
            // 
            // UpdateDangerousOperationsButton
            // 
            this.UpdateDangerousOperationsButton.AutoSize = false;
            this.UpdateDangerousOperationsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateDangerousOperationsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateDangerousOperationsButton.Depth = 0;
            this.UpdateDangerousOperationsButton.HighEmphasis = true;
            this.UpdateDangerousOperationsButton.Icon = null;
            this.UpdateDangerousOperationsButton.Location = new System.Drawing.Point(12, 9);
            this.UpdateDangerousOperationsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateDangerousOperationsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateDangerousOperationsButton.Name = "UpdateDangerousOperationsButton";
            this.UpdateDangerousOperationsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateDangerousOperationsButton.Size = new System.Drawing.Size(110, 49);
            this.UpdateDangerousOperationsButton.TabIndex = 14;
            this.UpdateDangerousOperationsButton.Text = "Update";
            this.UpdateDangerousOperationsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateDangerousOperationsButton.UseAccentColor = false;
            this.UpdateDangerousOperationsButton.UseVisualStyleBackColor = true;
            this.UpdateDangerousOperationsButton.Click += new System.EventHandler(this.UpdateDangerousOperationsButton_Click);
            // 
            // DangerousDgv
            // 
            this.DangerousDgv.AllowUserToAddRows = false;
            this.DangerousDgv.AllowUserToDeleteRows = false;
            this.DangerousDgv.AllowUserToResizeRows = false;
            this.DangerousDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DangerousDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DangerousDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DangerousDgv.Location = new System.Drawing.Point(12, 69);
            this.DangerousDgv.Name = "DangerousDgv";
            this.DangerousDgv.ReadOnly = true;
            this.DangerousDgv.RowHeadersWidth = 51;
            this.DangerousDgv.RowTemplate.Height = 24;
            this.DangerousDgv.Size = new System.Drawing.Size(768, 289);
            this.DangerousDgv.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.EndDateTimePicker);
            this.panel1.Controls.Add(this.StartDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 40);
            this.panel1.TabIndex = 1;
            // 
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EndDateTimePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EndDateTimePicker.BorderSize = 0;
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EndDateTimePicker.Location = new System.Drawing.Point(590, 2);
            this.EndDateTimePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.EndDateTimePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.EndDateTimePicker.TabIndex = 15;
            this.EndDateTimePicker.TextColor = System.Drawing.Color.White;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartDateTimePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StartDateTimePicker.BorderSize = 0;
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.StartDateTimePicker.Location = new System.Drawing.Point(384, 2);
            this.StartDateTimePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.StartDateTimePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.StartDateTimePicker.TabIndex = 14;
            this.StartDateTimePicker.TextColor = System.Drawing.Color.White;
            // 
            // RevisionExcelButton
            // 
            this.RevisionExcelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RevisionExcelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RevisionExcelButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RevisionExcelButton.Depth = 0;
            this.RevisionExcelButton.HighEmphasis = true;
            this.RevisionExcelButton.Icon = null;
            this.RevisionExcelButton.Location = new System.Drawing.Point(715, 322);
            this.RevisionExcelButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RevisionExcelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RevisionExcelButton.Name = "RevisionExcelButton";
            this.RevisionExcelButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RevisionExcelButton.Size = new System.Drawing.Size(65, 36);
            this.RevisionExcelButton.TabIndex = 19;
            this.RevisionExcelButton.Text = "Excel";
            this.RevisionExcelButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RevisionExcelButton.UseAccentColor = false;
            this.RevisionExcelButton.UseVisualStyleBackColor = true;
            this.RevisionExcelButton.Click += new System.EventHandler(this.RevisionExcelButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel1);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 5;
            this.DrawerTabControl = this.TabControl;
            this.DrawerWidth = 300;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            this.TabControl.ResumeLayout(false);
            this.RevisionPage.ResumeLayout(false);
            this.RevisionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevisionDgv)).EndInit();
            this.DangerousOperationsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DangerousDgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage RevisionPage;
        private System.Windows.Forms.DataGridView RevisionDgv;
        private MaterialSkin.Controls.MaterialButton UpdateRevisionButton;
        private CustomControls.CustomDateTimePicker StartDateTimePicker;
        private CustomControls.CustomDateTimePicker EndDateTimePicker;
        private System.Windows.Forms.TabPage DangerousOperationsPage;
        private System.Windows.Forms.DataGridView DangerousDgv;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton UpdateDangerousOperationsButton;
        private MaterialSkin.Controls.MaterialComboBox WaitersComboBox;
        private MaterialSkin.Controls.MaterialButton WaiterComboBoxClearButton;
        private MaterialSkin.Controls.MaterialButton RevisionExcelButton;
    }
}

