namespace Software1Project_DakodaWilldenv1
{
    partial class Frm_AddPart
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
            this.Lbl_AddPartMain = new System.Windows.Forms.Label();
            this.RBtn_InHouse = new System.Windows.Forms.RadioButton();
            this.RBtn_Outsourced = new System.Windows.Forms.RadioButton();
            this.Txt_PartId = new System.Windows.Forms.TextBox();
            this.Lbl_PartId = new System.Windows.Forms.Label();
            this.Lbl_PartName = new System.Windows.Forms.Label();
            this.Txt_PartName = new System.Windows.Forms.TextBox();
            this.Lbl_PartInv = new System.Windows.Forms.Label();
            this.Txt_PartInv = new System.Windows.Forms.TextBox();
            this.Lbl_PartPrice = new System.Windows.Forms.Label();
            this.Txt_PartPrice = new System.Windows.Forms.TextBox();
            this.Lbl_PartMax = new System.Windows.Forms.Label();
            this.Txt_PartMax = new System.Windows.Forms.TextBox();
            this.Lbl_PartsCompanyName = new System.Windows.Forms.Label();
            this.Txt_PartsCompanyName = new System.Windows.Forms.TextBox();
            this.Lbl_PartMin = new System.Windows.Forms.Label();
            this.Txt_PartMin = new System.Windows.Forms.TextBox();
            this.Btn_AddPartSave = new System.Windows.Forms.Button();
            this.Btn_PartAddCancel = new System.Windows.Forms.Button();
            this.Lbl_PartsMachineID = new System.Windows.Forms.Label();
            this.Txt_PartsMachineID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Lbl_AddPartMain
            // 
            this.Lbl_AddPartMain.AutoSize = true;
            this.Lbl_AddPartMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddPartMain.Location = new System.Drawing.Point(8, 8);
            this.Lbl_AddPartMain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_AddPartMain.Name = "Lbl_AddPartMain";
            this.Lbl_AddPartMain.Size = new System.Drawing.Size(61, 15);
            this.Lbl_AddPartMain.TabIndex = 0;
            this.Lbl_AddPartMain.Text = "Add Part";
            // 
            // RBtn_InHouse
            // 
            this.RBtn_InHouse.AutoSize = true;
            this.RBtn_InHouse.Location = new System.Drawing.Point(107, 8);
            this.RBtn_InHouse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBtn_InHouse.Name = "RBtn_InHouse";
            this.RBtn_InHouse.Size = new System.Drawing.Size(68, 17);
            this.RBtn_InHouse.TabIndex = 1;
            this.RBtn_InHouse.TabStop = true;
            this.RBtn_InHouse.Text = "In-House";
            this.RBtn_InHouse.UseVisualStyleBackColor = true;
            this.RBtn_InHouse.CheckedChanged += new System.EventHandler(this.RBtn_InHouse_CheckedChanged);
            // 
            // RBtn_Outsourced
            // 
            this.RBtn_Outsourced.AutoSize = true;
            this.RBtn_Outsourced.Location = new System.Drawing.Point(178, 8);
            this.RBtn_Outsourced.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RBtn_Outsourced.Name = "RBtn_Outsourced";
            this.RBtn_Outsourced.Size = new System.Drawing.Size(80, 17);
            this.RBtn_Outsourced.TabIndex = 2;
            this.RBtn_Outsourced.TabStop = true;
            this.RBtn_Outsourced.Text = "Outsourced";
            this.RBtn_Outsourced.UseVisualStyleBackColor = true;
            this.RBtn_Outsourced.CheckedChanged += new System.EventHandler(this.RBtn_Outsourced_CheckedChanged);
            // 
            // Txt_PartId
            // 
            this.Txt_PartId.Enabled = false;
            this.Txt_PartId.Location = new System.Drawing.Point(107, 58);
            this.Txt_PartId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartId.Name = "Txt_PartId";
            this.Txt_PartId.Size = new System.Drawing.Size(111, 20);
            this.Txt_PartId.TabIndex = 3;
            this.Txt_PartId.Text = "Auto Gen - Disabled";
            // 
            // Lbl_PartId
            // 
            this.Lbl_PartId.AutoSize = true;
            this.Lbl_PartId.Location = new System.Drawing.Point(17, 60);
            this.Lbl_PartId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartId.Name = "Lbl_PartId";
            this.Lbl_PartId.Size = new System.Drawing.Size(18, 13);
            this.Lbl_PartId.TabIndex = 4;
            this.Lbl_PartId.Text = "ID";
            // 
            // Lbl_PartName
            // 
            this.Lbl_PartName.AutoSize = true;
            this.Lbl_PartName.Location = new System.Drawing.Point(17, 81);
            this.Lbl_PartName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartName.Name = "Lbl_PartName";
            this.Lbl_PartName.Size = new System.Drawing.Size(35, 13);
            this.Lbl_PartName.TabIndex = 6;
            this.Lbl_PartName.Text = "Name";
            // 
            // Txt_PartName
            // 
            this.Txt_PartName.Location = new System.Drawing.Point(107, 79);
            this.Txt_PartName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartName.Name = "Txt_PartName";
            this.Txt_PartName.Size = new System.Drawing.Size(111, 20);
            this.Txt_PartName.TabIndex = 5;
            this.Txt_PartName.Text = "Part Name";
            // 
            // Lbl_PartInv
            // 
            this.Lbl_PartInv.AutoSize = true;
            this.Lbl_PartInv.Location = new System.Drawing.Point(17, 101);
            this.Lbl_PartInv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartInv.Name = "Lbl_PartInv";
            this.Lbl_PartInv.Size = new System.Drawing.Size(22, 13);
            this.Lbl_PartInv.TabIndex = 8;
            this.Lbl_PartInv.Text = "Inv";
            // 
            // Txt_PartInv
            // 
            this.Txt_PartInv.Location = new System.Drawing.Point(107, 99);
            this.Txt_PartInv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartInv.Name = "Txt_PartInv";
            this.Txt_PartInv.Size = new System.Drawing.Size(111, 20);
            this.Txt_PartInv.TabIndex = 7;
            this.Txt_PartInv.Text = "Inv";
            // 
            // Lbl_PartPrice
            // 
            this.Lbl_PartPrice.AutoSize = true;
            this.Lbl_PartPrice.Location = new System.Drawing.Point(17, 122);
            this.Lbl_PartPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartPrice.Name = "Lbl_PartPrice";
            this.Lbl_PartPrice.Size = new System.Drawing.Size(57, 13);
            this.Lbl_PartPrice.TabIndex = 10;
            this.Lbl_PartPrice.Text = "Price/Cost";
            // 
            // Txt_PartPrice
            // 
            this.Txt_PartPrice.Location = new System.Drawing.Point(107, 120);
            this.Txt_PartPrice.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartPrice.Name = "Txt_PartPrice";
            this.Txt_PartPrice.Size = new System.Drawing.Size(111, 20);
            this.Txt_PartPrice.TabIndex = 9;
            this.Txt_PartPrice.Text = "Price/Cost";
            // 
            // Lbl_PartMax
            // 
            this.Lbl_PartMax.AutoSize = true;
            this.Lbl_PartMax.Location = new System.Drawing.Point(17, 143);
            this.Lbl_PartMax.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartMax.Name = "Lbl_PartMax";
            this.Lbl_PartMax.Size = new System.Drawing.Size(27, 13);
            this.Lbl_PartMax.TabIndex = 12;
            this.Lbl_PartMax.Text = "Max";
            // 
            // Txt_PartMax
            // 
            this.Txt_PartMax.Location = new System.Drawing.Point(107, 141);
            this.Txt_PartMax.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartMax.Name = "Txt_PartMax";
            this.Txt_PartMax.Size = new System.Drawing.Size(68, 20);
            this.Txt_PartMax.TabIndex = 11;
            this.Txt_PartMax.Text = "Max";
            // 
            // Lbl_PartsCompanyName
            // 
            this.Lbl_PartsCompanyName.AutoSize = true;
            this.Lbl_PartsCompanyName.Location = new System.Drawing.Point(17, 164);
            this.Lbl_PartsCompanyName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartsCompanyName.Name = "Lbl_PartsCompanyName";
            this.Lbl_PartsCompanyName.Size = new System.Drawing.Size(82, 13);
            this.Lbl_PartsCompanyName.TabIndex = 14;
            this.Lbl_PartsCompanyName.Text = "Company Name";
            this.Lbl_PartsCompanyName.Visible = false;
            // 
            // Txt_PartsCompanyName
            // 
            this.Txt_PartsCompanyName.Enabled = false;
            this.Txt_PartsCompanyName.Location = new System.Drawing.Point(107, 162);
            this.Txt_PartsCompanyName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartsCompanyName.Name = "Txt_PartsCompanyName";
            this.Txt_PartsCompanyName.Size = new System.Drawing.Size(111, 20);
            this.Txt_PartsCompanyName.TabIndex = 17;
            this.Txt_PartsCompanyName.Text = "Comp Name";
            this.Txt_PartsCompanyName.Visible = false;
            // 
            // Lbl_PartMin
            // 
            this.Lbl_PartMin.AutoSize = true;
            this.Lbl_PartMin.Location = new System.Drawing.Point(185, 143);
            this.Lbl_PartMin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartMin.Name = "Lbl_PartMin";
            this.Lbl_PartMin.Size = new System.Drawing.Size(24, 13);
            this.Lbl_PartMin.TabIndex = 16;
            this.Lbl_PartMin.Text = "Min";
            // 
            // Txt_PartMin
            // 
            this.Txt_PartMin.Location = new System.Drawing.Point(226, 141);
            this.Txt_PartMin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartMin.Name = "Txt_PartMin";
            this.Txt_PartMin.Size = new System.Drawing.Size(68, 20);
            this.Txt_PartMin.TabIndex = 15;
            this.Txt_PartMin.Text = "Min";
            // 
            // Btn_AddPartSave
            // 
            this.Btn_AddPartSave.Location = new System.Drawing.Point(142, 199);
            this.Btn_AddPartSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_AddPartSave.Name = "Btn_AddPartSave";
            this.Btn_AddPartSave.Size = new System.Drawing.Size(51, 21);
            this.Btn_AddPartSave.TabIndex = 18;
            this.Btn_AddPartSave.Text = "Save";
            this.Btn_AddPartSave.UseVisualStyleBackColor = true;
            this.Btn_AddPartSave.Click += new System.EventHandler(this.Btn_AddPartSave_Click);
            // 
            // Btn_PartAddCancel
            // 
            this.Btn_PartAddCancel.Location = new System.Drawing.Point(219, 199);
            this.Btn_PartAddCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_PartAddCancel.Name = "Btn_PartAddCancel";
            this.Btn_PartAddCancel.Size = new System.Drawing.Size(51, 21);
            this.Btn_PartAddCancel.TabIndex = 19;
            this.Btn_PartAddCancel.Text = "Cancel";
            this.Btn_PartAddCancel.UseVisualStyleBackColor = true;
            this.Btn_PartAddCancel.Click += new System.EventHandler(this.Btn_PartAddCancel_Click);
            // 
            // Lbl_PartsMachineID
            // 
            this.Lbl_PartsMachineID.AutoSize = true;
            this.Lbl_PartsMachineID.Location = new System.Drawing.Point(17, 164);
            this.Lbl_PartsMachineID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PartsMachineID.Name = "Lbl_PartsMachineID";
            this.Lbl_PartsMachineID.Size = new System.Drawing.Size(62, 13);
            this.Lbl_PartsMachineID.TabIndex = 20;
            this.Lbl_PartsMachineID.Text = "Machine ID";
            // 
            // Txt_PartsMachineID
            // 
            this.Txt_PartsMachineID.Location = new System.Drawing.Point(107, 162);
            this.Txt_PartsMachineID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_PartsMachineID.Name = "Txt_PartsMachineID";
            this.Txt_PartsMachineID.Size = new System.Drawing.Size(111, 20);
            this.Txt_PartsMachineID.TabIndex = 16;
            this.Txt_PartsMachineID.Text = "Mach ID";
            // 
            // Frm_AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 236);
            this.Controls.Add(this.Lbl_PartsMachineID);
            this.Controls.Add(this.Txt_PartsMachineID);
            this.Controls.Add(this.Btn_PartAddCancel);
            this.Controls.Add(this.Btn_AddPartSave);
            this.Controls.Add(this.Lbl_PartMin);
            this.Controls.Add(this.Txt_PartMin);
            this.Controls.Add(this.Lbl_PartsCompanyName);
            this.Controls.Add(this.Txt_PartsCompanyName);
            this.Controls.Add(this.Lbl_PartMax);
            this.Controls.Add(this.Txt_PartMax);
            this.Controls.Add(this.Lbl_PartPrice);
            this.Controls.Add(this.Txt_PartPrice);
            this.Controls.Add(this.Lbl_PartInv);
            this.Controls.Add(this.Txt_PartInv);
            this.Controls.Add(this.Lbl_PartName);
            this.Controls.Add(this.Txt_PartName);
            this.Controls.Add(this.Lbl_PartId);
            this.Controls.Add(this.Txt_PartId);
            this.Controls.Add(this.RBtn_Outsourced);
            this.Controls.Add(this.RBtn_InHouse);
            this.Controls.Add(this.Lbl_AddPartMain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_AddPart";
            this.Text = "Add Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AddPartMain;
        private System.Windows.Forms.RadioButton RBtn_InHouse;
        private System.Windows.Forms.RadioButton RBtn_Outsourced;
        private System.Windows.Forms.TextBox Txt_PartId;
        private System.Windows.Forms.Label Lbl_PartId;
        private System.Windows.Forms.Label Lbl_PartName;
        private System.Windows.Forms.TextBox Txt_PartName;
        private System.Windows.Forms.Label Lbl_PartInv;
        private System.Windows.Forms.TextBox Txt_PartInv;
        private System.Windows.Forms.Label Lbl_PartPrice;
        private System.Windows.Forms.TextBox Txt_PartPrice;
        private System.Windows.Forms.Label Lbl_PartMax;
        private System.Windows.Forms.TextBox Txt_PartMax;
        private System.Windows.Forms.Label Lbl_PartsCompanyName;
        private System.Windows.Forms.TextBox Txt_PartsCompanyName;
        private System.Windows.Forms.Label Lbl_PartMin;
        private System.Windows.Forms.TextBox Txt_PartMin;
        private System.Windows.Forms.Button Btn_AddPartSave;
        private System.Windows.Forms.Button Btn_PartAddCancel;
        private System.Windows.Forms.Label Lbl_PartsMachineID;
        private System.Windows.Forms.TextBox Txt_PartsMachineID;
    }
}