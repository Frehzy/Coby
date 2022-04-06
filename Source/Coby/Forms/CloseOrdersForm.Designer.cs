namespace Coby.Forms
{
    partial class CloseOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloseOrdersForm));
            this.CloseOrdersTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.CreateOrderPanel = new System.Windows.Forms.Panel();
            this.DownButton = new MaterialSkin.Controls.MaterialButton();
            this.UpButton = new MaterialSkin.Controls.MaterialButton();
            this.BackPanel.SuspendLayout();
            this.CreateOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseOrdersTableLayout
            // 
            this.CloseOrdersTableLayout.ColumnCount = 1;
            this.CloseOrdersTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CloseOrdersTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseOrdersTableLayout.Location = new System.Drawing.Point(3, 45);
            this.CloseOrdersTableLayout.Name = "CloseOrdersTableLayout";
            this.CloseOrdersTableLayout.RowCount = 2;
            this.CloseOrdersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseOrdersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CloseOrdersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CloseOrdersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CloseOrdersTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CloseOrdersTableLayout.Size = new System.Drawing.Size(794, 357);
            this.CloseOrdersTableLayout.TabIndex = 3;
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.BackButton);
            this.BackPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BackPanel.Location = new System.Drawing.Point(3, 0);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(794, 45);
            this.BackPanel.TabIndex = 5;
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
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "<-";
            this.BackButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.BackButton.UseAccentColor = false;
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CreateOrderPanel
            // 
            this.CreateOrderPanel.Controls.Add(this.DownButton);
            this.CreateOrderPanel.Controls.Add(this.UpButton);
            this.CreateOrderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CreateOrderPanel.Location = new System.Drawing.Point(3, 402);
            this.CreateOrderPanel.Name = "CreateOrderPanel";
            this.CreateOrderPanel.Size = new System.Drawing.Size(794, 45);
            this.CreateOrderPanel.TabIndex = 6;
            // 
            // DownButton
            // 
            this.DownButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DownButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DownButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DownButton.Depth = 0;
            this.DownButton.HighEmphasis = true;
            this.DownButton.Icon = null;
            this.DownButton.Location = new System.Drawing.Point(329, 4);
            this.DownButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DownButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DownButton.Name = "DownButton";
            this.DownButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DownButton.Size = new System.Drawing.Size(64, 36);
            this.DownButton.TabIndex = 7;
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
            this.UpButton.Location = new System.Drawing.Point(401, 4);
            this.UpButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpButton.Name = "UpButton";
            this.UpButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpButton.Size = new System.Drawing.Size(64, 36);
            this.UpButton.TabIndex = 6;
            this.UpButton.Text = "↑";
            this.UpButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpButton.UseAccentColor = false;
            this.UpButton.UseVisualStyleBackColor = true;
            this.UpButton.Click += new System.EventHandler(this.UpButton_Click);
            // 
            // CloseOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CloseOrdersTableLayout);
            this.Controls.Add(this.CreateOrderPanel);
            this.Controls.Add(this.BackPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CloseOrdersForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateOrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.CreateOrderPanel.ResumeLayout(false);
            this.CreateOrderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CloseOrdersTableLayout;
        private System.Windows.Forms.Panel BackPanel;
        private MaterialSkin.Controls.MaterialButton BackButton;
        private System.Windows.Forms.Panel CreateOrderPanel;
        private MaterialSkin.Controls.MaterialButton DownButton;
        private MaterialSkin.Controls.MaterialButton UpButton;
    }
}