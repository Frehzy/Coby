namespace Office.Forms.StatisticsPage
{
    partial class OrdersForm
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
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.MoreInfoButton = new MaterialSkin.Controls.MaterialButton();
            this.OrdersUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.CloseOrdersDgv = new System.Windows.Forms.DataGridView();
            this.ButtonsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseOrdersDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.MoreInfoButton);
            this.ButtonsPanel.Controls.Add(this.OrdersUpdateButton);
            this.ButtonsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 64);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(916, 54);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // MoreInfoButton
            // 
            this.MoreInfoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MoreInfoButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MoreInfoButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MoreInfoButton.Depth = 0;
            this.MoreInfoButton.HighEmphasis = true;
            this.MoreInfoButton.Icon = null;
            this.MoreInfoButton.Location = new System.Drawing.Point(848, 6);
            this.MoreInfoButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MoreInfoButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.MoreInfoButton.Name = "MoreInfoButton";
            this.MoreInfoButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MoreInfoButton.Size = new System.Drawing.Size(64, 36);
            this.MoreInfoButton.TabIndex = 17;
            this.MoreInfoButton.Text = "More";
            this.MoreInfoButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MoreInfoButton.UseAccentColor = false;
            this.MoreInfoButton.UseVisualStyleBackColor = true;
            this.MoreInfoButton.Click += new System.EventHandler(this.MoreInfoButton_Click);
            // 
            // OrdersUpdateButton
            // 
            this.OrdersUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OrdersUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OrdersUpdateButton.Depth = 0;
            this.OrdersUpdateButton.HighEmphasis = true;
            this.OrdersUpdateButton.Icon = null;
            this.OrdersUpdateButton.Location = new System.Drawing.Point(4, 6);
            this.OrdersUpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OrdersUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OrdersUpdateButton.Name = "OrdersUpdateButton";
            this.OrdersUpdateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OrdersUpdateButton.Size = new System.Drawing.Size(136, 36);
            this.OrdersUpdateButton.TabIndex = 15;
            this.OrdersUpdateButton.Text = "Orders update";
            this.OrdersUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OrdersUpdateButton.UseAccentColor = false;
            this.OrdersUpdateButton.UseVisualStyleBackColor = true;
            this.OrdersUpdateButton.Click += new System.EventHandler(this.OrdersUpdateButton_Click);
            // 
            // CloseOrdersDgv
            // 
            this.CloseOrdersDgv.AllowUserToAddRows = false;
            this.CloseOrdersDgv.AllowUserToDeleteRows = false;
            this.CloseOrdersDgv.AllowUserToResizeRows = false;
            this.CloseOrdersDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.CloseOrdersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CloseOrdersDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseOrdersDgv.Location = new System.Drawing.Point(3, 118);
            this.CloseOrdersDgv.Name = "CloseOrdersDgv";
            this.CloseOrdersDgv.ReadOnly = true;
            this.CloseOrdersDgv.RowHeadersWidth = 51;
            this.CloseOrdersDgv.RowTemplate.Height = 24;
            this.CloseOrdersDgv.Size = new System.Drawing.Size(916, 466);
            this.CloseOrdersDgv.TabIndex = 16;
            // 
            // CloseOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.CloseOrdersDgv);
            this.Controls.Add(this.ButtonsPanel);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "CloseOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Close orders";
            this.ButtonsPanel.ResumeLayout(false);
            this.ButtonsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseOrdersDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.DataGridView CloseOrdersDgv;
        private MaterialSkin.Controls.MaterialButton OrdersUpdateButton;
        private MaterialSkin.Controls.MaterialButton MoreInfoButton;
    }
}