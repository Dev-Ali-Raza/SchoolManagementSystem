namespace IPROJECT
{
    partial class Fees_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fees_Form));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fs_getdata = new System.Windows.Forms.Button();
            this.fs_delete = new System.Windows.Forms.Button();
            this.fs_update = new System.Windows.Forms.Button();
            this.fs_save = new System.Windows.Forms.Button();
            this.fs_new = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Fs_doa = new System.Windows.Forms.DateTimePicker();
            this.fs_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fs_name = new System.Windows.Forms.TextBox();
            this.fs_amount = new System.Windows.Forms.TextBox();
            this.fs_month = new System.Windows.Forms.ComboBox();
            this.Fs_class = new System.Windows.Forms.ComboBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fs_getdata);
            this.groupBox2.Controls.Add(this.fs_delete);
            this.groupBox2.Controls.Add(this.fs_update);
            this.groupBox2.Controls.Add(this.fs_save);
            this.groupBox2.Controls.Add(this.fs_new);
            this.groupBox2.Location = new System.Drawing.Point(636, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 513);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operation Perfom";
            // 
            // fs_getdata
            // 
            this.fs_getdata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.fs_getdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_getdata.ForeColor = System.Drawing.Color.White;
            this.fs_getdata.Location = new System.Drawing.Point(40, 343);
            this.fs_getdata.Name = "fs_getdata";
            this.fs_getdata.Size = new System.Drawing.Size(144, 45);
            this.fs_getdata.TabIndex = 11;
            this.fs_getdata.Text = "Get Data";
            this.fs_getdata.UseVisualStyleBackColor = false;
            this.fs_getdata.Click += new System.EventHandler(this.fs_getdata_Click);
            // 
            // fs_delete
            // 
            this.fs_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.fs_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_delete.ForeColor = System.Drawing.Color.White;
            this.fs_delete.Location = new System.Drawing.Point(40, 273);
            this.fs_delete.Name = "fs_delete";
            this.fs_delete.Size = new System.Drawing.Size(144, 45);
            this.fs_delete.TabIndex = 10;
            this.fs_delete.Text = "Delete";
            this.fs_delete.UseVisualStyleBackColor = false;
            this.fs_delete.Click += new System.EventHandler(this.fs_delete_Click);
            // 
            // fs_update
            // 
            this.fs_update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.fs_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_update.ForeColor = System.Drawing.Color.White;
            this.fs_update.Location = new System.Drawing.Point(40, 203);
            this.fs_update.Name = "fs_update";
            this.fs_update.Size = new System.Drawing.Size(144, 45);
            this.fs_update.TabIndex = 9;
            this.fs_update.Text = "Update";
            this.fs_update.UseVisualStyleBackColor = false;
            this.fs_update.Click += new System.EventHandler(this.fs_update_Click);
            // 
            // fs_save
            // 
            this.fs_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.fs_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_save.ForeColor = System.Drawing.Color.White;
            this.fs_save.Location = new System.Drawing.Point(40, 133);
            this.fs_save.Name = "fs_save";
            this.fs_save.Size = new System.Drawing.Size(144, 45);
            this.fs_save.TabIndex = 8;
            this.fs_save.Text = "Save";
            this.fs_save.UseVisualStyleBackColor = false;
            this.fs_save.Click += new System.EventHandler(this.fs_save_Click);
            // 
            // fs_new
            // 
            this.fs_new.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.fs_new.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_new.ForeColor = System.Drawing.Color.White;
            this.fs_new.Location = new System.Drawing.Point(40, 63);
            this.fs_new.Name = "fs_new";
            this.fs_new.Size = new System.Drawing.Size(144, 45);
            this.fs_new.TabIndex = 7;
            this.fs_new.Text = "New";
            this.fs_new.UseVisualStyleBackColor = false;
            this.fs_new.Click += new System.EventHandler(this.fs_new_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(342, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Class :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Month :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(345, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "DOA  :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Amount :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Fs_doa);
            this.groupBox1.Controls.Add(this.fs_ID);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.fs_name);
            this.groupBox1.Controls.Add(this.fs_amount);
            this.groupBox1.Controls.Add(this.fs_month);
            this.groupBox1.Controls.Add(this.Fs_class);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(607, 513);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fees Form";
            // 
            // Fs_doa
            // 
            this.Fs_doa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Fs_doa.Location = new System.Drawing.Point(421, 107);
            this.Fs_doa.Name = "Fs_doa";
            this.Fs_doa.Size = new System.Drawing.Size(171, 20);
            this.Fs_doa.TabIndex = 4;
            // 
            // fs_ID
            // 
            this.fs_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_ID.Location = new System.Drawing.Point(92, 42);
            this.fs_ID.Multiline = true;
            this.fs_ID.Name = "fs_ID";
            this.fs_ID.Size = new System.Drawing.Size(170, 32);
            this.fs_ID.TabIndex = 1;
            this.fs_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fs_ID_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID :";
            // 
            // fs_name
            // 
            this.fs_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_name.Location = new System.Drawing.Point(422, 42);
            this.fs_name.Multiline = true;
            this.fs_name.Name = "fs_name";
            this.fs_name.Size = new System.Drawing.Size(170, 32);
            this.fs_name.TabIndex = 2;
            // 
            // fs_amount
            // 
            this.fs_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_amount.Location = new System.Drawing.Point(422, 161);
            this.fs_amount.Multiline = true;
            this.fs_amount.Name = "fs_amount";
            this.fs_amount.Size = new System.Drawing.Size(171, 32);
            this.fs_amount.TabIndex = 6;
            this.fs_amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.fs_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fs_amount_KeyPress);
            // 
            // fs_month
            // 
            this.fs_month.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fs_month.FormattingEnabled = true;
            this.fs_month.Items.AddRange(new object[] {
            "January",
            "Febuary",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.fs_month.Location = new System.Drawing.Point(92, 101);
            this.fs_month.Name = "fs_month";
            this.fs_month.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fs_month.Size = new System.Drawing.Size(171, 32);
            this.fs_month.TabIndex = 3;
            this.fs_month.Text = "January";
            // 
            // Fs_class
            // 
            this.Fs_class.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fs_class.FormattingEnabled = true;
            this.Fs_class.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th",
            "9th",
            "10th"});
            this.Fs_class.Location = new System.Drawing.Point(92, 160);
            this.Fs_class.Name = "Fs_class";
            this.Fs_class.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Fs_class.Size = new System.Drawing.Size(171, 32);
            this.Fs_class.TabIndex = 5;
            this.Fs_class.Text = "1st";
            // 
            // Fees_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(865, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Fees_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fees_Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button fs_getdata;
        private System.Windows.Forms.Button fs_delete;
        private System.Windows.Forms.Button fs_update;
        private System.Windows.Forms.Button fs_save;
        private System.Windows.Forms.Button fs_new;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox Fs_class;
        public System.Windows.Forms.TextBox fs_amount;
        public System.Windows.Forms.ComboBox fs_month;
        public System.Windows.Forms.TextBox fs_name;
        public System.Windows.Forms.TextBox fs_ID;
        public System.Windows.Forms.DateTimePicker Fs_doa;
    }
}