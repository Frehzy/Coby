namespace Office.Forms
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
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.RevisionPage = new System.Windows.Forms.TabPage();
            this.RevisionDgv = new System.Windows.Forms.DataGridView();
            this.UpdateRevisionButton = new MaterialSkin.Controls.MaterialButton();
            this.EndDateTimePicker = new Office.Forms.CustomControls.CustomDateTimePicker();
            this.StartDateTimePicker = new Office.Forms.CustomControls.CustomDateTimePicker();
            this.TabControl.SuspendLayout();
            this.RevisionPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevisionDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.RevisionPage);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(3, 64);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(794, 433);
            this.TabControl.TabIndex = 0;
            // 
            // RevisionPage
            // 
            this.RevisionPage.Controls.Add(this.EndDateTimePicker);
            this.RevisionPage.Controls.Add(this.StartDateTimePicker);
            this.RevisionPage.Controls.Add(this.UpdateRevisionButton);
            this.RevisionPage.Controls.Add(this.RevisionDgv);
            this.RevisionPage.Location = new System.Drawing.Point(4, 25);
            this.RevisionPage.Name = "RevisionPage";
            this.RevisionPage.Padding = new System.Windows.Forms.Padding(3);
            this.RevisionPage.Size = new System.Drawing.Size(786, 404);
            this.RevisionPage.TabIndex = 5;
            this.RevisionPage.Text = "Revision";
            this.RevisionPage.UseVisualStyleBackColor = true;
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
            this.RevisionDgv.Size = new System.Drawing.Size(768, 344);
            this.RevisionDgv.TabIndex = 12;
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
            // EndDateTimePicker
            // 
            this.EndDateTimePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EndDateTimePicker.BorderSize = 0;
            this.EndDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.EndDateTimePicker.Location = new System.Drawing.Point(302, 10);
            this.EndDateTimePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.EndDateTimePicker.Name = "EndDateTimePicker";
            this.EndDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.EndDateTimePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.EndDateTimePicker.TabIndex = 15;
            this.EndDateTimePicker.TextColor = System.Drawing.Color.White;
            // 
            // StartDateTimePicker
            // 
            this.StartDateTimePicker.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.StartDateTimePicker.BorderSize = 0;
            this.StartDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F);
            this.StartDateTimePicker.Location = new System.Drawing.Point(96, 10);
            this.StartDateTimePicker.MinimumSize = new System.Drawing.Size(4, 35);
            this.StartDateTimePicker.Name = "StartDateTimePicker";
            this.StartDateTimePicker.Size = new System.Drawing.Size(200, 35);
            this.StartDateTimePicker.SkinColor = System.Drawing.Color.MediumSlateBlue;
            this.StartDateTimePicker.TabIndex = 14;
            this.StartDateTimePicker.TextColor = System.Drawing.Color.White;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.TabControl);
            this.DrawerAutoShow = true;
            this.DrawerBackgroundWithAccent = true;
            this.DrawerIndicatorWidth = 5;
            this.DrawerTabControl = this.TabControl;
            this.DrawerWidth = 300;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.TabControl.ResumeLayout(false);
            this.RevisionPage.ResumeLayout(false);
            this.RevisionPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevisionDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage RevisionPage;
        private System.Windows.Forms.DataGridView RevisionDgv;
        private MaterialSkin.Controls.MaterialButton UpdateRevisionButton;
        private CustomControls.CustomDateTimePicker StartDateTimePicker;
        private CustomControls.CustomDateTimePicker EndDateTimePicker;
    }
}

