namespace _110
{
    partial class SearchForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelWarehousePickupNotification = new Label();
            tblpInputPanel = new TableLayoutPanel();
            LabelLastFetchDate = new Label();
            labelName = new Label();
            labelAmount = new Label();
            labelWeight = new Label();
            dtpInput = new DateTimePicker();
            tbNameInput = new TextBox();
            tbAmountInput = new TextBox();
            tbWeightInput = new TextBox();
            tblpAddCancelConfirm = new TableLayoutPanel();
            btnCancel = new Button();
            btnAdd = new Button();
            btnConfirmAdd = new Button();
            gbProductSearch = new GroupBox();
            btnCheckLastFetchDay = new Button();
            btnConfirmEdit = new Button();
            rtbProductInfo = new RichTextBox();
            labelProducts = new Label();
            btnRemove = new Button();
            cbProducts = new ComboBox();
            btnEdit = new Button();
            label1 = new Label();
            storageServiceBindingSource = new BindingSource(components);
            DateFormatedGrid = new DataGridView();
            ColumnID = new DataGridViewTextBoxColumn();
            ColumnProductName = new DataGridViewTextBoxColumn();
            ColumnLastFetchDate = new DataGridViewTextBoxColumn();
            tblpInputPanel.SuspendLayout();
            tblpAddCancelConfirm.SuspendLayout();
            gbProductSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)storageServiceBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DateFormatedGrid).BeginInit();
            SuspendLayout();
            // 
            // labelWarehousePickupNotification
            // 
            labelWarehousePickupNotification.AutoSize = true;
            labelWarehousePickupNotification.Font = new Font("Segoe UI", 12F);
            labelWarehousePickupNotification.Location = new Point(234, 24);
            labelWarehousePickupNotification.Name = "labelWarehousePickupNotification";
            labelWarehousePickupNotification.Size = new Size(351, 28);
            labelWarehousePickupNotification.TabIndex = 0;
            labelWarehousePickupNotification.Text = "Warehouse Pickup Notification tehtävä";
            // 
            // tblpInputPanel
            // 
            tblpInputPanel.BackColor = Color.CadetBlue;
            tblpInputPanel.ColumnCount = 2;
            tblpInputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 37.10247F));
            tblpInputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 62.8975258F));
            tblpInputPanel.Controls.Add(LabelLastFetchDate, 0, 3);
            tblpInputPanel.Controls.Add(labelName, 0, 0);
            tblpInputPanel.Controls.Add(labelAmount, 0, 2);
            tblpInputPanel.Controls.Add(labelWeight, 0, 1);
            tblpInputPanel.Controls.Add(dtpInput, 1, 3);
            tblpInputPanel.Controls.Add(tbNameInput, 1, 0);
            tblpInputPanel.Controls.Add(tbAmountInput, 1, 2);
            tblpInputPanel.Controls.Add(tbWeightInput, 1, 1);
            tblpInputPanel.Location = new Point(12, 82);
            tblpInputPanel.Name = "tblpInputPanel";
            tblpInputPanel.RowCount = 4;
            tblpInputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpInputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpInputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpInputPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tblpInputPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblpInputPanel.Size = new Size(387, 149);
            tblpInputPanel.TabIndex = 7;
            // 
            // LabelLastFetchDate
            // 
            LabelLastFetchDate.AutoSize = true;
            LabelLastFetchDate.BackColor = Color.CadetBlue;
            LabelLastFetchDate.Dock = DockStyle.Fill;
            LabelLastFetchDate.Font = new Font("Segoe UI", 10F);
            LabelLastFetchDate.Location = new Point(3, 111);
            LabelLastFetchDate.Name = "LabelLastFetchDate";
            LabelLastFetchDate.Size = new Size(137, 38);
            LabelLastFetchDate.TabIndex = 9;
            LabelLastFetchDate.Text = "Last fetch date";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.CadetBlue;
            labelName.Dock = DockStyle.Fill;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.Location = new Point(3, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(137, 37);
            labelName.TabIndex = 3;
            labelName.Text = "Name";
            // 
            // labelAmount
            // 
            labelAmount.AutoSize = true;
            labelAmount.BackColor = Color.CadetBlue;
            labelAmount.Dock = DockStyle.Fill;
            labelAmount.Font = new Font("Segoe UI", 10F);
            labelAmount.Location = new Point(3, 74);
            labelAmount.Name = "labelAmount";
            labelAmount.Size = new Size(137, 37);
            labelAmount.TabIndex = 5;
            labelAmount.Text = "Amount";
            // 
            // labelWeight
            // 
            labelWeight.AutoSize = true;
            labelWeight.BackColor = Color.CadetBlue;
            labelWeight.Dock = DockStyle.Fill;
            labelWeight.Font = new Font("Segoe UI", 10F);
            labelWeight.Location = new Point(3, 37);
            labelWeight.Name = "labelWeight";
            labelWeight.Size = new Size(137, 37);
            labelWeight.TabIndex = 4;
            labelWeight.Text = "Weight (kg)";
            // 
            // dtpInput
            // 
            dtpInput.Enabled = false;
            dtpInput.Format = DateTimePickerFormat.Short;
            dtpInput.Location = new Point(146, 114);
            dtpInput.Name = "dtpInput";
            dtpInput.Size = new Size(238, 27);
            dtpInput.TabIndex = 11;
            // 
            // tbNameInput
            // 
            tbNameInput.Enabled = false;
            tbNameInput.Location = new Point(146, 3);
            tbNameInput.Name = "tbNameInput";
            tbNameInput.PlaceholderText = "Product";
            tbNameInput.Size = new Size(238, 27);
            tbNameInput.TabIndex = 6;
            // 
            // tbAmountInput
            // 
            tbAmountInput.Enabled = false;
            tbAmountInput.Location = new Point(146, 77);
            tbAmountInput.Name = "tbAmountInput";
            tbAmountInput.PlaceholderText = "0";
            tbAmountInput.Size = new Size(238, 27);
            tbAmountInput.TabIndex = 8;
            // 
            // tbWeightInput
            // 
            tbWeightInput.Enabled = false;
            tbWeightInput.Location = new Point(146, 40);
            tbWeightInput.Name = "tbWeightInput";
            tbWeightInput.PlaceholderText = "0,0 kg";
            tbWeightInput.Size = new Size(238, 27);
            tbWeightInput.TabIndex = 7;
            // 
            // tblpAddCancelConfirm
            // 
            tblpAddCancelConfirm.BackColor = Color.CadetBlue;
            tblpAddCancelConfirm.ColumnCount = 1;
            tblpAddCancelConfirm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpAddCancelConfirm.Controls.Add(btnCancel, 0, 1);
            tblpAddCancelConfirm.Controls.Add(btnAdd, 0, 0);
            tblpAddCancelConfirm.Controls.Add(btnConfirmAdd, 0, 2);
            tblpAddCancelConfirm.Location = new Point(405, 82);
            tblpAddCancelConfirm.Name = "tblpAddCancelConfirm";
            tblpAddCancelConfirm.RowCount = 3;
            tblpAddCancelConfirm.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblpAddCancelConfirm.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333359F));
            tblpAddCancelConfirm.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tblpAddCancelConfirm.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblpAddCancelConfirm.Size = new Size(87, 149);
            tblpAddCancelConfirm.TabIndex = 11;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.Font = new Font("Segoe UI", 9F);
            btnCancel.Location = new Point(3, 52);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(81, 29);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9F);
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(81, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnConfirmAdd
            // 
            btnConfirmAdd.Enabled = false;
            btnConfirmAdd.Font = new Font("Segoe UI", 9F);
            btnConfirmAdd.Location = new Point(3, 101);
            btnConfirmAdd.Name = "btnConfirmAdd";
            btnConfirmAdd.Size = new Size(81, 29);
            btnConfirmAdd.TabIndex = 12;
            btnConfirmAdd.Text = "Confirm";
            btnConfirmAdd.UseVisualStyleBackColor = true;
            // 
            // gbProductSearch
            // 
            gbProductSearch.BackColor = Color.CadetBlue;
            gbProductSearch.Controls.Add(btnCheckLastFetchDay);
            gbProductSearch.Controls.Add(btnConfirmEdit);
            gbProductSearch.Controls.Add(rtbProductInfo);
            gbProductSearch.Controls.Add(labelProducts);
            gbProductSearch.Controls.Add(btnRemove);
            gbProductSearch.Controls.Add(cbProducts);
            gbProductSearch.Controls.Add(btnEdit);
            gbProductSearch.FlatStyle = FlatStyle.System;
            gbProductSearch.Location = new Point(12, 237);
            gbProductSearch.Name = "gbProductSearch";
            gbProductSearch.Size = new Size(513, 186);
            gbProductSearch.TabIndex = 14;
            gbProductSearch.TabStop = false;
            // 
            // btnCheckLastFetchDay
            // 
            btnCheckLastFetchDay.Location = new Point(393, 132);
            btnCheckLastFetchDay.Name = "btnCheckLastFetchDay";
            btnCheckLastFetchDay.Size = new Size(108, 39);
            btnCheckLastFetchDay.TabIndex = 13;
            btnCheckLastFetchDay.Text = "Last fetch day";
            btnCheckLastFetchDay.UseVisualStyleBackColor = true;
            // 
            // btnConfirmEdit
            // 
            btnConfirmEdit.Enabled = false;
            btnConfirmEdit.Location = new Point(393, 43);
            btnConfirmEdit.Name = "btnConfirmEdit";
            btnConfirmEdit.Size = new Size(108, 38);
            btnConfirmEdit.TabIndex = 12;
            btnConfirmEdit.Text = "Confirm edit";
            btnConfirmEdit.UseVisualStyleBackColor = true;
            // 
            // rtbProductInfo
            // 
            rtbProductInfo.Location = new Point(11, 45);
            rtbProductInfo.Name = "rtbProductInfo";
            rtbProductInfo.ReadOnly = true;
            rtbProductInfo.Size = new Size(376, 126);
            rtbProductInfo.TabIndex = 11;
            rtbProductInfo.Text = "";
            // 
            // labelProducts
            // 
            labelProducts.AutoSize = true;
            labelProducts.BackColor = Color.CadetBlue;
            labelProducts.Font = new Font("Segoe UI", 10F);
            labelProducts.Location = new Point(3, 9);
            labelProducts.Name = "labelProducts";
            labelProducts.Size = new Size(77, 23);
            labelProducts.TabIndex = 10;
            labelProducts.Text = "Products";
            labelProducts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(393, 87);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(108, 39);
            btnRemove.TabIndex = 2;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = true;
            // 
            // cbProducts
            // 
            cbProducts.Font = new Font("Segoe UI", 10F);
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(82, 6);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(305, 31);
            cbProducts.TabIndex = 8;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(393, 6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 31);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(531, 91);
            label1.Name = "label1";
            label1.Size = new Size(174, 28);
            label1.TabIndex = 16;
            label1.Text = "Next to be fetched";
            // 
            // storageServiceBindingSource
            // 
            storageServiceBindingSource.DataSource = typeof(Model.StorageService);
            // 
            // DateFormatedGrid
            // 
            DateFormatedGrid.AllowUserToAddRows = false;
            DateFormatedGrid.AllowUserToDeleteRows = false;
            DateFormatedGrid.AllowUserToResizeColumns = false;
            DateFormatedGrid.AllowUserToResizeRows = false;
            DateFormatedGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DateFormatedGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DateFormatedGrid.Columns.AddRange(new DataGridViewColumn[] { ColumnID, ColumnProductName, ColumnLastFetchDate });
            DateFormatedGrid.Location = new Point(531, 130);
            DateFormatedGrid.Name = "DateFormatedGrid";
            DateFormatedGrid.ReadOnly = true;
            DateFormatedGrid.RowHeadersVisible = false;
            DateFormatedGrid.RowHeadersWidth = 51;
            DateFormatedGrid.Size = new Size(436, 293);
            DateFormatedGrid.TabIndex = 17;
            // 
            // ColumnID
            // 
            ColumnID.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            ColumnID.HeaderText = "Id";
            ColumnID.MinimumWidth = 6;
            ColumnID.Name = "ColumnID";
            ColumnID.ReadOnly = true;
            ColumnID.Width = 51;
            // 
            // ColumnProductName
            // 
            ColumnProductName.HeaderText = "Product name";
            ColumnProductName.MinimumWidth = 6;
            ColumnProductName.Name = "ColumnProductName";
            ColumnProductName.ReadOnly = true;
            // 
            // ColumnLastFetchDate
            // 
            ColumnLastFetchDate.HeaderText = "Last fetch date";
            ColumnLastFetchDate.MinimumWidth = 6;
            ColumnLastFetchDate.Name = "ColumnLastFetchDate";
            ColumnLastFetchDate.ReadOnly = true;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(979, 450);
            Controls.Add(DateFormatedGrid);
            Controls.Add(label1);
            Controls.Add(gbProductSearch);
            Controls.Add(tblpAddCancelConfirm);
            Controls.Add(tblpInputPanel);
            Controls.Add(labelWarehousePickupNotification);
            Name = "SearchForm";
            Text = "Warehouse pickup notification";
            tblpInputPanel.ResumeLayout(false);
            tblpInputPanel.PerformLayout();
            tblpAddCancelConfirm.ResumeLayout(false);
            gbProductSearch.ResumeLayout(false);
            gbProductSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)storageServiceBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)DateFormatedGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelWarehousePickupNotification;
        private TableLayoutPanel tblpInputPanel;
        private TextBox tbNameInput;
        private TextBox tbAmountInput;
        private TextBox tbWeightInput;
        private TableLayoutPanel tblpAddCancelConfirm;
        private Button btnCancel;
        private Button btnAdd;
        private Button btnConfirmAdd;
        private Label LabelLastFetchDate;
        private Label labelName;
        private Label labelAmount;
        private Label labelWeight;
        private GroupBox gbProductSearch;
        private Button btnConfirmEdit;
        private RichTextBox rtbProductInfo;
        private Label labelProducts;
        private Button btnRemove;
        private ComboBox cbProducts;
        private Button btnEdit;
        private DateTimePicker dtpInput;
        private Button btnCheckLastFetchDay;
        private Label label1;
        private BindingSource storageServiceBindingSource;
        private DataGridView DateFormatedGrid;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnProductName;
        private DataGridViewTextBoxColumn ColumnLastFetchDate;
    }
}
