namespace Software1Project_DakodaWilldenv1
{
    partial class Frm_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Pnl_Parts = new System.Windows.Forms.Panel();
            this.dataGridViewParts = new System.Windows.Forms.DataGridView();
            this.PartId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InventoryLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PricePerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_DeleteParts = new System.Windows.Forms.Button();
            this.Btn_ModifyParts = new System.Windows.Forms.Button();
            this.Btn_AddParts = new System.Windows.Forms.Button();
            this.Btn_SearchParts = new System.Windows.Forms.Button();
            this.Txt_PartsSearch = new System.Windows.Forms.TextBox();
            this.Lbl_Parts = new System.Windows.Forms.Label();
            this.Lbl_InventoryManagmentSystem = new System.Windows.Forms.Label();
            this.Pnl_Products = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridTxt_ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTxt_ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTxt_ProductInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridTxt_ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_DeleteProduct = new System.Windows.Forms.Button();
            this.Btn_ModifyProduct = new System.Windows.Forms.Button();
            this.Btn_AddProduct = new System.Windows.Forms.Button();
            this.Btn_ProductSearch = new System.Windows.Forms.Button();
            this.Txt_ProductSearch = new System.Windows.Forms.TextBox();
            this.Lbl_Products = new System.Windows.Forms.Label();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Pnl_Parts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).BeginInit();
            this.Pnl_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Parts
            // 
            this.Pnl_Parts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Parts.Controls.Add(this.dataGridViewParts);
            this.Pnl_Parts.Controls.Add(this.Btn_DeleteParts);
            this.Pnl_Parts.Controls.Add(this.Btn_ModifyParts);
            this.Pnl_Parts.Controls.Add(this.Btn_AddParts);
            this.Pnl_Parts.Controls.Add(this.Btn_SearchParts);
            this.Pnl_Parts.Controls.Add(this.Txt_PartsSearch);
            this.Pnl_Parts.Controls.Add(this.Lbl_Parts);
            this.Pnl_Parts.Location = new System.Drawing.Point(22, 45);
            this.Pnl_Parts.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Parts.Name = "Pnl_Parts";
            this.Pnl_Parts.Size = new System.Drawing.Size(439, 200);
            this.Pnl_Parts.TabIndex = 0;
            // 
            // dataGridViewParts
            // 
            this.dataGridViewParts.AllowUserToAddRows = false;
            this.dataGridViewParts.AllowUserToDeleteRows = false;
            this.dataGridViewParts.AllowUserToResizeColumns = false;
            this.dataGridViewParts.AllowUserToResizeRows = false;
            this.dataGridViewParts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PartId,
            this.PartName,
            this.InventoryLevel,
            this.PricePerUnit});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewParts.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewParts.Location = new System.Drawing.Point(12, 49);
            this.dataGridViewParts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewParts.MultiSelect = false;
            this.dataGridViewParts.Name = "dataGridViewParts";
            this.dataGridViewParts.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewParts.RowTemplate.Height = 28;
            this.dataGridViewParts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewParts.Size = new System.Drawing.Size(413, 101);
            this.dataGridViewParts.TabIndex = 4;
            // 
            // PartId
            // 
            this.PartId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.PartId.Frozen = true;
            this.PartId.HeaderText = "Part ID";
            this.PartId.Name = "PartId";
            this.PartId.ReadOnly = true;
            this.PartId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PartId.Width = 51;
            // 
            // PartName
            // 
            this.PartName.Frozen = true;
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
            // Btn_DeleteParts
            // 
            this.Btn_DeleteParts.Location = new System.Drawing.Point(241, 165);
            this.Btn_DeleteParts.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DeleteParts.Name = "Btn_DeleteParts";
            this.Btn_DeleteParts.Size = new System.Drawing.Size(50, 20);
            this.Btn_DeleteParts.TabIndex = 7;
            this.Btn_DeleteParts.Text = "Delete";
            this.Btn_DeleteParts.UseVisualStyleBackColor = true;
            this.Btn_DeleteParts.Click += new System.EventHandler(this.Btn_DeleteParts_Click);
            // 
            // Btn_ModifyParts
            // 
            this.Btn_ModifyParts.Location = new System.Drawing.Point(187, 165);
            this.Btn_ModifyParts.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ModifyParts.Name = "Btn_ModifyParts";
            this.Btn_ModifyParts.Size = new System.Drawing.Size(50, 20);
            this.Btn_ModifyParts.TabIndex = 6;
            this.Btn_ModifyParts.Text = "Modify";
            this.Btn_ModifyParts.UseVisualStyleBackColor = true;
            this.Btn_ModifyParts.Click += new System.EventHandler(this.Btn_ModifyParts_Click);
            // 
            // Btn_AddParts
            // 
            this.Btn_AddParts.Location = new System.Drawing.Point(133, 165);
            this.Btn_AddParts.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddParts.Name = "Btn_AddParts";
            this.Btn_AddParts.Size = new System.Drawing.Size(50, 20);
            this.Btn_AddParts.TabIndex = 5;
            this.Btn_AddParts.Text = "Add";
            this.Btn_AddParts.UseVisualStyleBackColor = true;
            this.Btn_AddParts.Click += new System.EventHandler(this.Btn_AddParts_Click);
            // 
            // Btn_SearchParts
            // 
            this.Btn_SearchParts.Location = new System.Drawing.Point(142, 13);
            this.Btn_SearchParts.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_SearchParts.Name = "Btn_SearchParts";
            this.Btn_SearchParts.Size = new System.Drawing.Size(52, 19);
            this.Btn_SearchParts.TabIndex = 2;
            this.Btn_SearchParts.Text = "Search";
            this.Btn_SearchParts.UseVisualStyleBackColor = true;
            this.Btn_SearchParts.Click += new System.EventHandler(this.Btn_SearchParts_Click);
            // 
            // Txt_PartsSearch
            // 
            this.Txt_PartsSearch.AcceptsReturn = true;
            this.Txt_PartsSearch.Location = new System.Drawing.Point(219, 14);
            this.Txt_PartsSearch.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_PartsSearch.Name = "Txt_PartsSearch";
            this.Txt_PartsSearch.Size = new System.Drawing.Size(151, 20);
            this.Txt_PartsSearch.TabIndex = 1;
            this.Txt_PartsSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_PartsSearch_KeyDown);
            // 
            // Lbl_Parts
            // 
            this.Lbl_Parts.AutoSize = true;
            this.Lbl_Parts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Parts.Location = new System.Drawing.Point(11, 14);
            this.Lbl_Parts.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Parts.Name = "Lbl_Parts";
            this.Lbl_Parts.Size = new System.Drawing.Size(36, 13);
            this.Lbl_Parts.TabIndex = 0;
            this.Lbl_Parts.Text = "Parts";
            // 
            // Lbl_InventoryManagmentSystem
            // 
            this.Lbl_InventoryManagmentSystem.AutoSize = true;
            this.Lbl_InventoryManagmentSystem.Location = new System.Drawing.Point(22, 8);
            this.Lbl_InventoryManagmentSystem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_InventoryManagmentSystem.Name = "Lbl_InventoryManagmentSystem";
            this.Lbl_InventoryManagmentSystem.Size = new System.Drawing.Size(153, 13);
            this.Lbl_InventoryManagmentSystem.TabIndex = 1;
            this.Lbl_InventoryManagmentSystem.Text = "Inventory Management System";
            // 
            // Pnl_Products
            // 
            this.Pnl_Products.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_Products.Controls.Add(this.dataGridViewProducts);
            this.Pnl_Products.Controls.Add(this.Btn_DeleteProduct);
            this.Pnl_Products.Controls.Add(this.Btn_ModifyProduct);
            this.Pnl_Products.Controls.Add(this.Btn_AddProduct);
            this.Pnl_Products.Controls.Add(this.Btn_ProductSearch);
            this.Pnl_Products.Controls.Add(this.Txt_ProductSearch);
            this.Pnl_Products.Controls.Add(this.Lbl_Products);
            this.Pnl_Products.Location = new System.Drawing.Point(465, 45);
            this.Pnl_Products.Margin = new System.Windows.Forms.Padding(2);
            this.Pnl_Products.Name = "Pnl_Products";
            this.Pnl_Products.Size = new System.Drawing.Size(446, 200);
            this.Pnl_Products.TabIndex = 2;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AllowUserToResizeColumns = false;
            this.dataGridViewProducts.AllowUserToResizeRows = false;
            this.dataGridViewProducts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridTxt_ProductID,
            this.dataGridTxt_ProductName,
            this.dataGridTxt_ProductInventory,
            this.dataGridTxt_ProductPrice});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewProducts.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewProducts.Location = new System.Drawing.Point(14, 49);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewProducts.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewProducts.Size = new System.Drawing.Size(413, 101);
            this.dataGridViewProducts.TabIndex = 8;
            // 
            // dataGridTxt_ProductID
            // 
            this.dataGridTxt_ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridTxt_ProductID.HeaderText = "Product ID";
            this.dataGridTxt_ProductID.Name = "dataGridTxt_ProductID";
            this.dataGridTxt_ProductID.ReadOnly = true;
            this.dataGridTxt_ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridTxt_ProductID.Width = 77;
            // 
            // dataGridTxt_ProductName
            // 
            this.dataGridTxt_ProductName.HeaderText = "Product Name";
            this.dataGridTxt_ProductName.Name = "dataGridTxt_ProductName";
            this.dataGridTxt_ProductName.ReadOnly = true;
            this.dataGridTxt_ProductName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridTxt_ProductInventory
            // 
            this.dataGridTxt_ProductInventory.HeaderText = "Inventory Level";
            this.dataGridTxt_ProductInventory.Name = "dataGridTxt_ProductInventory";
            this.dataGridTxt_ProductInventory.ReadOnly = true;
            this.dataGridTxt_ProductInventory.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridTxt_ProductPrice
            // 
            this.dataGridTxt_ProductPrice.HeaderText = "Price per Unit";
            this.dataGridTxt_ProductPrice.Name = "dataGridTxt_ProductPrice";
            this.dataGridTxt_ProductPrice.ReadOnly = true;
            this.dataGridTxt_ProductPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Btn_DeleteProduct
            // 
            this.Btn_DeleteProduct.Location = new System.Drawing.Point(252, 165);
            this.Btn_DeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_DeleteProduct.Name = "Btn_DeleteProduct";
            this.Btn_DeleteProduct.Size = new System.Drawing.Size(50, 20);
            this.Btn_DeleteProduct.TabIndex = 7;
            this.Btn_DeleteProduct.Text = "Delete";
            this.Btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.Btn_DeleteProduct.Click += new System.EventHandler(this.Btn_DeleteProduct_Click);
            // 
            // Btn_ModifyProduct
            // 
            this.Btn_ModifyProduct.Location = new System.Drawing.Point(198, 165);
            this.Btn_ModifyProduct.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ModifyProduct.Name = "Btn_ModifyProduct";
            this.Btn_ModifyProduct.Size = new System.Drawing.Size(50, 20);
            this.Btn_ModifyProduct.TabIndex = 6;
            this.Btn_ModifyProduct.Text = "Modify";
            this.Btn_ModifyProduct.UseVisualStyleBackColor = true;
            this.Btn_ModifyProduct.Click += new System.EventHandler(this.Btn_ModifyProduct_Click);
            // 
            // Btn_AddProduct
            // 
            this.Btn_AddProduct.Location = new System.Drawing.Point(144, 165);
            this.Btn_AddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_AddProduct.Name = "Btn_AddProduct";
            this.Btn_AddProduct.Size = new System.Drawing.Size(50, 20);
            this.Btn_AddProduct.TabIndex = 5;
            this.Btn_AddProduct.Text = "Add";
            this.Btn_AddProduct.UseVisualStyleBackColor = true;
            this.Btn_AddProduct.Click += new System.EventHandler(this.Btn_AddProduct_Click);
            // 
            // Btn_ProductSearch
            // 
            this.Btn_ProductSearch.Location = new System.Drawing.Point(142, 13);
            this.Btn_ProductSearch.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ProductSearch.Name = "Btn_ProductSearch";
            this.Btn_ProductSearch.Size = new System.Drawing.Size(52, 19);
            this.Btn_ProductSearch.TabIndex = 2;
            this.Btn_ProductSearch.Text = "Search";
            this.Btn_ProductSearch.UseVisualStyleBackColor = true;
            this.Btn_ProductSearch.Click += new System.EventHandler(this.Btn_ProductSearch_Click);
            // 
            // Txt_ProductSearch
            // 
            this.Txt_ProductSearch.Location = new System.Drawing.Point(219, 14);
            this.Txt_ProductSearch.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_ProductSearch.Name = "Txt_ProductSearch";
            this.Txt_ProductSearch.Size = new System.Drawing.Size(151, 20);
            this.Txt_ProductSearch.TabIndex = 1;
            this.Txt_ProductSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_ProductSearch_KeyDown);
            // 
            // Lbl_Products
            // 
            this.Lbl_Products.AutoSize = true;
            this.Lbl_Products.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Products.Location = new System.Drawing.Point(11, 14);
            this.Lbl_Products.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Products.Name = "Lbl_Products";
            this.Lbl_Products.Size = new System.Drawing.Size(57, 13);
            this.Lbl_Products.TabIndex = 0;
            this.Lbl_Products.Text = "Products";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(871, 259);
            this.Btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(51, 23);
            this.Btn_Exit.TabIndex = 3;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(942, 295);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Pnl_Products);
            this.Controls.Add(this.Lbl_InventoryManagmentSystem);
            this.Controls.Add(this.Pnl_Parts);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_Main";
            this.ShowIcon = false;
            this.Text = "Inventory Management System";
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.Pnl_Parts.ResumeLayout(false);
            this.Pnl_Parts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewParts)).EndInit();
            this.Pnl_Products.ResumeLayout(false);
            this.Pnl_Products.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Pnl_Parts;
        private System.Windows.Forms.Label Lbl_InventoryManagmentSystem;
        private System.Windows.Forms.TextBox Txt_PartsSearch;
        private System.Windows.Forms.Label Lbl_Parts;
        private System.Windows.Forms.Button Btn_SearchParts;
        private System.Windows.Forms.Button Btn_AddParts;
        private System.Windows.Forms.Button Btn_DeleteParts;
        private System.Windows.Forms.Button Btn_ModifyParts;
        private System.Windows.Forms.Panel Pnl_Products;
        private System.Windows.Forms.Button Btn_DeleteProduct;
        private System.Windows.Forms.Button Btn_ModifyProduct;
        private System.Windows.Forms.Button Btn_AddProduct;
        private System.Windows.Forms.Button Btn_ProductSearch;
        private System.Windows.Forms.TextBox Txt_ProductSearch;
        private System.Windows.Forms.Label Lbl_Products;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.DataGridView dataGridViewParts;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTxt_ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTxt_ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTxt_ProductInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridTxt_ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn InventoryLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn PricePerUnit;
    }
}

