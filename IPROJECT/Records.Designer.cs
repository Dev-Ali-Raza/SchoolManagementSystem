namespace IPROJECT
{
    partial class Records
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.st_record = new System.Windows.Forms.Button();
            this.Tc_Records = new System.Windows.Forms.Button();
            this.Fs_Record = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // st_record
            // 
            this.st_record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.st_record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.st_record.ForeColor = System.Drawing.Color.White;
            this.st_record.Location = new System.Drawing.Point(12, 82);
            this.st_record.Name = "st_record";
            this.st_record.Size = new System.Drawing.Size(173, 52);
            this.st_record.TabIndex = 3;
            this.st_record.Text = "Student Records";
            this.st_record.UseVisualStyleBackColor = false;
            this.st_record.Click += new System.EventHandler(this.st_record_Click);
            // 
            // Tc_Records
            // 
            this.Tc_Records.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Tc_Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tc_Records.ForeColor = System.Drawing.Color.White;
            this.Tc_Records.Location = new System.Drawing.Point(216, 82);
            this.Tc_Records.Name = "Tc_Records";
            this.Tc_Records.Size = new System.Drawing.Size(175, 52);
            this.Tc_Records.TabIndex = 4;
            this.Tc_Records.Text = "Teacher Records";
            this.Tc_Records.UseVisualStyleBackColor = false;
            this.Tc_Records.Click += new System.EventHandler(this.Tc_Records_Click);
            // 
            // Fs_Record
            // 
            this.Fs_Record.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.Fs_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fs_Record.ForeColor = System.Drawing.Color.White;
            this.Fs_Record.Location = new System.Drawing.Point(422, 82);
            this.Fs_Record.Name = "Fs_Record";
            this.Fs_Record.Size = new System.Drawing.Size(172, 52);
            this.Fs_Record.TabIndex = 5;
            this.Fs_Record.Text = "Fees Records";
            this.Fs_Record.UseVisualStyleBackColor = false;
            this.Fs_Record.Click += new System.EventHandler(this.Fs_Record_Click);
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(610, 230);
            this.Controls.Add(this.Fs_Record);
            this.Controls.Add(this.Tc_Records);
            this.Controls.Add(this.st_record);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Records";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Records";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button st_record;
        private System.Windows.Forms.Button Tc_Records;
        private System.Windows.Forms.Button Fs_Record;
    }
}