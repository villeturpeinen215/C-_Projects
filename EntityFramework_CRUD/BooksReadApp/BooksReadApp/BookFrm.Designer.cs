namespace BooksReadApp
{
    partial class BookFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddPublDate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddPublisher = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddPages = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddLang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdatePublDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUpdatePublisher = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUpdatePages = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateLang = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateAuthor = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtUpdateId = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAddPublDate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAddPublisher);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddPages);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtAddLang);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtAddAuthor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAddName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(28, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 222);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add book";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(275, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddPublDate
            // 
            this.txtAddPublDate.Location = new System.Drawing.Point(92, 147);
            this.txtAddPublDate.Name = "txtAddPublDate";
            this.txtAddPublDate.Size = new System.Drawing.Size(301, 20);
            this.txtAddPublDate.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Publication date";
            // 
            // txtAddPublisher
            // 
            this.txtAddPublisher.Location = new System.Drawing.Point(92, 121);
            this.txtAddPublisher.Name = "txtAddPublisher";
            this.txtAddPublisher.Size = new System.Drawing.Size(301, 20);
            this.txtAddPublisher.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publisher";
            // 
            // txtAddPages
            // 
            this.txtAddPages.Location = new System.Drawing.Point(92, 95);
            this.txtAddPages.Name = "txtAddPages";
            this.txtAddPages.Size = new System.Drawing.Size(301, 20);
            this.txtAddPages.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Pages";
            // 
            // txtAddLang
            // 
            this.txtAddLang.Location = new System.Drawing.Point(92, 69);
            this.txtAddLang.Name = "txtAddLang";
            this.txtAddLang.Size = new System.Drawing.Size(301, 20);
            this.txtAddLang.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Language";
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(92, 43);
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(301, 20);
            this.txtAddAuthor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Author";
            // 
            // txtAddName
            // 
            this.txtAddName.Location = new System.Drawing.Point(92, 17);
            this.txtAddName.Name = "txtAddName";
            this.txtAddName.Size = new System.Drawing.Size(301, 20);
            this.txtAddName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(989, 212);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtUpdatePublDate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtUpdatePublisher);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtUpdatePages);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtUpdateLang);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtUpdateAuthor);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtUpdateId);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.txtUpdateName);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(551, 24);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 235);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selected book - Update book details";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(92, 199);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdatePublDate
            // 
            this.txtUpdatePublDate.Location = new System.Drawing.Point(92, 173);
            this.txtUpdatePublDate.Name = "txtUpdatePublDate";
            this.txtUpdatePublDate.Size = new System.Drawing.Size(301, 20);
            this.txtUpdatePublDate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Publication date";
            // 
            // txtUpdatePublisher
            // 
            this.txtUpdatePublisher.Location = new System.Drawing.Point(92, 147);
            this.txtUpdatePublisher.Name = "txtUpdatePublisher";
            this.txtUpdatePublisher.Size = new System.Drawing.Size(301, 20);
            this.txtUpdatePublisher.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Publisher";
            // 
            // txtUpdatePages
            // 
            this.txtUpdatePages.Location = new System.Drawing.Point(92, 121);
            this.txtUpdatePages.Name = "txtUpdatePages";
            this.txtUpdatePages.Size = new System.Drawing.Size(301, 20);
            this.txtUpdatePages.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Pages";
            // 
            // txtUpdateLang
            // 
            this.txtUpdateLang.Location = new System.Drawing.Point(92, 95);
            this.txtUpdateLang.Name = "txtUpdateLang";
            this.txtUpdateLang.Size = new System.Drawing.Size(301, 20);
            this.txtUpdateLang.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Language";
            // 
            // txtUpdateAuthor
            // 
            this.txtUpdateAuthor.Location = new System.Drawing.Point(92, 69);
            this.txtUpdateAuthor.Name = "txtUpdateAuthor";
            this.txtUpdateAuthor.Size = new System.Drawing.Size(301, 20);
            this.txtUpdateAuthor.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Author";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(92, 43);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(301, 20);
            this.txtUpdateName.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(16, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Id";
            // 
            // txtUpdateId
            // 
            this.txtUpdateId.Location = new System.Drawing.Point(92, 20);
            this.txtUpdateId.Name = "txtUpdateId";
            this.txtUpdateId.ReadOnly = true;
            this.txtUpdateId.Size = new System.Drawing.Size(301, 20);
            this.txtUpdateId.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(272, 199);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(92, 182);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 23);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // BookFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 547);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "BookFrm";
            this.Text = "Read Books App";
            this.Load += new System.EventHandler(this.BookFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAddPublDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddPublisher;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAddPages;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddLang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdatePublDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUpdatePublisher;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUpdatePages;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateLang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateAuthor;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtUpdateId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}