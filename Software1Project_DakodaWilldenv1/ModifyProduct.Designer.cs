namespace Software1Project_DakodaWilldenv1
{
    partial class Frm_ModifyProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle41 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle42 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewProductIncludedItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_SaveProduct = new System.Windows.Forms.Button();
            this.Btn_CancelProduct = new System.Windows.Forms.Button();
            this.Btn_DeletePartFromProduct = new System.Windows.Forms.Button();
            this.Btn_AddPartsToProduct = new System.Windows.Forms.Button();
            this.dataGridViewPartsProduct = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_SearchPartsNProduct = new System.Windows.Forms.Button();
            this.Txt_PartsNProductSearch = new System.Windows.Forms.TextBox();
            this.Txt_ProductMin = new System.Windows.Forms.TextBox();
            this.Lbl_ProductMin = new System.Windows.Forms.Label();
            this.Txt_ProductMax = new System.Windows.Forms.TextBox();
            this.Lbl_ProductMax = new System.Windows.Forms.Label();
            this.Txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.Lbl_ProductPriceMain = new System.Windows.Forms.Label();
            this.Txt_ProductInv = new System.Windows.Forms.TextBox();
            this.Lbl_ProductInv = new System.Windows.Forms.Label();
            this.Txt_ProductNameMain = new System.Windows.Forms.TextBox();
            this.Lbl_ProductNameMain = new System.Windows.Forms.Label();
            this.Txt_ProductId = new System.Windows.Forms.TextBox();
            this.Lbl_ProductId = new System.Windows.Forms.Label();
            this.Lbl_AddProductMain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIncludedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartsProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProductIncludedItems
            // 
            this.dataGridViewProductIncludedItems.AllowUserToAddRows = false;
            this.dataGridViewProductIncludedItems.AllowUserToDeleteRows = false;
            this.dataGridViewProductIncludedItems.AllowUserToResizeColumns = false;
            this.dataGridViewProductIncludedItems.AllowUserToResizeRows = false;
            this.dataGridViewProductIncludedItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle37.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle37.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle37.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle37.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle37.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle37.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductIncludedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle37;
            this.dataGridViewProductIncludedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductIncludedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle38.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle38.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle38.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle38.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle38.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductIncludedItems.DefaultCellStyle = dataGridViewCellStyle38;
            this.dataGridViewProductIncludedItems.Location = new System.Drawing.Point(386, 237);
            this.dataGridViewProductIncludedItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProductIncludedItems.MultiSelect = false;
            this.dataGridViewProductIncludedItems.Name = "dataGridViewProductIncludedItems";
            this.dataGridViewProductIncludedItems.ReadOnly = true;
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle39.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle39.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductIncludedItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle39;
            this.dataGridViewProductIncludedItems.RowTemplate.Height = 28;
            this.dataGridViewProductIncludedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProductIncludedItems.Size = new System.Drawing.Size(551, 124);
            this.dataGridViewProductIncludedItems.TabIndex = 42;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 63;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Inventory Level";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Price/Cost per Unit";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Btn_SaveProduct
            // 
            this.Btn_SaveProduct.Location = new System.Drawing.Point(780, 406);
            this.Btn_SaveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SaveProduct.Name = "Btn_SaveProduct";
            this.Btn_SaveProduct.Size = new System.Drawing.Size(75, 32);
            this.Btn_SaveProduct.TabIndex = 41;
            this.Btn_SaveProduct.Text = "Save";
            this.Btn_SaveProduct.UseVisualStyleBackColor = true;
            this.Btn_SaveProduct.Click += new System.EventHandler(this.Btn_SaveProduct_Click_1);
            // 
            // Btn_CancelProduct
            // 
            this.Btn_CancelProduct.Location = new System.Drawing.Point(862, 406);
            this.Btn_CancelProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_CancelProduct.Name = "Btn_CancelProduct";
            this.Btn_CancelProduct.Size = new System.Drawing.Size(75, 32);
            this.Btn_CancelProduct.TabIndex = 40;
            this.Btn_CancelProduct.Text = "Cancel";
            this.Btn_CancelProduct.UseVisualStyleBackColor = true;
            this.Btn_CancelProduct.Click += new System.EventHandler(this.Btn_CancelProduct_Click_1);
            // 
            // Btn_DeletePartFromProduct
            // 
            this.Btn_DeletePartFromProduct.Location = new System.Drawing.Point(862, 367);
            this.Btn_DeletePartFromProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_DeletePartFromProduct.Name = "Btn_DeletePartFromProduct";
            this.Btn_DeletePartFromProduct.Size = new System.Drawing.Size(75, 32);
            this.Btn_DeletePartFromProduct.TabIndex = 39;
            this.Btn_DeletePartFromProduct.Text = "Delete";
            this.Btn_DeletePartFromProduct.UseVisualStyleBackColor = true;
            this.Btn_DeletePartFromProduct.Click += new System.EventHandler(this.Btn_DeletePartFromProduct_Click_1);
            // 
            // Btn_AddPartsToProduct
            // 
            this.Btn_AddPartsToProduct.Location = new System.Drawing.Point(862, 203);
            this.Btn_AddPartsToProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_AddPartsToProduct.Name = "Btn_AddPartsToProduct";
            this.Btn_AddPartsToProduct.Size = new System.Drawing.Size(75, 32);
            this.Btn_AddPartsToProduct.TabIndex = 38;
            this.Btn_AddPartsToProduct.Text = "Add";
            this.Btn_AddPartsToProduct.UseVisualStyleBackColor = true;
            this.Btn_AddPartsToProduct.Click += new System.EventHandler(this.Btn_AddPartsToProduct_Click_1);
            // 
            // dataGridViewPartsProduct
            // 
            this.dataGridViewPartsProduct.AllowUserToAddRows = false;
            this.dataGridViewPartsProduct.AllowUserToDeleteRows = false;
            this.dataGridViewPartsProduct.AllowUserToResizeColumns = false;
            this.dataGridViewPartsProduct.AllowUserToResizeRows = false;
            this.dataGridViewPartsProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPartsProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dataGridViewPartsProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartsProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.PartName,
            this.InventoryLevel,
            this.PricePerUnit});
            dataGridViewCellStyle41.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle41.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle41.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle41.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle41.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle41.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPartsProduct.DefaultCellStyle = dataGridViewCellStyle41;
            this.dataGridViewPartsProduct.Location = new System.Drawing.Point(386, 73);
            this.dataGridViewPartsProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewPartsProduct.MultiSelect = false;
            this.dataGridViewPartsProduct.Name = "dataGridViewPartsProduct";
            this.dataGridViewPartsProduct.ReadOnly = true;
            dataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle42.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle42.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle42.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPartsProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle42;
            this.dataGridViewPartsProduct.RowTemplate.Height = 28;
            this.dataGridViewPartsProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPartsProduct.Size = new System.Drawing.Size(551, 124);
            this.dataGridViewPartsProduct.TabIndex = 37;
            // 
            // PartId
            // 
            this.PartId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartId.HeaderText = "Part ID";
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            this.PartId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PartId.Width = 63;
            // 
            // PartName
            // 
            this.PartName.HeaderText = "Part Name";
            this.PartName.Name = "PartName";
            this.PartName.ReadOnly = true;
            this.PartName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // InventoryLevel
            // 
            this.InventoryLevel.HeaderText = "Inventory Level";
            this.InventoryLevel.Name = "InventoryLevel";
            this.InventoryLevel.ReadOnly = true;
            this.InventoryLevel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PricePerUnit
            // 
            this.PricePerUnit.HeaderText = "Price/Cost per Unit";
            this.PricePerUnit.Name = "PricePerUnit";
            this.PricePerUnit.ReadOnly = true;
            this.PricePerUnit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Btn_SearchPartsNProduct
            // 
            this.Btn_SearchPartsNProduct.Location = new System.Drawing.Point(559, 29);
            this.Btn_SearchPartsNProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_SearchPartsNProduct.Name = "Btn_SearchPartsNProduct";
            this.Btn_SearchPartsNProduct.Size = new System.Drawing.Size(69, 23);
            this.Btn_SearchPartsNProduct.TabIndex = 36;
            this.Btn_SearchPartsNProduct.Text = "Search";
            this.Btn_SearchPartsNProduct.UseVisualStyleBackColor = true;
            this.Btn_SearchPartsNProduct.Click += new System.EventHandler(this.Btn_SearchPartsNProduct_Click_1);
            // 
            // Txt_PartsNProductSearch
            // 
            this.Txt_PartsNProductSearch.Location = new System.Drawing.Point(662, 30);
            this.Txt_PartsNProductSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_PartsNProductSearch.Name = "Txt_PartsNProductSearch";
            this.Txt_PartsNProductSearch.Size = new System.Drawing.Size(200, 22);
            this.Txt_PartsNProductSearch.TabIndex = 35;
            // 
            // Txt_ProductMin
            // 
            this.Txt_ProductMin.Location = new System.Drawing.Point(258, 263);
            this.Txt_ProductMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductMin.Name = "Txt_ProductMin";
            this.Txt_ProductMin.Size = new System.Drawing.Size(72, 22);
            this.Txt_ProductMin.TabIndex = 34;
            this.Txt_ProductMin.Text = "Min";
            // 
            // Lbl_ProductMin
            // 
            this.Lbl_ProductMin.AutoSize = true;
            this.Lbl_ProductMin.Location = new System.Drawing.Point(196, 265);
            this.Lbl_ProductMin.Name = "Lbl_ProductMin";
            this.Lbl_ProductMin.Size = new System.Drawing.Size(30, 17);
            this.Lbl_ProductMin.TabIndex = 33;
            this.Lbl_ProductMin.Text = "Min";
            // 
            // Txt_ProductMax
            // 
            this.Txt_ProductMax.Location = new System.Drawing.Point(106, 263);
            this.Txt_ProductMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductMax.Name = "Txt_ProductMax";
            this.Txt_ProductMax.Size = new System.Drawing.Size(72, 22);
            this.Txt_ProductMax.TabIndex = 32;
            this.Txt_ProductMax.Text = "Max";
            // 
            // Lbl_ProductMax
            // 
            this.Lbl_ProductMax.AutoSize = true;
            this.Lbl_ProductMax.Location = new System.Drawing.Point(44, 265);
            this.Lbl_ProductMax.Name = "Lbl_ProductMax";
            this.Lbl_ProductMax.Size = new System.Drawing.Size(33, 17);
            this.Lbl_ProductMax.TabIndex = 31;
            this.Lbl_ProductMax.Text = "Max";
            // 
            // Txt_ProductPrice
            // 
            this.Txt_ProductPrice.Location = new System.Drawing.Point(106, 237);
            this.Txt_ProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductPrice.Name = "Txt_ProductPrice";
            this.Txt_ProductPrice.Size = new System.Drawing.Size(72, 22);
            this.Txt_ProductPrice.TabIndex = 30;
            this.Txt_ProductPrice.Text = "Price";
            // 
            // Lbl_ProductPriceMain
            // 
            this.Lbl_ProductPriceMain.AutoSize = true;
            this.Lbl_ProductPriceMain.Location = new System.Drawing.Point(44, 239);
            this.Lbl_ProductPriceMain.Name = "Lbl_ProductPriceMain";
            this.Lbl_ProductPriceMain.Size = new System.Drawing.Size(40, 17);
            this.Lbl_ProductPriceMain.TabIndex = 29;
            this.Lbl_ProductPriceMain.Text = "Price";
            // 
            // Txt_ProductInv
            // 
            this.Txt_ProductInv.Location = new System.Drawing.Point(106, 207);
            this.Txt_ProductInv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductInv.Name = "Txt_ProductInv";
            this.Txt_ProductInv.Size = new System.Drawing.Size(72, 22);
            this.Txt_ProductInv.TabIndex = 28;
            this.Txt_ProductInv.Text = "Inv";
            // 
            // Lbl_ProductInv
            // 
            this.Lbl_ProductInv.AutoSize = true;
            this.Lbl_ProductInv.Location = new System.Drawing.Point(44, 211);
            this.Lbl_ProductInv.Name = "Lbl_ProductInv";
            this.Lbl_ProductInv.Size = new System.Drawing.Size(26, 17);
            this.Lbl_ProductInv.TabIndex = 27;
            this.Lbl_ProductInv.Text = "Inv";
            // 
            // Txt_ProductNameMain
            // 
            this.Txt_ProductNameMain.Location = new System.Drawing.Point(106, 180);
            this.Txt_ProductNameMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductNameMain.Name = "Txt_ProductNameMain";
            this.Txt_ProductNameMain.Size = new System.Drawing.Size(137, 22);
            this.Txt_ProductNameMain.TabIndex = 26;
            this.Txt_ProductNameMain.Text = "Product Name";
            // 
            // Lbl_ProductNameMain
            // 
            this.Lbl_ProductNameMain.AutoSize = true;
            this.Lbl_ProductNameMain.Location = new System.Drawing.Point(44, 183);
            this.Lbl_ProductNameMain.Name = "Lbl_ProductNameMain";
            this.Lbl_ProductNameMain.Size = new System.Drawing.Size(45, 17);
            this.Lbl_ProductNameMain.TabIndex = 25;
            this.Lbl_ProductNameMain.Text = "Name";
            // 
            // Txt_ProductId
            // 
            this.Txt_ProductId.Enabled = false;
            this.Txt_ProductId.Location = new System.Drawing.Point(106, 155);
            this.Txt_ProductId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_ProductId.Name = "Txt_ProductId";
            this.Txt_ProductId.Size = new System.Drawing.Size(137, 22);
            this.Txt_ProductId.TabIndex = 24;
            this.Txt_ProductId.Text = "Auto Gen-Disabled";
            // 
            // Lbl_ProductId
            // 
            this.Lbl_ProductId.AutoSize = true;
            this.Lbl_ProductId.Location = new System.Drawing.Point(44, 156);
            this.Lbl_ProductId.Name = "Lbl_ProductId";
            this.Lbl_ProductId.Size = new System.Drawing.Size(21, 17);
            this.Lbl_ProductId.TabIndex = 23;
            this.Lbl_ProductId.Text = "ID";
            // 
            // Lbl_AddProductMain
            // 
            this.Lbl_AddProductMain.AutoSize = true;
            this.Lbl_AddProductMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddProductMain.Location = new System.Drawing.Point(42, 98);
            this.Lbl_AddProductMain.Name = "Lbl_AddProductMain";
            this.Lbl_AddProductMain.Size = new System.Drawing.Size(122, 18);
            this.Lbl_AddProductMain.TabIndex = 22;
            this.Lbl_AddProductMain.Text = "Modify Product";
            // 
            // Frm_ModifyProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 479);
            this.Controls.Add(this.dataGridViewProductIncludedItems);
            this.Controls.Add(this.Btn_SaveProduct);
            this.Controls.Add(this.Btn_CancelProduct);
            this.Controls.Add(this.Btn_DeletePartFromProduct);
            this.Controls.Add(this.Btn_AddPartsToProduct);
            this.Controls.Add(this.dataGridViewPartsProduct);
            this.Controls.Add(this.Btn_SearchPartsNProduct);
            this.Controls.Add(this.Txt_PartsNProductSearch);
            this.Controls.Add(this.Txt_ProductMin);
            this.Controls.Add(this.Lbl_ProductMin);
            this.Controls.Add(this.Txt_ProductMax);
            this.Controls.Add(this.Lbl_ProductMax);
            this.Controls.Add(this.Txt_ProductPrice);
            this.Controls.Add(this.Lbl_ProductPriceMain);
            this.Controls.Add(this.Txt_ProductInv);
            this.Controls.Add(this.Lbl_ProductInv);
            this.Controls.Add(this.Txt_ProductNameMain);
            this.Controls.Add(this.Lbl_ProductNameMain);
            this.Controls.Add(this.Txt_ProductId);
            this.Controls.Add(this.Lbl_ProductId);
            this.Controls.Add(this.Lbl_AddProductMain);
            this.Name = "Frm_ModifyProduct";
            this.Text = "Modify Product";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIncludedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartsProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProductIncludedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button Btn_SaveProduct;
        private System.Windows.Forms.Button Btn_CancelProduct;
        private System.Windows.Forms.Button Btn_DeletePartFromProduct;
        private System.Windows.Forms.Button Btn_AddPartsToProduct;
        private System.Windows.Forms.DataGridView dataGridViewPartsProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.Button Btn_SearchPartsNProduct;
        private System.Windows.Forms.TextBox Txt_PartsNProductSearch;
        private System.Windows.Forms.TextBox Txt_ProductMin;
        private System.Windows.Forms.Label Lbl_ProductMin;
        private System.Windows.Forms.TextBox Txt_ProductMax;
        private System.Windows.Forms.Label Lbl_ProductMax;
        private System.Windows.Forms.TextBox Txt_ProductPrice;
        private System.Windows.Forms.Label Lbl_ProductPriceMain;
        private System.Windows.Forms.TextBox Txt_ProductInv;
        private System.Windows.Forms.Label Lbl_ProductInv;
        private System.Windows.Forms.TextBox Txt_ProductNameMain;
        private System.Windows.Forms.Label Lbl_ProductNameMain;
        private System.Windows.Forms.TextBox Txt_ProductId;
        private System.Windows.Forms.Label Lbl_ProductId;
        private System.Windows.Forms.Label Lbl_AddProductMain;
    }
}