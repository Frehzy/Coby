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
            this.TablesDgv = new System.Windows.Forms.DataGridView();
            this.RemoveTableButton = new MaterialSkin.Controls.MaterialButton();
            this.AddTableButton = new MaterialSkin.Controls.MaterialButton();
            this.TableUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductsPage = new System.Windows.Forms.TabPage();
            this.OpenNomenclature = new MaterialSkin.Controls.MaterialButton();
            this.ProductsDgv = new System.Windows.Forms.DataGridView();
            this.RemoveProductButton = new MaterialSkin.Controls.MaterialButton();
            this.AddProductButton = new MaterialSkin.Controls.MaterialButton();
            this.ProductUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.PaymentTypesPage = new System.Windows.Forms.TabPage();
            this.PaymentTypesDgv = new System.Windows.Forms.DataGridView();
            this.RemovePaymentTypeButton = new MaterialSkin.Controls.MaterialButton();
            this.AddPaymentTypeButton = new MaterialSkin.Controls.MaterialButton();
            this.PaymentTypeUpdateButton = new MaterialSkin.Controls.MaterialButton();
            this.StatPage = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ChartsButton = new MaterialSkin.Controls.MaterialButton();
            this.CloseOrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.OpenOrdersButton = new MaterialSkin.Controls.MaterialButton();
            this.TabControl.SuspendLayout();
            this.WaitersPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitersDgv)).BeginInit();
            this.TablesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablesDgv)).BeginInit();
            this.ProductsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDgv)).BeginInit();
            this.PaymentTypesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypesDgv)).BeginInit();
            this.StatPage.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.WaitersPage);
            this.TabControl.Controls.Add(this.TablesPage);
            this.TabControl.Controls.Add(this.ProductsPage);
            this.TabControl.Controls.Add(this.PaymentTypesPage);
            this.TabControl.Controls.Add(this.StatPage);
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
            this.DeleteWaiterButton.Location = new System.Drawing.Point(697, 10);
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
            this.AddWaiterButton.Location = new System.Drawing.Point(625, 10);
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
            this.UpdateWaitersButton.Location = new System.Drawing.Point(7, 10);
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
            this.RemoveTableButton.Location = new System.Drawing.Point(702, 9);
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
            this.AddTableButton.Location = new System.Drawing.Point(630, 9);
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
            this.TableUpdateButton.Location = new System.Drawing.Point(12, 9);
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
            // ProductsPage
            // 
            this.ProductsPage.Controls.Add(this.OpenNomenclature);
            this.ProductsPage.Controls.Add(this.ProductsDgv);
            this.ProductsPage.Controls.Add(this.RemoveProductButton);
            this.ProductsPage.Controls.Add(this.AddProductButton);
            this.ProductsPage.Controls.Add(this.ProductUpdateButton);
            this.ProductsPage.Location = new System.Drawing.Point(4, 25);
            this.ProductsPage.Name = "ProductsPage";
            this.ProductsPage.Size = new System.Drawing.Size(786, 404);
            this.ProductsPage.TabIndex = 2;
            this.ProductsPage.Text = "Products";
            this.ProductsPage.UseVisualStyleBackColor = true;
            // 
            // OpenNomenclature
            // 
            this.OpenNomenclature.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenNomenclature.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenNomenclature.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenNomenclature.Depth = 0;
            this.OpenNomenclature.HighEmphasis = true;
            this.OpenNomenclature.Icon = null;
            this.OpenNomenclature.Location = new System.Drawing.Point(485, 9);
            this.OpenNomenclature.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenNomenclature.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenNomenclature.Name = "OpenNomenclature";
            this.OpenNomenclature.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenNomenclature.Size = new System.Drawing.Size(137, 36);
            this.OpenNomenclature.TabIndex = 16;
            this.OpenNomenclature.Text = "Nomenclature";
            this.OpenNomenclature.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenNomenclature.UseAccentColor = false;
            this.OpenNomenclature.UseVisualStyleBackColor = true;
            this.OpenNomenclature.Click += new System.EventHandler(this.OpenNomenclature_Click);
            // 
            // ProductsDgv
            // 
            this.ProductsDgv.AllowUserToAddRows = false;
            this.ProductsDgv.AllowUserToDeleteRows = false;
            this.ProductsDgv.AllowUserToResizeRows = false;
            this.ProductsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsDgv.BackgroundColor = System.Drawing.SystemColors.Control;
            this.ProductsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDgv.Location = new System.Drawing.Point(12, 54);
            this.ProductsDgv.Name = "ProductsDgv";
            this.ProductsDgv.ReadOnly = true;
            this.ProductsDgv.RowHeadersWidth = 51;
            this.ProductsDgv.RowTemplate.Height = 24;
            this.ProductsDgv.Size = new System.Drawing.Size(763, 343);
            this.ProductsDgv.TabIndex = 15;
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RemoveProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RemoveProductButton.Depth = 0;
            this.RemoveProductButton.HighEmphasis = true;
            this.RemoveProductButton.Icon = null;
            this.RemoveProductButton.Location = new System.Drawing.Point(702, 8);
            this.RemoveProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RemoveProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RemoveProductButton.Size = new System.Drawing.Size(73, 36);
            this.RemoveProductButton.TabIndex = 14;
            this.RemoveProductButton.Text = "Delete";
            this.RemoveProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RemoveProductButton.UseAccentColor = false;
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddProductButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddProductButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.AddProductButton.Depth = 0;
            this.AddProductButton.HighEmphasis = true;
            this.AddProductButton.Icon = null;
            this.AddProductButton.Location = new System.Drawing.Point(630, 9);
            this.AddProductButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddProductButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.AddProductButton.Size = new System.Drawing.Size(64, 36);
            this.AddProductButton.TabIndex = 13;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddProductButton.UseAccentColor = false;
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // ProductUpdateButton
            // 
            this.ProductUpdateButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ProductUpdateButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ProductUpdateButton.Depth = 0;
            this.ProductUpdateButton.HighEmphasis = true;
            this.ProductUpdateButton.Icon = null;
            this.ProductUpdateButton.Location = new System.Drawing.Point(12, 9);
            this.ProductUpdateButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ProductUpdateButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProductUpdateButton.Name = "ProductUpdateButton";
            this.ProductUpdateButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ProductUpdateButton.Size = new System.Drawing.Size(147, 36);
            this.ProductUpdateButton.TabIndex = 12;
            this.ProductUpdateButton.Text = "Product update";
            this.ProductUpdateButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ProductUpdateButton.UseAccentColor = false;
            this.ProductUpdateButton.UseVisualStyleBackColor = true;
            this.ProductUpdateButton.Click += new System.EventHandler(this.ProductUpdateButton_Click);
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
            this.RemovePaymentTypeButton.Location = new System.Drawing.Point(702, 9);
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
            this.AddPaymentTypeButton.Location = new System.Drawing.Point(630, 9);
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
            this.PaymentTypeUpdateButton.Location = new System.Drawing.Point(12, 9);
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
            // StatPage
            // 
            this.StatPage.Controls.Add(this.tableLayoutPanel1);
            this.StatPage.Location = new System.Drawing.Point(4, 25);
            this.StatPage.Name = "StatPage";
            this.StatPage.Size = new System.Drawing.Size(786, 404);
            this.StatPage.TabIndex = 0;
            this.StatPage.Text = "Statistics";
            this.StatPage.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.ChartsButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CloseOrdersButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.OpenOrdersButton, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(786, 404);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ChartsButton
            // 
            this.ChartsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ChartsButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.ChartsButton.Depth = 0;
            this.ChartsButton.HighEmphasis = true;
            this.ChartsButton.Icon = null;
            this.ChartsButton.Location = new System.Drawing.Point(200, 6);
            this.ChartsButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.ChartsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ChartsButton.Name = "ChartsButton";
            this.ChartsButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.ChartsButton.Size = new System.Drawing.Size(78, 36);
            this.ChartsButton.TabIndex = 10;
            this.ChartsButton.Text = "Charts";
            this.ChartsButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.ChartsButton.UseAccentColor = false;
            this.ChartsButton.UseVisualStyleBackColor = true;
            // 
            // CloseOrdersButton
            // 
            this.CloseOrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CloseOrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.CloseOrdersButton.Depth = 0;
            this.CloseOrdersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CloseOrdersButton.HighEmphasis = true;
            this.CloseOrdersButton.Icon = null;
            this.CloseOrdersButton.Location = new System.Drawing.Point(4, 107);
            this.CloseOrdersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.CloseOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.CloseOrdersButton.Name = "CloseOrdersButton";
            this.CloseOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.CloseOrdersButton.Size = new System.Drawing.Size(188, 89);
            this.CloseOrdersButton.TabIndex = 9;
            this.CloseOrdersButton.Text = "Close orders";
            this.CloseOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.CloseOrdersButton.UseAccentColor = false;
            this.CloseOrdersButton.UseVisualStyleBackColor = true;
            this.CloseOrdersButton.Click += new System.EventHandler(this.CloseOrdersButton_Click);
            // 
            // OpenOrdersButton
            // 
            this.OpenOrdersButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OpenOrdersButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.OpenOrdersButton.Depth = 0;
            this.OpenOrdersButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OpenOrdersButton.HighEmphasis = true;
            this.OpenOrdersButton.Icon = null;
            this.OpenOrdersButton.Location = new System.Drawing.Point(4, 6);
            this.OpenOrdersButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OpenOrdersButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.OpenOrdersButton.Name = "OpenOrdersButton";
            this.OpenOrdersButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.OpenOrdersButton.Size = new System.Drawing.Size(188, 89);
            this.OpenOrdersButton.TabIndex = 11;
            this.OpenOrdersButton.Text = "Open orders";
            this.OpenOrdersButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.OpenOrdersButton.UseAccentColor = false;
            this.OpenOrdersButton.UseVisualStyleBackColor = true;
            this.OpenOrdersButton.Click += new System.EventHandler(this.CurrentSessionButton_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.TablesDgv)).EndInit();
            this.ProductsPage.ResumeLayout(false);
            this.ProductsPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDgv)).EndInit();
            this.PaymentTypesPage.ResumeLayout(false);
            this.PaymentTypesPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentTypesDgv)).EndInit();
            this.StatPage.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage WaitersPage;
        private System.Windows.Forms.TabPage TablesPage;
        private System.Windows.Forms.TabPage ProductsPage;
        private System.Windows.Forms.TabPage PaymentTypesPage;
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
        private System.Windows.Forms.DataGridView ProductsDgv;
        private MaterialSkin.Controls.MaterialButton RemoveProductButton;
        private MaterialSkin.Controls.MaterialButton AddProductButton;
        private MaterialSkin.Controls.MaterialButton ProductUpdateButton;
        private MaterialSkin.Controls.MaterialButton OpenNomenclature;
        private System.Windows.Forms.TabPage StatPage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialButton CloseOrdersButton;
        private MaterialSkin.Controls.MaterialButton ChartsButton;
        private MaterialSkin.Controls.MaterialButton OpenOrdersButton;
    }
}

