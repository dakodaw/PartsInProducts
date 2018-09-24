namespace Software1Project_DakodaWilldenv1
{
    partial class Frm_AddProduct
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Lbl_AddProductMain = new System.Windows.Forms.Label();
            this.Lbl_ProductId = new System.Windows.Forms.Label();
            this.Txt_ProductId = new System.Windows.Forms.TextBox();
            this.Txt_ProductNameMain = new System.Windows.Forms.TextBox();
            this.Lbl_ProductNameMain = new System.Windows.Forms.Label();
            this.Txt_ProductInv = new System.Windows.Forms.TextBox();
            this.Lbl_ProductInv = new System.Windows.Forms.Label();
            this.Txt_ProductPrice = new System.Windows.Forms.TextBox();
            this.Lbl_ProductPriceMain = new System.Windows.Forms.Label();
            this.Txt_ProductMax = new System.Windows.Forms.TextBox();
            this.Lbl_ProductMax = new System.Windows.Forms.Label();
            this.Txt_ProductMin = new System.Windows.Forms.TextBox();
            this.Lbl_ProductMin = new System.Windows.Forms.Label();
            this.dataGridViewPartsProduct = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_SearchPartsNProduct = new System.Windows.Forms.Button();
            this.Txt_PartsNProductSearch = new System.Windows.Forms.TextBox();
            this.Btn_AddPartsToProduct = new System.Windows.Forms.Button();
            this.Btn_DeletePartFromProduct = new System.Windows.Forms.Button();
            this.Btn_CancelProduct = new System.Windows.Forms.Button();
            this.Btn_SaveProduct = new System.Windows.Forms.Button();
            this.dataGridViewProductIncludedItems = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartsProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIncludedItems)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_AddProductMain
            // 
            this.Lbl_AddProductMain.AutoSize = true;
            this.Lbl_AddProductMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddProductMain.Location = new System.Drawing.Point(32, 82);
            this.Lbl_AddProductMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AddProductMain.Name = "Lbl_AddProductMain";
            this.Lbl_AddProductMain.Size = new System.Drawing.Size(84, 15);
            this.Lbl_AddProductMain.TabIndex = 0;
            this.Lbl_AddProductMain.Text = "Add Product";
            // 
            // Lbl_ProductId
            // 
            this.Lbl_ProductId.AutoSize = true;
            this.Lbl_ProductId.Location = new System.Drawing.Point(34, 129);
            this.Lbl_ProductId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ProductId.Name = "Lbl_ProductId";
            this.Lbl_ProductId.Size = new System.Drawing.Size(18, 13);
            this.Lbl_ProductId.TabIndex = 1;
            this.Lbl_ProductId.Text = "ID";
            // 
            // Txt_ProductId
            // 
            this.Txt_ProductId.Enabled = false;
            this.Txt_ProductId.Location = new System.Drawing.Point(80, 128);
            this.Txt_ProductId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductId.Name = "Txt_ProductId";
            this.Txt_ProductId.Size = new System.Drawing.Size(104, 20);
            this.Txt_ProductId.TabIndex = 2;
            this.Txt_ProductId.Text = "Auto Gen-Disabled";
            // 
            // Txt_ProductNameMain
            // 
            this.Txt_ProductNameMain.Location = new System.Drawing.Point(80, 149);
            this.Txt_ProductNameMain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductNameMain.Name = "Txt_ProductNameMain";
            this.Txt_ProductNameMain.Size = new System.Drawing.Size(104, 20);
            this.Txt_ProductNameMain.TabIndex = 4;
            this.Txt_ProductNameMain.Text = "Product Name";
            // 
            // Lbl_ProductNameMain
            // 
            this.Lbl_ProductNameMain.AutoSize = true;
            this.Lbl_ProductNameMain.Location = new System.Drawing.Point(34, 151);
            this.Lbl_ProductNameMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ProductNameMain.Name = "Lbl_ProductNameMain";
            this.Lbl_ProductNameMain.Size = new System.Drawing.Size(35, 13);
            this.Lbl_ProductNameMain.TabIndex = 3;
            this.Lbl_ProductNameMain.Text = "Name";
            // 
            // Txt_ProductInv
            // 
            this.Txt_ProductInv.Location = new System.Drawing.Point(80, 171);
            this.Txt_ProductInv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductInv.Name = "Txt_ProductInv";
            this.Txt_ProductInv.Size = new System.Drawing.Size(55, 20);
            this.Txt_ProductInv.TabIndex = 6;
            this.Txt_ProductInv.Text = "Inv";
            // 
            // Lbl_ProductInv
            // 
            this.Lbl_ProductInv.AutoSize = true;
            this.Lbl_ProductInv.Location = new System.Drawing.Point(34, 174);
            this.Lbl_ProductInv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ProductInv.Name = "Lbl_ProductInv";
            this.Lbl_ProductInv.Size = new System.Drawing.Size(22, 13);
            this.Lbl_ProductInv.TabIndex = 5;
            this.Lbl_ProductInv.Text = "Inv";
            // 
            // Txt_ProductPrice
            // 
            this.Txt_ProductPrice.Location = new System.Drawing.Point(80, 195);
            this.Txt_ProductPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductPrice.Name = "Txt_ProductPrice";
            this.Txt_ProductPrice.Size = new System.Drawing.Size(55, 20);
            this.Txt_ProductPrice.TabIndex = 8;
            this.Txt_ProductPrice.Text = "Price";
            // 
            // Lbl_ProductPriceMain
            // 
            this.Lbl_ProductPriceMain.AutoSize = true;
            this.Lbl_ProductPriceMain.Location = new System.Drawing.Point(34, 197);
            this.Lbl_ProductPriceMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ProductPriceMain.Name = "Lbl_ProductPriceMain";
            this.Lbl_ProductPriceMain.Size = new System.Drawing.Size(31, 13);
            this.Lbl_ProductPriceMain.TabIndex = 7;
            this.Lbl_ProductPriceMain.Text = "Price";
            // 
            // Txt_ProductMax
            // 
            this.Txt_ProductMax.Location = new System.Drawing.Point(80, 216);
            this.Txt_ProductMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductMax.Name = "Txt_ProductMax";
            this.Txt_ProductMax.Size = new System.Drawing.Size(55, 20);
            this.Txt_ProductMax.TabIndex = 10;
            this.Txt_ProductMax.Text = "Max";
            // 
            // Lbl_ProductMax
            // 
            this.Lbl_ProductMax.AutoSize = true;
            this.Lbl_ProductMax.Location = new System.Drawing.Point(34, 218);
            this.Lbl_ProductMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ProductMax.Name = "Lbl_ProductMax";
            this.Lbl_ProductMax.Size = new System.Drawing.Size(27, 13);
            this.Lbl_ProductMax.TabIndex = 9;
            this.Lbl_ProductMax.Text = "Max";
            // 
            // Txt_ProductMin
            // 
            this.Txt_ProductMin.Location = new System.Drawing.Point(194, 216);
            this.Txt_ProductMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_ProductMin.Name = "Txt_ProductMin";
            this.Txt_ProductMin.Size = new System.Drawing.Size(55, 20);
            this.Txt_ProductMin.TabIndex = 12;
            this.Txt_ProductMin.Text = "Min";
            // 
            // Lbl_ProductMin
            // 
            this.Lbl_ProductMin.AutoSize = true;
            this.Lbl_ProductMin.Location = new System.Drawing.Point(148, 218);
            this.Lbl_ProductMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ProductMin.Name = "Lbl_ProductMin";
            this.Lbl_ProductMin.Size = new System.Drawing.Size(24, 13);
            this.Lbl_ProductMin.TabIndex = 11;
            this.Lbl_ProductMin.Text = "Min";
            // 
            // dataGridViewPartsProduct
            // 
            this.dataGridViewPartsProduct.AllowUserToAddRows = false;
            this.dataGridViewPartsProduct.AllowUserToDeleteRows = false;
            this.dataGridViewPartsProduct.AllowUserToResizeColumns = false;
            this.dataGridViewPartsProduct.AllowUserToResizeRows = false;
            this.dataGridViewPartsProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPartsProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPartsProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPartsProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.PartName,
            this.InventoryLevel,
            this.PricePerUnit});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPartsProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPartsProduct.Location = new System.Drawing.Point(290, 62);
            this.dataGridViewPartsProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPartsProduct.MultiSelect = false;
            this.dataGridViewPartsProduct.Name = "dataGridViewPartsProduct";
            this.dataGridViewPartsProduct.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPartsProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewPartsProduct.RowTemplate.Height = 28;
            this.dataGridViewPartsProduct.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewPartsProduct.Size = new System.Drawing.Size(413, 101);
            this.dataGridViewPartsProduct.TabIndex = 15;
            // 
            // PartId
            // 
            this.PartId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartId.HeaderText = "Part ID";
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            this.PartId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PartId.Width = 51;
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
            this.Btn_SearchPartsNProduct.Location = new System.Drawing.Point(420, 26);
            this.Btn_SearchPartsNProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_SearchPartsNProduct.Name = "Btn_SearchPartsNProduct";
            this.Btn_SearchPartsNProduct.Size = new System.Drawing.Size(52, 19);
            this.Btn_SearchPartsNProduct.TabIndex = 14;
            this.Btn_SearchPartsNProduct.Text = "Search";
            this.Btn_SearchPartsNProduct.UseVisualStyleBackColor = true;
            this.Btn_SearchPartsNProduct.Click += new System.EventHandler(this.Btn_SearchPartsNProduct_Click);
            // 
            // Txt_PartsNProductSearch
            // 
            this.Txt_PartsNProductSearch.Location = new System.Drawing.Point(497, 27);
            this.Txt_PartsNProductSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartsNProductSearch.Name = "Txt_PartsNProductSearch";
            this.Txt_PartsNProductSearch.Size = new System.Drawing.Size(151, 20);
            this.Txt_PartsNProductSearch.TabIndex = 13;
            this.Txt_PartsNProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_PartsNProductSearch_KeyDown);
            // 
            // Btn_AddPartsToProduct
            // 
            this.Btn_AddPartsToProduct.Location = new System.Drawing.Point(647, 167);
            this.Btn_AddPartsToProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_AddPartsToProduct.Name = "Btn_AddPartsToProduct";
            this.Btn_AddPartsToProduct.Size = new System.Drawing.Size(56, 26);
            this.Btn_AddPartsToProduct.TabIndex = 17;
            this.Btn_AddPartsToProduct.Text = "Add";
            this.Btn_AddPartsToProduct.UseVisualStyleBackColor = true;
            this.Btn_AddPartsToProduct.Click += new System.EventHandler(this.Btn_AddPartsToProduct_Click);
            // 
            // Btn_DeletePartFromProduct
            // 
            this.Btn_DeletePartFromProduct.Location = new System.Drawing.Point(647, 301);
            this.Btn_DeletePartFromProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_DeletePartFromProduct.Name = "Btn_DeletePartFromProduct";
            this.Btn_DeletePartFromProduct.Size = new System.Drawing.Size(56, 26);
            this.Btn_DeletePartFromProduct.TabIndex = 18;
            this.Btn_DeletePartFromProduct.Text = "Delete";
            this.Btn_DeletePartFromProduct.UseVisualStyleBackColor = true;
            this.Btn_DeletePartFromProduct.Click += new System.EventHandler(this.Btn_DeletePartFromProduct_Click);
            // 
            // Btn_CancelProduct
            // 
            this.Btn_CancelProduct.Location = new System.Drawing.Point(647, 332);
            this.Btn_CancelProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_CancelProduct.Name = "Btn_CancelProduct";
            this.Btn_CancelProduct.Size = new System.Drawing.Size(56, 26);
            this.Btn_CancelProduct.TabIndex = 19;
            this.Btn_CancelProduct.Text = "Cancel";
            this.Btn_CancelProduct.UseVisualStyleBackColor = true;
            this.Btn_CancelProduct.Click += new System.EventHandler(this.Btn_CancelProduct_Click);
            // 
            // Btn_SaveProduct
            // 
            this.Btn_SaveProduct.Location = new System.Drawing.Point(586, 332);
            this.Btn_SaveProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_SaveProduct.Name = "Btn_SaveProduct";
            this.Btn_SaveProduct.Size = new System.Drawing.Size(56, 26);
            this.Btn_SaveProduct.TabIndex = 20;
            this.Btn_SaveProduct.Text = "Save";
            this.Btn_SaveProduct.UseVisualStyleBackColor = true;
            this.Btn_SaveProduct.Click += new System.EventHandler(this.Btn_SaveProduct_Click);
            // 
            // dataGridViewProductIncludedItems
            // 
            this.dataGridViewProductIncludedItems.AllowUserToAddRows = false;
            this.dataGridViewProductIncludedItems.AllowUserToDeleteRows = false;
            this.dataGridViewProductIncludedItems.AllowUserToResizeColumns = false;
            this.dataGridViewProductIncludedItems.AllowUserToResizeRows = false;
            this.dataGridViewProductIncludedItems.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductIncludedItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewProductIncludedItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductIncludedItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProductIncludedItems.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewProductIncludedItems.Location = new System.Drawing.Point(290, 195);
            this.dataGridViewProductIncludedItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewProductIncludedItems.MultiSelect = false;
            this.dataGridViewProductIncludedItems.Name = "dataGridViewProductIncludedItems";
            this.dataGridViewProductIncludedItems.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProductIncludedItems.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewProductIncludedItems.RowTemplate.Height = 28;
            this.dataGridViewProductIncludedItems.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProductIncludedItems.Size = new System.Drawing.Size(413, 101);
            this.dataGridViewProductIncludedItems.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "Part ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Width = 51;
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
            // Frm_AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 389);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_AddProduct";
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Frm_AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPartsProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductIncludedItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AddProductMain;
        private System.Windows.Forms.Label Lbl_ProductId;
        private System.Windows.Forms.TextBox Txt_ProductId;
        private System.Windows.Forms.TextBox Txt_ProductNameMain;
        private System.Windows.Forms.Label Lbl_ProductNameMain;
        private System.Windows.Forms.TextBox Txt_ProductInv;
        private System.Windows.Forms.Label Lbl_ProductInv;
        private System.Windows.Forms.TextBox Txt_ProductPrice;
        private System.Windows.Forms.Label Lbl_ProductPriceMain;
        private System.Windows.Forms.TextBox Txt_ProductMax;
        private System.Windows.Forms.Label Lbl_ProductMax;
        private System.Windows.Forms.TextBox Txt_ProductMin;
        private System.Windows.Forms.Label Lbl_ProductMin;
        private System.Windows.Forms.DataGridView dataGridViewPartsProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
        private System.Windows.Forms.Button Btn_SearchPartsNProduct;
        private System.Windows.Forms.TextBox Txt_PartsNProductSearch;
        private System.Windows.Forms.Button Btn_AddPartsToProduct;
        private System.Windows.Forms.Button Btn_DeletePartFromProduct;
        private System.Windows.Forms.Button Btn_CancelProduct;
        private System.Windows.Forms.Button Btn_SaveProduct;
        private System.Windows.Forms.DataGridView dataGridViewProductIncludedItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}