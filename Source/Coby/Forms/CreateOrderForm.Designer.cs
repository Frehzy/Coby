namespace Coby.Forms
{
    partial class CreateOrderForm
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
            this.CreateOrderLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.BackButton = new MaterialSkin.Controls.MaterialButton();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateOrderLayoutPanel
            // 
            this.CreateOrderLayoutPanel.ColumnCount = 5;
            this.CreateOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CreateOrderLayoutPanel.Location = new System.Drawing.Point(3, 45);
            this.CreateOrderLayoutPanel.Name = "CreateOrderLayoutPanel";
            this.CreateOrderLayoutPanel.RowCount = 5;
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.Size = new System.Drawing.Size(794, 402);
            this.CreateOrderLayoutPanel.TabIndex = 3;
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
            // CreateOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CreateOrderLayoutPanel);
            this.Controls.Add(this.BackPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.StatusAndActionBar_None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateOrderForm";
            this.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateOrderForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel CreateOrderLayoutPanel;
        private System.Windows.Forms.Panel BackPanel;
        private MaterialSkin.Controls.MaterialButton BackButton;
    }
}