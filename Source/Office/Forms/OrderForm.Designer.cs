namespace Office.Forms
{
    partial class OrderForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.WaiterInfoDgv = new System.Windows.Forms.DataGridView();
            this.TableInfoDgv = new System.Windows.Forms.DataGridView();
            this.PaymentInfoDgv = new System.Windows.Forms.DataGridView();
            this.OrderInfoDgv = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SumTextBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaiterInfoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableInfoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentInfoDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoDgv)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(916, 520);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.PaymentInfoDgv, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.TableInfoDgv, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.OrderInfoDgv, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.WaiterInfoDgv, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(360, 514);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // WaiterInfoDgv
            // 
            this.WaiterInfoDgv.AllowUserToAddRows = false;
            this.WaiterInfoDgv.AllowUserToDeleteRows = false;
            this.WaiterInfoDgv.AllowUserToResizeColumns = false;
            this.WaiterInfoDgv.AllowUserToResizeRows = false;
            this.WaiterInfoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WaiterInfoDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WaiterInfoDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WaiterInfoDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WaiterInfoDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.WaiterInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WaiterInfoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WaiterInfoDgv.EnableHeadersVisualStyles = false;
            this.WaiterInfoDgv.Location = new System.Drawing.Point(3, 258);
            this.WaiterInfoDgv.MultiSelect = false;
            this.WaiterInfoDgv.Name = "WaiterInfoDgv";
            this.WaiterInfoDgv.ReadOnly = true;
            this.WaiterInfoDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.WaiterInfoDgv.RowHeadersVisible = false;
            this.WaiterInfoDgv.RowHeadersWidth = 51;
            this.WaiterInfoDgv.RowTemplate.Height = 24;
            this.WaiterInfoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WaiterInfoDgv.Size = new System.Drawing.Size(354, 63);
            this.WaiterInfoDgv.TabIndex = 4;
            // 
            // TableInfoDgv
            // 
            this.TableInfoDgv.AllowUserToAddRows = false;
            this.TableInfoDgv.AllowUserToDeleteRows = false;
            this.TableInfoDgv.AllowUserToResizeColumns = false;
            this.TableInfoDgv.AllowUserToResizeRows = false;
            this.TableInfoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableInfoDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TableInfoDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TableInfoDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TableInfoDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TableInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableInfoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableInfoDgv.EnableHeadersVisualStyles = false;
            this.TableInfoDgv.Location = new System.Drawing.Point(3, 327);
            this.TableInfoDgv.MultiSelect = false;
            this.TableInfoDgv.Name = "TableInfoDgv";
            this.TableInfoDgv.ReadOnly = true;
            this.TableInfoDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TableInfoDgv.RowHeadersVisible = false;
            this.TableInfoDgv.RowHeadersWidth = 51;
            this.TableInfoDgv.RowTemplate.Height = 24;
            this.TableInfoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TableInfoDgv.Size = new System.Drawing.Size(354, 63);
            this.TableInfoDgv.TabIndex = 5;
            // 
            // PaymentInfoDgv
            // 
            this.PaymentInfoDgv.AllowUserToAddRows = false;
            this.PaymentInfoDgv.AllowUserToDeleteRows = false;
            this.PaymentInfoDgv.AllowUserToResizeColumns = false;
            this.PaymentInfoDgv.AllowUserToResizeRows = false;
            this.PaymentInfoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PaymentInfoDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PaymentInfoDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PaymentInfoDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PaymentInfoDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PaymentInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentInfoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentInfoDgv.EnableHeadersVisualStyles = false;
            this.PaymentInfoDgv.Location = new System.Drawing.Point(3, 396);
            this.PaymentInfoDgv.MultiSelect = false;
            this.PaymentInfoDgv.Name = "PaymentInfoDgv";
            this.PaymentInfoDgv.ReadOnly = true;
            this.PaymentInfoDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PaymentInfoDgv.RowHeadersVisible = false;
            this.PaymentInfoDgv.RowHeadersWidth = 51;
            this.PaymentInfoDgv.RowTemplate.Height = 24;
            this.PaymentInfoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PaymentInfoDgv.Size = new System.Drawing.Size(354, 63);
            this.PaymentInfoDgv.TabIndex = 6;
            // 
            // OrderInfoDgv
            // 
            this.OrderInfoDgv.AllowUserToAddRows = false;
            this.OrderInfoDgv.AllowUserToDeleteRows = false;
            this.OrderInfoDgv.AllowUserToResizeColumns = false;
            this.OrderInfoDgv.AllowUserToResizeRows = false;
            this.OrderInfoDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrderInfoDgv.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrderInfoDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrderInfoDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.OrderInfoDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderInfoDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderInfoDgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderInfoDgv.EnableHeadersVisualStyles = false;
            this.OrderInfoDgv.Location = new System.Drawing.Point(3, 3);
            this.OrderInfoDgv.MultiSelect = false;
            this.OrderInfoDgv.Name = "OrderInfoDgv";
            this.OrderInfoDgv.ReadOnly = true;
            this.OrderInfoDgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.OrderInfoDgv.RowHeadersVisible = false;
            this.OrderInfoDgv.RowHeadersWidth = 51;
            this.OrderInfoDgv.RowTemplate.Height = 24;
            this.OrderInfoDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderInfoDgv.Size = new System.Drawing.Size(354, 249);
            this.OrderInfoDgv.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.SumTextBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 465);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(354, 46);
            this.panel4.TabIndex = 5;
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
            this.SumTextBox.Location = new System.Drawing.Point(0, 0);
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
            this.SumTextBox.Size = new System.Drawing.Size(354, 48);
            this.SumTextBox.TabIndex = 1;
            this.SumTextBox.TabStop = false;
            this.SumTextBox.Text = "Sum";
            this.SumTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SumTextBox.TrailingIcon = null;
            this.SumTextBox.UseAccent = false;
            this.SumTextBox.UseSystemPasswordChar = false;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "OrderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WaiterInfoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableInfoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentInfoDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderInfoDgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView TableInfoDgv;
        private System.Windows.Forms.DataGridView WaiterInfoDgv;
        private System.Windows.Forms.DataGridView PaymentInfoDgv;
        private System.Windows.Forms.DataGridView OrderInfoDgv;
        private System.Windows.Forms.Panel panel4;
        private MaterialSkin.Controls.MaterialTextBox2 SumTextBox;
    }
}