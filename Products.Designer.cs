namespace Pragati
{
    partial class Products
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.texCategoryId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.texProductPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textProductsName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.bCancle = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.butDelete = new System.Windows.Forms.Button();
            this.txtProductsID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.texCategoryId);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.texProductPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textProductsName);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.bCancle);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.butDelete);
            this.panel1.Controls.Add(this.txtProductsID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(86, 458);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 325);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // texCategoryId
            // 
            this.texCategoryId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texCategoryId.Location = new System.Drawing.Point(270, 130);
            this.texCategoryId.Name = "texCategoryId";
            this.texCategoryId.Size = new System.Drawing.Size(262, 30);
            this.texCategoryId.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Category ID";
            // 
            // texProductPrice
            // 
            this.texProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texProductPrice.Location = new System.Drawing.Point(270, 93);
            this.texProductPrice.Name = "texProductPrice";
            this.texProductPrice.Size = new System.Drawing.Size(262, 30);
            this.texProductPrice.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 25);
            this.label5.TabIndex = 15;
            this.label5.Text = "Product Price";
            // 
            // textProductsName
            // 
            this.textProductsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textProductsName.Location = new System.Drawing.Point(270, 55);
            this.textProductsName.Name = "textProductsName";
            this.textProductsName.Size = new System.Drawing.Size(262, 30);
            this.textProductsName.TabIndex = 12;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(91, 281);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 31);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // bCancle
            // 
            this.bCancle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancle.Location = new System.Drawing.Point(433, 281);
            this.bCancle.Name = "bCancle";
            this.bCancle.Size = new System.Drawing.Size(80, 31);
            this.bCancle.TabIndex = 8;
            this.bCancle.Text = "Cancle";
            this.bCancle.UseVisualStyleBackColor = true;
            this.bCancle.Click += new System.EventHandler(this.bCancle_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Products Name";
            // 
            // butDelete
            // 
            this.butDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butDelete.Location = new System.Drawing.Point(261, 281);
            this.butDelete.Name = "butDelete";
            this.butDelete.Size = new System.Drawing.Size(80, 31);
            this.butDelete.TabIndex = 7;
            this.butDelete.Text = "Delete";
            this.butDelete.UseVisualStyleBackColor = true;
            this.butDelete.Click += new System.EventHandler(this.butDelete_Click);
            // 
            // txtProductsID
            // 
            this.txtProductsID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductsID.Location = new System.Drawing.Point(270, 15);
            this.txtProductsID.Name = "txtProductsID";
            this.txtProductsID.Size = new System.Drawing.Size(262, 30);
            this.txtProductsID.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Products ID";
            // 
            // txtsearch
            // 
            this.txtsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsearch.Location = new System.Drawing.Point(314, 74);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(262, 38);
            this.txtsearch.TabIndex = 14;
            this.txtsearch.TextChanged += new System.EventHandler(this.Textchange);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 161);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(852, 259);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewCellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(324, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "View Products";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(639, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 31);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 795);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Products_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textProductsName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button bCancle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button butDelete;
        private System.Windows.Forms.TextBox txtProductsID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texProductPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox texCategoryId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}