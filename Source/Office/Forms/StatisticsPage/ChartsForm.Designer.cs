namespace Office.Forms
{
    partial class ChartsForm
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
            this.CloseOrdersPage = new System.Windows.Forms.TabPage();
            this.UpdateCloseOrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.CloseOrdersCharts = new LiveCharts.WinForms.CartesianChart();
            this.TabControl.SuspendLayout();
            this.CloseOrdersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CloseOrdersPage);
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
            // CloseOrdersPage
            // 
            this.CloseOrdersPage.Controls.Add(this.UpdateCloseOrdersButton);
            this.CloseOrdersPage.Controls.Add(this.CloseOrdersCharts);
            this.CloseOrdersPage.Location = new System.Drawing.Point(4, 25);
            this.CloseOrdersPage.Name = "CloseOrdersPage";
            this.CloseOrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.CloseOrdersPage.Size = new System.Drawing.Size(786, 404);
            this.CloseOrdersPage.TabIndex = 4;
            this.CloseOrdersPage.Text = "CloseOrders";
            this.CloseOrdersPage.UseVisualStyleBackColor = true;
            // 
            // UpdateCloseOrdersButton
            // 
            this.UpdateCloseOrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateCloseOrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateCloseOrdersButton.Depth = 0;
            this.UpdateCloseOrdersButton.HighEmphasis = true;
            this.UpdateCloseOrdersButton.Icon = null;
            this.UpdateCloseOrdersButton.Location = new System.Drawing.Point(7, 9);
            this.UpdateCloseOrdersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateCloseOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateCloseOrdersButton.Name = "UpdateCloseOrdersButton";
            this.UpdateCloseOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateCloseOrdersButton.Size = new System.Drawing.Size(77, 36);
            this.UpdateCloseOrdersButton.TabIndex = 1;
            this.UpdateCloseOrdersButton.Text = "Update";
            this.UpdateCloseOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateCloseOrdersButton.UseAccentColor = false;
            this.UpdateCloseOrdersButton.UseVisualStyleBackColor = true;
            this.UpdateCloseOrdersButton.Click += new System.EventHandler(this.UpdateCloseOrdersButton_Click);
            // 
            // CloseOrdersCharts
            // 
            this.CloseOrdersCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseOrdersCharts.Location = new System.Drawing.Point(7, 54);
            this.CloseOrdersCharts.Name = "CloseOrdersCharts";
            this.CloseOrdersCharts.Size = new System.Drawing.Size(773, 344);
            this.CloseOrdersCharts.TabIndex = 0;
            this.CloseOrdersCharts.Text = "CloseOrdersCharts";
            // 
            // ChartsForm
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
            this.Name = "ChartsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Charts";
            this.TabControl.ResumeLayout(false);
            this.CloseOrdersPage.ResumeLayout(false);
            this.CloseOrdersPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage CloseOrdersPage;
        private LiveCharts.WinForms.CartesianChart CloseOrdersCharts;
        private MaterialSkin.Controls.MaterialButton UpdateCloseOrdersButton;
    }
}

