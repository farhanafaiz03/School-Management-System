namespace SchoolManagementSystem
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelStd = new System.Windows.Forms.Panel();
            this.CloseImage = new System.Windows.Forms.PictureBox();
            this.nameStd = new System.Windows.Forms.Label();
            this.picStd2 = new System.Windows.Forms.PictureBox();
            this.stName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.stFees = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stDob = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.StdList = new System.Windows.Forms.Label();
            this.stClass = new System.Windows.Forms.ComboBox();
            this.StdDGV = new System.Windows.Forms.DataGridView();
            this.panelStd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStd2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StdDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panelStd
            // 
            this.panelStd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelStd.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelStd.Controls.Add(this.CloseImage);
            this.panelStd.Controls.Add(this.nameStd);
            this.panelStd.Controls.Add(this.picStd2);
            this.panelStd.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStd.Location = new System.Drawing.Point(0, 0);
            this.panelStd.Margin = new System.Windows.Forms.Padding(4);
            this.panelStd.Name = "panelStd";
            this.panelStd.Size = new System.Drawing.Size(883, 53);
            this.panelStd.TabIndex = 0;
            // 
            // CloseImage
            // 
            this.CloseImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CloseImage.Image = ((System.Drawing.Image)(resources.GetObject("CloseImage.Image")));
            this.CloseImage.Location = new System.Drawing.Point(833, 4);
            this.CloseImage.Margin = new System.Windows.Forms.Padding(4);
            this.CloseImage.Name = "CloseImage";
            this.CloseImage.Size = new System.Drawing.Size(46, 33);
            this.CloseImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseImage.TabIndex = 14;
            this.CloseImage.TabStop = false;
            this.CloseImage.Click += new System.EventHandler(this.CloseImage_Click);
            // 
            // nameStd
            // 
            this.nameStd.AutoSize = true;
            this.nameStd.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStd.ForeColor = System.Drawing.Color.Black;
            this.nameStd.Location = new System.Drawing.Point(76, 14);
            this.nameStd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameStd.Name = "nameStd";
            this.nameStd.Size = new System.Drawing.Size(123, 29);
            this.nameStd.TabIndex = 1;
            this.nameStd.Text = "Students";
            // 
            // picStd2
            // 
            this.picStd2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picStd2.Image = ((System.Drawing.Image)(resources.GetObject("picStd2.Image")));
            this.picStd2.Location = new System.Drawing.Point(4, 4);
            this.picStd2.Margin = new System.Windows.Forms.Padding(4);
            this.picStd2.Name = "picStd2";
            this.picStd2.Size = new System.Drawing.Size(64, 43);
            this.picStd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStd2.TabIndex = 8;
            this.picStd2.TabStop = false;
            // 
            // stName
            // 
            this.stName.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stName.Location = new System.Drawing.Point(50, 100);
            this.stName.Margin = new System.Windows.Forms.Padding(4);
            this.stName.Name = "stName";
            this.stName.Size = new System.Drawing.Size(162, 31);
            this.stName.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(45, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = " Name";
            // 
            // stFees
            // 
            this.stFees.Font = new System.Drawing.Font("Lucida Fax", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stFees.Location = new System.Drawing.Point(723, 99);
            this.stFees.Margin = new System.Windows.Forms.Padding(4);
            this.stFees.Name = "stFees";
            this.stFees.Size = new System.Drawing.Size(107, 28);
            this.stFees.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(718, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fees";
            // 
            // stGender
            // 
            this.stGender.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stGender.FormattingEnabled = true;
            this.stGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.stGender.Location = new System.Drawing.Point(230, 99);
            this.stGender.Margin = new System.Windows.Forms.Padding(4);
            this.stGender.Name = "stGender";
            this.stGender.Size = new System.Drawing.Size(137, 31);
            this.stGender.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(226, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 16;
            this.label4.Text = "Gender";
            // 
            // stDob
            // 
            this.stDob.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stDob.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stDob.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.stDob.Location = new System.Drawing.Point(397, 100);
            this.stDob.Margin = new System.Windows.Forms.Padding(4);
            this.stDob.Name = "stDob";
            this.stDob.Size = new System.Drawing.Size(152, 31);
            this.stDob.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(393, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 27);
            this.label5.TabIndex = 18;
            this.label5.Text = "DoB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(567, 69);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 27);
            this.label6.TabIndex = 19;
            this.label6.Text = "Class";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(120, 159);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(144, 37);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(286, 159);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(144, 37);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(452, 159);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 37);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(616, 159);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(144, 37);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // StdList
            // 
            this.StdList.AutoSize = true;
            this.StdList.Font = new System.Drawing.Font("Lucida Calligraphy", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StdList.ForeColor = System.Drawing.Color.Black;
            this.StdList.Location = new System.Drawing.Point(327, 222);
            this.StdList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.StdList.Name = "StdList";
            this.StdList.Size = new System.Drawing.Size(222, 36);
            this.StdList.TabIndex = 26;
            this.StdList.Text = "Students List";
            // 
            // stClass
            // 
            this.stClass.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stClass.FormattingEnabled = true;
            this.stClass.Items.AddRange(new object[] {
            "6th",
            "7th",
            "8th",
            "9th",
            "10th",
            "11th",
            "12th"});
            this.stClass.Location = new System.Drawing.Point(573, 99);
            this.stClass.Margin = new System.Windows.Forms.Padding(4);
            this.stClass.Name = "stClass";
            this.stClass.Size = new System.Drawing.Size(120, 31);
            this.stClass.TabIndex = 27;
            // 
            // StdDGV
            // 
            this.StdDGV.AllowUserToOrderColumns = true;
            this.StdDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.StdDGV.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.StdDGV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StdDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.StdDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.StdDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.StdDGV.EnableHeadersVisualStyles = false;
            this.StdDGV.GridColor = System.Drawing.SystemColors.GrayText;
            this.StdDGV.Location = new System.Drawing.Point(4, 261);
            this.StdDGV.Name = "StdDGV";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.StdDGV.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.StdDGV.RowHeadersWidth = 51;
            this.StdDGV.Size = new System.Drawing.Size(875, 422);
            this.StdDGV.TabIndex = 43;
            this.StdDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StdDGV_CellContentClick_1);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(883, 680);
            this.Controls.Add(this.StdDGV);
            this.Controls.Add(this.stClass);
            this.Controls.Add(this.StdList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.stDob);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stGender);
            this.Controls.Add(this.stFees);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelStd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Students";
            this.panelStd.ResumeLayout(false);
            this.panelStd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStd2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StdDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelStd;
        private System.Windows.Forms.Label nameStd;
        private System.Windows.Forms.PictureBox picStd2;
        private System.Windows.Forms.PictureBox CloseImage;
        private System.Windows.Forms.TextBox stName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox stFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox stGender;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker stDob;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label StdList;
        private System.Windows.Forms.ComboBox stClass;
        private System.Windows.Forms.DataGridView StdDGV;
    }
}