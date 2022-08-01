namespace Gui_WinFormApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.txt_SKU = new System.Windows.Forms.TextBox();
            this.dtp_datepicker1 = new System.Windows.Forms.DateTimePicker();
            this.Number_txt = new System.Windows.Forms.Label();
            this.Date_txt = new System.Windows.Forms.Label();
            this.SKU_txt = new System.Windows.Forms.Label();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.lbl_count = new System.Windows.Forms.Label();
            this.txt_count = new System.Windows.Forms.TextBox();
            this.lbl_ObjName = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.First_Name = new System.Windows.Forms.Panel();
            this.lable_item = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.dgvShowProducts = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_phoneNo = new System.Windows.Forms.Label();
            this.txt_PhonNo = new System.Windows.Forms.TextBox();
            this.First_Name.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(12, 101);
            this.txt_number.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(110, 23);
            this.txt_number.TabIndex = 0;
            this.txt_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_number_KeyPress);
            // 
            // txt_SKU
            // 
            this.txt_SKU.Location = new System.Drawing.Point(427, 101);
            this.txt_SKU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_SKU.Name = "txt_SKU";
            this.txt_SKU.Size = new System.Drawing.Size(110, 23);
            this.txt_SKU.TabIndex = 2;
            // 
            // dtp_datepicker1
            // 
            this.dtp_datepicker1.Location = new System.Drawing.Point(171, 101);
            this.dtp_datepicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_datepicker1.Name = "dtp_datepicker1";
            this.dtp_datepicker1.Size = new System.Drawing.Size(219, 23);
            this.dtp_datepicker1.TabIndex = 3;
            // 
            // Number_txt
            // 
            this.Number_txt.AutoSize = true;
            this.Number_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Number_txt.Location = new System.Drawing.Point(12, 79);
            this.Number_txt.Name = "Number_txt";
            this.Number_txt.Size = new System.Drawing.Size(67, 20);
            this.Number_txt.TabIndex = 4;
            this.Number_txt.Text = "Number";
            // 
            // Date_txt
            // 
            this.Date_txt.AutoSize = true;
            this.Date_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Date_txt.Location = new System.Drawing.Point(171, 79);
            this.Date_txt.Name = "Date_txt";
            this.Date_txt.Size = new System.Drawing.Size(42, 20);
            this.Date_txt.TabIndex = 4;
            this.Date_txt.Text = "Date";
            // 
            // SKU_txt
            // 
            this.SKU_txt.AutoSize = true;
            this.SKU_txt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SKU_txt.Location = new System.Drawing.Point(427, 79);
            this.SKU_txt.Name = "SKU_txt";
            this.SKU_txt.Size = new System.Drawing.Size(38, 20);
            this.SKU_txt.TabIndex = 4;
            this.SKU_txt.Text = "SKU";
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(12, 190);
            this.txt_objectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(323, 23);
            this.txt_objectName.TabIndex = 0;
            this.txt_objectName.TextChanged += new System.EventHandler(this.txt_objectName_TextChanged);
            // 
            // lbl_count
            // 
            this.lbl_count.AutoSize = true;
            this.lbl_count.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_count.Location = new System.Drawing.Point(396, 168);
            this.lbl_count.Name = "lbl_count";
            this.lbl_count.Size = new System.Drawing.Size(51, 20);
            this.lbl_count.TabIndex = 4;
            this.lbl_count.Text = "Count";
            // 
            // txt_count
            // 
            this.txt_count.Location = new System.Drawing.Point(396, 190);
            this.txt_count.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_count.Name = "txt_count";
            this.txt_count.Size = new System.Drawing.Size(110, 23);
            this.txt_count.TabIndex = 2;
            // 
            // lbl_ObjName
            // 
            this.lbl_ObjName.AutoSize = true;
            this.lbl_ObjName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_ObjName.Location = new System.Drawing.Point(12, 168);
            this.lbl_ObjName.Name = "lbl_ObjName";
            this.lbl_ObjName.Size = new System.Drawing.Size(100, 20);
            this.lbl_ObjName.TabIndex = 4;
            this.lbl_ObjName.Text = "Object Name";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(569, 190);
            this.txt_price.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(110, 23);
            this.txt_price.TabIndex = 2;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.Location = new System.Drawing.Point(569, 168);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(43, 20);
            this.lbl_price.TabIndex = 4;
            this.lbl_price.Text = "Price";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(12, 128);
            this.btn_add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(82, 22);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            this.btn_add.MouseHover += new System.EventHandler(this.btn_add_MouseHover);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(171, 128);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(82, 22);
            this.btn_cancel.TabIndex = 6;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // First_Name
            // 
            this.First_Name.BackColor = System.Drawing.Color.Red;
            this.First_Name.Controls.Add(this.lable_item);
            this.First_Name.Location = new System.Drawing.Point(5, 4);
            this.First_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.First_Name.Name = "First_Name";
            this.First_Name.Size = new System.Drawing.Size(1021, 52);
            this.First_Name.TabIndex = 7;
            // 
            // lable_item
            // 
            this.lable_item.AutoSize = true;
            this.lable_item.BackColor = System.Drawing.Color.Gainsboro;
            this.lable_item.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lable_item.Location = new System.Drawing.Point(401, 16);
            this.lable_item.Name = "lable_item";
            this.lable_item.Size = new System.Drawing.Size(100, 23);
            this.lable_item.TabIndex = 8;
            this.lable_item.Text = "Item Shop";
            this.lable_item.Click += new System.EventHandler(this.lbl_addItem_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(427, 128);
            this.btn_reset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(82, 22);
            this.btn_reset.TabIndex = 8;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // dgvShowProducts
            // 
            this.dgvShowProducts.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvShowProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowProducts.Location = new System.Drawing.Point(12, 217);
            this.dgvShowProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvShowProducts.Name = "dgvShowProducts";
            this.dgvShowProducts.RowHeadersWidth = 51;
            this.dgvShowProducts.RowTemplate.Height = 29;
            this.dgvShowProducts.Size = new System.Drawing.Size(1014, 208);
            this.dgvShowProducts.TabIndex = 9;
            this.dgvShowProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowProducts_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_phoneNo
            // 
            this.lbl_phoneNo.AutoSize = true;
            this.lbl_phoneNo.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_phoneNo.Location = new System.Drawing.Point(743, 169);
            this.lbl_phoneNo.Name = "lbl_phoneNo";
            this.lbl_phoneNo.Size = new System.Drawing.Size(83, 19);
            this.lbl_phoneNo.TabIndex = 10;
            this.lbl_phoneNo.Text = "PhoneNum";
            // 
            // txt_PhonNo
            // 
            this.txt_PhonNo.Location = new System.Drawing.Point(743, 190);
            this.txt_PhonNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_PhonNo.Name = "txt_PhonNo";
            this.txt_PhonNo.Size = new System.Drawing.Size(110, 23);
            this.txt_PhonNo.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1038, 446);
            this.Controls.Add(this.txt_PhonNo);
            this.Controls.Add(this.lbl_phoneNo);
            this.Controls.Add(this.dgvShowProducts);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.First_Name);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_count);
            this.Controls.Add(this.SKU_txt);
            this.Controls.Add(this.Date_txt);
            this.Controls.Add(this.lbl_ObjName);
            this.Controls.Add(this.Number_txt);
            this.Controls.Add(this.dtp_datepicker1);
            this.Controls.Add(this.txt_price);
            this.Controls.Add(this.txt_objectName);
            this.Controls.Add(this.txt_count);
            this.Controls.Add(this.txt_SKU);
            this.Controls.Add(this.txt_number);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.First_Name.ResumeLayout(false);
            this.First_Name.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_number;
        private TextBox txt_SKU;
        private DateTimePicker dtp_datepicker1;
        private Label Number_txt;
        private Label Date_txt;
        private Label SKU_txt;
        private TextBox txt_objectName;
        private Label lbl_count;
        private TextBox txt_count;
        private Label lbl_ObjName;
        private TextBox txt_price;
        private Label lbl_price;
        private Button btn_add;
        private Button btn_cancel;
        private Panel First_Name;
        private Label lable_item;
        private Button btn_reset;
        private DataGridView dgvShowProducts;
        private ErrorProvider errorProvider1;
        private TextBox txt_PhonNo;
        private Label lbl_phoneNo;
    }
}