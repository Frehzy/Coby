namespace Coby.Forms
{
    partial class MainForm
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
            this.MainFormTabController = new MaterialSkin.Controls.MaterialTabControl();
            this.CreateOrderPage = new System.Windows.Forms.TabPage();
            this.CreateOrderLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.OpenOrderLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OptionsPage = new System.Windows.Forms.TabPage();
            this.OptionsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.CafeSessionClose = new MaterialSkin.Controls.MaterialButton();
            this.PersonalShiftController = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LockButton = new MaterialSkin.Controls.MaterialButton();
            this.MainFormTabController.SuspendLayout();
            this.CreateOrderPage.SuspendLayout();
            this.OrdersPage.SuspendLayout();
            this.OptionsPage.SuspendLayout();
            this.OptionsLayoutPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormTabController
            // 
            this.MainFormTabController.Controls.Add(this.CreateOrderPage);
            this.MainFormTabController.Controls.Add(this.OrdersPage);
            this.MainFormTabController.Controls.Add(this.OptionsPage);
            this.MainFormTabController.Depth = 0;
            this.MainFormTabController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormTabController.Location = new System.Drawing.Point(3, 109);
            this.MainFormTabController.MouseState = MaterialSkin.MouseState.HOVER;
            this.MainFormTabController.Multiline = true;
            this.MainFormTabController.Name = "MainFormTabController";
            this.MainFormTabController.SelectedIndex = 0;
            this.MainFormTabController.Size = new System.Drawing.Size(794, 338);
            this.MainFormTabController.TabIndex = 0;
            this.MainFormTabController.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.MainFormTabController_Selecting);
            // 
            // CreateOrderPage
            // 
            this.CreateOrderPage.Controls.Add(this.CreateOrderLayoutPanel);
            this.CreateOrderPage.Location = new System.Drawing.Point(4, 25);
            this.CreateOrderPage.Name = "CreateOrderPage";
            this.CreateOrderPage.Padding = new System.Windows.Forms.Padding(3);
            this.CreateOrderPage.Size = new System.Drawing.Size(786, 309);
            this.CreateOrderPage.TabIndex = 2;
            this.CreateOrderPage.Text = "Create order";
            this.CreateOrderPage.UseVisualStyleBackColor = true;
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
            this.CreateOrderLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.CreateOrderLayoutPanel.Name = "CreateOrderLayoutPanel";
            this.CreateOrderLayoutPanel.RowCount = 5;
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.CreateOrderLayoutPanel.Size = new System.Drawing.Size(780, 303);
            this.CreateOrderLayoutPanel.TabIndex = 2;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Controls.Add(this.OpenOrderLayoutPanel);
            this.OrdersPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Padding = new System.Windows.Forms.Padding(3);
            this.OrdersPage.Size = new System.Drawing.Size(786, 309);
            this.OrdersPage.TabIndex = 0;
            this.OrdersPage.Text = "Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // OpenOrderLayoutPanel
            // 
            this.OpenOrderLayoutPanel.ColumnCount = 5;
            this.OpenOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenOrderLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OpenOrderLayoutPanel.Name = "OpenOrderLayoutPanel";
            this.OpenOrderLayoutPanel.RowCount = 5;
            this.OpenOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OpenOrderLayoutPanel.Size = new System.Drawing.Size(780, 303);
            this.OpenOrderLayoutPanel.TabIndex = 3;
            // 
            // OptionsPage
            // 
            this.OptionsPage.Controls.Add(this.OptionsLayoutPanel);
            this.OptionsPage.Location = new System.Drawing.Point(4, 25);
            this.OptionsPage.Name = "OptionsPage";
            this.OptionsPage.Padding = new System.Windows.Forms.Padding(3);
            this.OptionsPage.Size = new System.Drawing.Size(786, 309);
            this.OptionsPage.TabIndex = 1;
            this.OptionsPage.Text = "Options";
            this.OptionsPage.UseVisualStyleBackColor = true;
            // 
            // OptionsLayoutPanel
            // 
            this.OptionsLayoutPanel.ColumnCount = 3;
            this.OptionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.OptionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OptionsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.OptionsLayoutPanel.Controls.Add(this.CafeSessionClose, 1, 0);
            this.OptionsLayoutPanel.Controls.Add(this.PersonalShiftController, 0, 0);
            this.OptionsLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OptionsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.OptionsLayoutPanel.Name = "OptionsLayoutPanel";
            this.OptionsLayoutPanel.RowCount = 4;
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OptionsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.OptionsLayoutPanel.Size = new System.Drawing.Size(780, 303);
            this.OptionsLayoutPanel.TabIndex = 1;
            // 
            // CafeSessionClose
            // 
            this.CafeSessionClose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CafeSessionClose.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CafeSessionClose.Depth = 0;
            this.CafeSessionClose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CafeSessionClose.HighEmphasis = true;
            this.CafeSessionClose.Icon = null;
            this.CafeSessionClose.Location = new System.Drawing.Point(264, 6);
            this.CafeSessionClose.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CafeSessionClose.MouseState = MaterialSkin.MouseState.HOVER;
            this.CafeSessionClose.Name = "CafeSessionClose";
            this.CafeSessionClose.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CafeSessionClose.Size = new System.Drawing.Size(251, 48);
            this.CafeSessionClose.TabIndex = 1;
            this.CafeSessionClose.Text = "Закрыть кассовую смену";
            this.CafeSessionClose.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CafeSessionClose.UseAccentColor = false;
            this.CafeSessionClose.UseVisualStyleBackColor = true;
            this.CafeSessionClose.Click += new System.EventHandler(this.CafeSessionClose_Click);
            // 
            // PersonalShiftController
            // 
            this.PersonalShiftController.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PersonalShiftController.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PersonalShiftController.Depth = 0;
            this.PersonalShiftController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonalShiftController.HighEmphasis = true;
            this.PersonalShiftController.Icon = null;
            this.PersonalShiftController.Location = new System.Drawing.Point(4, 6);
            this.PersonalShiftController.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PersonalShiftController.MouseState = MaterialSkin.MouseState.HOVER;
            this.PersonalShiftController.Name = "PersonalShiftController";
            this.PersonalShiftController.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PersonalShiftController.Size = new System.Drawing.Size(252, 48);
            this.PersonalShiftController.TabIndex = 0;
            this.PersonalShiftController.Text = "ShiftStatus";
            this.PersonalShiftController.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PersonalShiftController.UseAccentColor = false;
            this.PersonalShiftController.UseVisualStyleBackColor = true;
            this.PersonalShiftController.Click += new System.EventHandler(this.ChangePersonalShiftStatus_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LockButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 45);
            this.panel1.TabIndex = 1;
            // 
            // LockButton
            // 
            this.LockButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LockButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LockButton.Depth = 0;
            this.LockButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.LockButton.HighEmphasis = true;
            this.LockButton.Icon = null;
            this.LockButton.Location = new System.Drawing.Point(730, 0);
            this.LockButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LockButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LockButton.Name = "LockButton";
            this.LockButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LockButton.Size = new System.Drawing.Size(64, 45);
            this.LockButton.TabIndex = 2;
            this.LockButton.Text = "Lock";
            this.LockButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LockButton.UseAccentColor = false;
            this.LockButton.UseVisualStyleBackColor = true;
            this.LockButton.Click += new System.EventHandler(this.LockButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainFormTabController);
            this.Controls.Add(this.panel1);
            this.DrawerTabControl = this.MainFormTabController;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainFormTabController.ResumeLayout(false);
            this.CreateOrderPage.ResumeLayout(false);
            this.OrdersPage.ResumeLayout(false);
            this.OptionsPage.ResumeLayout(false);
            this.OptionsLayoutPanel.ResumeLayout(false);
            this.OptionsLayoutPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl MainFormTabController;
        private System.Windows.Forms.TabPage OrdersPage;
        private System.Windows.Forms.TabPage OptionsPage;
        private System.Windows.Forms.TabPage CreateOrderPage;
        private MaterialSkin.Controls.MaterialButton PersonalShiftController;
        private System.Windows.Forms.TableLayoutPanel OptionsLayoutPanel;
        private MaterialSkin.Controls.MaterialButton CafeSessionClose;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton LockButton;
        private System.Windows.Forms.TableLayoutPanel CreateOrderLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel OpenOrderLayoutPanel;
    }
}