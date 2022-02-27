namespace Office.Forms
{
    partial class MainForm
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
            this.WaitersPage = new System.Windows.Forms.TabPage();
            this.WaitersDgv = new System.Windows.Forms.DataGridView();
            this.DeleteWaiterButton = new MaterialSkin.Controls.MaterialButton();
            this.AddWaiterButton = new MaterialSkin.Controls.MaterialButton();
            this.UpdateWaitersButton = new MaterialSkin.Controls.MaterialButton();
            this.TablesPage = new System.Windows.Forms.TabPage();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.PaymentTypesPage = new System.Windows.Forms.TabPage();
            this.OrdersPage = new System.Windows.Forms.TabPage();
            this.TablesDgv = new System.Windows.Forms.DataGridView();
            this.RemoveTableButton = new MaterialSkin.Controls.MaterialButton();
            this.AddTableButton = new MaterialSkin.Controls.MaterialButton();
            this.TableUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.PaymentTypesDgv = new System.Windows.Forms.DataGridView();
            this.RemovePaymentTypeButton = new MaterialSkin.Controls.MaterialButton();
            this.AddPaymentTypeButton = new MaterialSkin.Controls.MaterialButton();
            this.PaymentTypeUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.TabControl.SuspendLayout();
            this.WaitersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitersDgv)).BeginInit();
            this.TablesPage.SuspendLayout();
            this.PaymentTypesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablesDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypesDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.WaitersPage);
            this.TabControl.Controls.Add(this.TablesPage);
            this.TabControl.Controls.Add(this.ProductsPage);
            this.TabControl.Controls.Add(this.PaymentTypesPage);
            this.TabControl.Controls.Add(this.OrdersPage);
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
            // WaitersPage
            // 
            this.WaitersPage.Controls.Add(this.WaitersDgv);
            this.WaitersPage.Controls.Add(this.DeleteWaiterButton);
            this.WaitersPage.Controls.Add(this.AddWaiterButton);
            this.WaitersPage.Controls.Add(this.UpdateWaitersButton);
            this.WaitersPage.Location = new System.Drawing.Point(4, 25);
            this.WaitersPage.Name = "WaitersPage";
            this.WaitersPage.Padding = new System.Windows.Forms.Padding(3);
            this.WaitersPage.Size = new System.Drawing.Size(786, 404);
            this.WaitersPage.TabIndex = 0;
            this.WaitersPage.Text = "Waiters";
            this.WaitersPage.UseVisualStyleBackColor = true;
            // 
            // WaitersDgv
            // 
            this.WaitersDgv.AllowUserToAddRows = false;
            this.WaitersDgv.AllowUserToDeleteRows = false;
            this.WaitersDgv.AllowUserToResizeRows = false;
            this.WaitersDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WaitersDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WaitersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaitersDgv.Location = new System.Drawing.Point(7, 55);
            this.WaitersDgv.Name = "WaitersDgv";
            this.WaitersDgv.ReadOnly = true;
            this.WaitersDgv.RowHeadersWidth = 51;
            this.WaitersDgv.RowTemplate.Height = 24;
            this.WaitersDgv.Size = new System.Drawing.Size(763, 343);
            this.WaitersDgv.TabIndex = 3;
            // 
            // DeleteWaiterButton
            // 
            this.DeleteWaiterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteWaiterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteWaiterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.DeleteWaiterButton.Depth = 0;
            this.DeleteWaiterButton.HighEmphasis = true;
            this.DeleteWaiterButton.Icon = null;
            this.DeleteWaiterButton.Location = new System.Drawing.Point(697, 9);
            this.DeleteWaiterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DeleteWaiterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteWaiterButton.Name = "DeleteWaiterButton";
            this.DeleteWaiterButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.DeleteWaiterButton.Size = new System.Drawing.Size(73, 36);
            this.DeleteWaiterButton.TabIndex = 2;
            this.DeleteWaiterButton.Text = "Delete";
            this.DeleteWaiterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.DeleteWaiterButton.UseAccentColor = false;
            this.DeleteWaiterButton.UseVisualStyleBackColor = true;
            this.DeleteWaiterButton.Click += new System.EventHandler(this.DeleteWaiterButton_Click);
            // 
            // AddWaiterButton
            // 
            this.AddWaiterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddWaiterButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddWaiterButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddWaiterButton.Depth = 0;
            this.AddWaiterButton.HighEmphasis = true;
            this.AddWaiterButton.Icon = null;
            this.AddWaiterButton.Location = new System.Drawing.Point(625, 9);
            this.AddWaiterButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddWaiterButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddWaiterButton.Name = "AddWaiterButton";
            this.AddWaiterButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddWaiterButton.Size = new System.Drawing.Size(64, 36);
            this.AddWaiterButton.TabIndex = 1;
            this.AddWaiterButton.Text = "Add";
            this.AddWaiterButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddWaiterButton.UseAccentColor = false;
            this.AddWaiterButton.UseVisualStyleBackColor = true;
            this.AddWaiterButton.Click += new System.EventHandler(this.AddWaiterButton_Click);
            // 
            // UpdateWaitersButton
            // 
            this.UpdateWaitersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.UpdateWaitersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.UpdateWaitersButton.Depth = 0;
            this.UpdateWaitersButton.HighEmphasis = true;
            this.UpdateWaitersButton.Icon = null;
            this.UpdateWaitersButton.Location = new System.Drawing.Point(7, 9);
            this.UpdateWaitersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.UpdateWaitersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.UpdateWaitersButton.Name = "UpdateWaitersButton";
            this.UpdateWaitersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.UpdateWaitersButton.Size = new System.Drawing.Size(134, 36);
            this.UpdateWaitersButton.TabIndex = 0;
            this.UpdateWaitersButton.Text = "Waiter update";
            this.UpdateWaitersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.UpdateWaitersButton.UseAccentColor = false;
            this.UpdateWaitersButton.UseVisualStyleBackColor = true;
            this.UpdateWaitersButton.Click += new System.EventHandler(this.UpdateWaitersButton_Click);
            // 
            // TablesPage
            // 
            this.TablesPage.Controls.Add(this.TablesDgv);
            this.TablesPage.Controls.Add(this.RemoveTableButton);
            this.TablesPage.Controls.Add(this.AddTableButton);
            this.TablesPage.Controls.Add(this.TableUpdateButton);
            this.TablesPage.Location = new System.Drawing.Point(4, 25);
            this.TablesPage.Name = "TablesPage";
            this.TablesPage.Padding = new System.Windows.Forms.Padding(3);
            this.TablesPage.Size = new System.Drawing.Size(786, 404);
            this.TablesPage.TabIndex = 1;
            this.TablesPage.Text = "Tables";
            this.TablesPage.UseVisualStyleBackColor = true;
            // 
            // ProductsPage
            // 
            this.ProductsPage.Location = new System.Drawing.Point(4, 25);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Size = new System.Drawing.Size(786, 404);
            this.ProductsPage.TabIndex = 2;
            this.ProductsPage.Text = "Products";
            this.ProductsPage.UseVisualStyleBackColor = true;
            // 
            // PaymentTypesPage
            // 
            this.PaymentTypesPage.Controls.Add(this.PaymentTypesDgv);
            this.PaymentTypesPage.Controls.Add(this.RemovePaymentTypeButton);
            this.PaymentTypesPage.Controls.Add(this.AddPaymentTypeButton);
            this.PaymentTypesPage.Controls.Add(this.PaymentTypeUpdateButton);
            this.PaymentTypesPage.Location = new System.Drawing.Point(4, 25);
            this.PaymentTypesPage.Name = "PaymentTypesPage";
            this.PaymentTypesPage.Size = new System.Drawing.Size(786, 404);
            this.PaymentTypesPage.TabIndex = 3;
            this.PaymentTypesPage.Text = "PaymentTypes";
            this.PaymentTypesPage.UseVisualStyleBackColor = true;
            // 
            // OrdersPage
            // 
            this.OrdersPage.Location = new System.Drawing.Point(4, 25);
            this.OrdersPage.Name = "OrdersPage";
            this.OrdersPage.Size = new System.Drawing.Size(786, 404);
            this.OrdersPage.TabIndex = 4;
            this.OrdersPage.Text = "Orders";
            this.OrdersPage.UseVisualStyleBackColor = true;
            // 
            // TablesDgv
            // 
            this.TablesDgv.AllowUserToAddRows = false;
            this.TablesDgv.AllowUserToDeleteRows = false;
            this.TablesDgv.AllowUserToResizeRows = false;
            this.TablesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TablesDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.TablesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablesDgv.Location = new System.Drawing.Point(12, 54);
            this.TablesDgv.Name = "TablesDgv";
            this.TablesDgv.ReadOnly = true;
            this.TablesDgv.RowHeadersWidth = 51;
            this.TablesDgv.RowTemplate.Height = 24;
            this.TablesDgv.Size = new System.Drawing.Size(763, 343);
            this.TablesDgv.TabIndex = 7;
            // 
            // RemoveTableButton
            // 
            this.RemoveTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveTableButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemoveTableButton.Depth = 0;
            this.RemoveTableButton.HighEmphasis = true;
            this.RemoveTableButton.Icon = null;
            this.RemoveTableButton.Location = new System.Drawing.Point(702, 8);
            this.RemoveTableButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveTableButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveTableButton.Name = "RemoveTableButton";
            this.RemoveTableButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemoveTableButton.Size = new System.Drawing.Size(73, 36);
            this.RemoveTableButton.TabIndex = 6;
            this.RemoveTableButton.Text = "Delete";
            this.RemoveTableButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveTableButton.UseAccentColor = false;
            this.RemoveTableButton.UseVisualStyleBackColor = true;
            this.RemoveTableButton.Click += new System.EventHandler(this.RemoveTableButton_Click);
            // 
            // AddTableButton
            // 
            this.AddTableButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddTableButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddTableButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddTableButton.Depth = 0;
            this.AddTableButton.HighEmphasis = true;
            this.AddTableButton.Icon = null;
            this.AddTableButton.Location = new System.Drawing.Point(630, 8);
            this.AddTableButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddTableButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddTableButton.Name = "AddTableButton";
            this.AddTableButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddTableButton.Size = new System.Drawing.Size(64, 36);
            this.AddTableButton.TabIndex = 5;
            this.AddTableButton.Text = "Add";
            this.AddTableButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddTableButton.UseAccentColor = false;
            this.AddTableButton.UseVisualStyleBackColor = true;
            this.AddTableButton.Click += new System.EventHandler(this.AddTableButton_Click);
            // 
            // TableUpdateButton
            // 
            this.TableUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TableUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.TableUpdateButton.Depth = 0;
            this.TableUpdateButton.HighEmphasis = true;
            this.TableUpdateButton.Icon = null;
            this.TableUpdateButton.Location = new System.Drawing.Point(12, 8);
            this.TableUpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.TableUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.TableUpdateButton.Name = "TableUpdateButton";
            this.TableUpdateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.TableUpdateButton.Size = new System.Drawing.Size(125, 36);
            this.TableUpdateButton.TabIndex = 4;
            this.TableUpdateButton.Text = "Table update";
            this.TableUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.TableUpdateButton.UseAccentColor = false;
            this.TableUpdateButton.UseVisualStyleBackColor = true;
            this.TableUpdateButton.Click += new System.EventHandler(this.TableUpdateButton_Click);
            // 
            // PaymentTypesDgv
            // 
            this.PaymentTypesDgv.AllowUserToAddRows = false;
            this.PaymentTypesDgv.AllowUserToDeleteRows = false;
            this.PaymentTypesDgv.AllowUserToResizeRows = false;
            this.PaymentTypesDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaymentTypesDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.PaymentTypesDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentTypesDgv.Location = new System.Drawing.Point(12, 54);
            this.PaymentTypesDgv.Name = "PaymentTypesDgv";
            this.PaymentTypesDgv.ReadOnly = true;
            this.PaymentTypesDgv.RowHeadersWidth = 51;
            this.PaymentTypesDgv.RowTemplate.Height = 24;
            this.PaymentTypesDgv.Size = new System.Drawing.Size(763, 343);
            this.PaymentTypesDgv.TabIndex = 11;
            // 
            // RemovePaymentTypeButton
            // 
            this.RemovePaymentTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePaymentTypeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemovePaymentTypeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemovePaymentTypeButton.Depth = 0;
            this.RemovePaymentTypeButton.HighEmphasis = true;
            this.RemovePaymentTypeButton.Icon = null;
            this.RemovePaymentTypeButton.Location = new System.Drawing.Point(702, 8);
            this.RemovePaymentTypeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemovePaymentTypeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemovePaymentTypeButton.Name = "RemovePaymentTypeButton";
            this.RemovePaymentTypeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemovePaymentTypeButton.Size = new System.Drawing.Size(73, 36);
            this.RemovePaymentTypeButton.TabIndex = 10;
            this.RemovePaymentTypeButton.Text = "Delete";
            this.RemovePaymentTypeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemovePaymentTypeButton.UseAccentColor = false;
            this.RemovePaymentTypeButton.UseVisualStyleBackColor = true;
            this.RemovePaymentTypeButton.Click += new System.EventHandler(this.RemovePaymentTypeButton_Click);
            // 
            // AddPaymentTypeButton
            // 
            this.AddPaymentTypeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPaymentTypeButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddPaymentTypeButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddPaymentTypeButton.Depth = 0;
            this.AddPaymentTypeButton.HighEmphasis = true;
            this.AddPaymentTypeButton.Icon = null;
            this.AddPaymentTypeButton.Location = new System.Drawing.Point(630, 8);
            this.AddPaymentTypeButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddPaymentTypeButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddPaymentTypeButton.Name = "AddPaymentTypeButton";
            this.AddPaymentTypeButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddPaymentTypeButton.Size = new System.Drawing.Size(64, 36);
            this.AddPaymentTypeButton.TabIndex = 9;
            this.AddPaymentTypeButton.Text = "Add";
            this.AddPaymentTypeButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddPaymentTypeButton.UseAccentColor = false;
            this.AddPaymentTypeButton.UseVisualStyleBackColor = true;
            this.AddPaymentTypeButton.Click += new System.EventHandler(this.AddPaymentTypeButton_Click);
            // 
            // PaymentTypeUpdateButton
            // 
            this.PaymentTypeUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PaymentTypeUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.PaymentTypeUpdateButton.Depth = 0;
            this.PaymentTypeUpdateButton.HighEmphasis = true;
            this.PaymentTypeUpdateButton.Icon = null;
            this.PaymentTypeUpdateButton.Location = new System.Drawing.Point(12, 8);
            this.PaymentTypeUpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.PaymentTypeUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.PaymentTypeUpdateButton.Name = "PaymentTypeUpdateButton";
            this.PaymentTypeUpdateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.PaymentTypeUpdateButton.Size = new System.Drawing.Size(189, 36);
            this.PaymentTypeUpdateButton.TabIndex = 8;
            this.PaymentTypeUpdateButton.Text = "Payment type update";
            this.PaymentTypeUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.PaymentTypeUpdateButton.UseAccentColor = false;
            this.PaymentTypeUpdateButton.UseVisualStyleBackColor = true;
            this.PaymentTypeUpdateButton.Click += new System.EventHandler(this.PaymentTypeUpdateButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.TabControl);
            this.DrawerTabControl = this.TabControl;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Office";
            this.TabControl.ResumeLayout(false);
            this.WaitersPage.ResumeLayout(false);
            this.WaitersPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitersDgv)).EndInit();
            this.TablesPage.ResumeLayout(false);
            this.TablesPage.PerformLayout();
            this.PaymentTypesPage.ResumeLayout(false);
            this.PaymentTypesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablesDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypesDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage WaitersPage;
        private System.Windows.Forms.TabPage TablesPage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage PaymentTypesPage;
        private System.Windows.Forms.TabPage OrdersPage;
        private MaterialSkin.Controls.MaterialButton UpdateWaitersButton;
        private MaterialSkin.Controls.MaterialButton DeleteWaiterButton;
        private MaterialSkin.Controls.MaterialButton AddWaiterButton;
        private System.Windows.Forms.DataGridView WaitersDgv;
        private System.Windows.Forms.DataGridView TablesDgv;
        private MaterialSkin.Controls.MaterialButton RemoveTableButton;
        private MaterialSkin.Controls.MaterialButton AddTableButton;
        private MaterialSkin.Controls.MaterialButton TableUpdateButton;
        private System.Windows.Forms.DataGridView PaymentTypesDgv;
        private MaterialSkin.Controls.MaterialButton RemovePaymentTypeButton;
        private MaterialSkin.Controls.MaterialButton AddPaymentTypeButton;
        private MaterialSkin.Controls.MaterialButton PaymentTypeUpdateButton;
    }
}

