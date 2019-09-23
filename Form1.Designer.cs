namespace WindowsFormsApp1
{
    partial class Crud
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.添加 = new System.Windows.Forms.GroupBox();
            this.Add = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.AddBoxClass = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AddBoxEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.AddBoxPhone = new System.Windows.Forms.TextBox();
            this.AddPhone = new System.Windows.Forms.Label();
            this.AddBoxBrithday = new System.Windows.Forms.TextBox();
            this.AddBirthday = new System.Windows.Forms.Label();
            this.AddBoxSex = new System.Windows.Forms.TextBox();
            this.Sex = new System.Windows.Forms.Label();
            this.AddBoxName = new System.Windows.Forms.TextBox();
            this.AddName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.LabeID = new System.Windows.Forms.Label();
            this.CurrentId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RedactTxtClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RedactTxtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.RedactTxtPhone = new System.Windows.Forms.TextBox();
            this.RedactPhone = new System.Windows.Forms.Label();
            this.RedactTxtBrithday = new System.Windows.Forms.TextBox();
            this.RedactBrithday = new System.Windows.Forms.Label();
            this.RedactTxtSex = new System.Windows.Forms.TextBox();
            this.RedactSex = new System.Windows.Forms.Label();
            this.RedactTxtName = new System.Windows.Forms.TextBox();
            this.RedactName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.添加.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 142);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 231);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // 添加
            // 
            this.添加.Controls.Add(this.Add);
            this.添加.Controls.Add(this.Refresh);
            this.添加.Controls.Add(this.AddBoxClass);
            this.添加.Controls.Add(this.label6);
            this.添加.Controls.Add(this.AddBoxEmail);
            this.添加.Controls.Add(this.label5);
            this.添加.Controls.Add(this.AddBoxPhone);
            this.添加.Controls.Add(this.AddPhone);
            this.添加.Controls.Add(this.AddBoxBrithday);
            this.添加.Controls.Add(this.AddBirthday);
            this.添加.Controls.Add(this.AddBoxSex);
            this.添加.Controls.Add(this.Sex);
            this.添加.Controls.Add(this.AddBoxName);
            this.添加.Controls.Add(this.AddName);
            this.添加.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.添加.Location = new System.Drawing.Point(12, 12);
            this.添加.Name = "添加";
            this.添加.Size = new System.Drawing.Size(877, 124);
            this.添加.TabIndex = 1;
            this.添加.TabStop = false;
            this.添加.Text = "添加";
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(707, 67);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(141, 39);
            this.Add.TabIndex = 13;
            this.Add.Text = "添加";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(707, 19);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(141, 40);
            this.Refresh.TabIndex = 12;
            this.Refresh.Text = "刷新";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Button1_Click);
            // 
            // AddBoxClass
            // 
            this.AddBoxClass.Location = new System.Drawing.Point(569, 67);
            this.AddBoxClass.Name = "AddBoxClass";
            this.AddBoxClass.Size = new System.Drawing.Size(100, 34);
            this.AddBoxClass.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(471, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "班级";
            // 
            // AddBoxEmail
            // 
            this.AddBoxEmail.Location = new System.Drawing.Point(335, 67);
            this.AddBoxEmail.Name = "AddBoxEmail";
            this.AddBoxEmail.Size = new System.Drawing.Size(100, 34);
            this.AddBoxEmail.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(237, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email";
            // 
            // AddBoxPhone
            // 
            this.AddBoxPhone.Location = new System.Drawing.Point(104, 67);
            this.AddBoxPhone.Name = "AddBoxPhone";
            this.AddBoxPhone.Size = new System.Drawing.Size(100, 34);
            this.AddBoxPhone.TabIndex = 7;
            // 
            // AddPhone
            // 
            this.AddPhone.AutoSize = true;
            this.AddPhone.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddPhone.Location = new System.Drawing.Point(6, 74);
            this.AddPhone.Name = "AddPhone";
            this.AddPhone.Size = new System.Drawing.Size(49, 20);
            this.AddPhone.TabIndex = 6;
            this.AddPhone.Text = "电话";
            // 
            // AddBoxBrithday
            // 
            this.AddBoxBrithday.Location = new System.Drawing.Point(569, 25);
            this.AddBoxBrithday.Name = "AddBoxBrithday";
            this.AddBoxBrithday.Size = new System.Drawing.Size(100, 34);
            this.AddBoxBrithday.TabIndex = 5;
            // 
            // AddBirthday
            // 
            this.AddBirthday.AutoSize = true;
            this.AddBirthday.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddBirthday.Location = new System.Drawing.Point(471, 32);
            this.AddBirthday.Name = "AddBirthday";
            this.AddBirthday.Size = new System.Drawing.Size(49, 20);
            this.AddBirthday.TabIndex = 4;
            this.AddBirthday.Text = "生日";
            // 
            // AddBoxSex
            // 
            this.AddBoxSex.Location = new System.Drawing.Point(335, 25);
            this.AddBoxSex.Name = "AddBoxSex";
            this.AddBoxSex.Size = new System.Drawing.Size(100, 34);
            this.AddBoxSex.TabIndex = 3;
            // 
            // Sex
            // 
            this.Sex.AutoSize = true;
            this.Sex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Sex.Location = new System.Drawing.Point(237, 32);
            this.Sex.Name = "Sex";
            this.Sex.Size = new System.Drawing.Size(49, 20);
            this.Sex.TabIndex = 2;
            this.Sex.Text = "性别";
            // 
            // AddBoxName
            // 
            this.AddBoxName.Location = new System.Drawing.Point(104, 25);
            this.AddBoxName.Name = "AddBoxName";
            this.AddBoxName.Size = new System.Drawing.Size(100, 34);
            this.AddBoxName.TabIndex = 1;
            // 
            // AddName
            // 
            this.AddName.AutoSize = true;
            this.AddName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AddName.Location = new System.Drawing.Point(6, 32);
            this.AddName.Name = "AddName";
            this.AddName.Size = new System.Drawing.Size(49, 20);
            this.AddName.TabIndex = 0;
            this.AddName.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Update);
            this.groupBox2.Controls.Add(this.Delete);
            this.groupBox2.Controls.Add(this.LabeID);
            this.groupBox2.Controls.Add(this.CurrentId);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.RedactTxtClass);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.RedactTxtEmail);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.RedactTxtPhone);
            this.groupBox2.Controls.Add(this.RedactPhone);
            this.groupBox2.Controls.Add(this.RedactTxtBrithday);
            this.groupBox2.Controls.Add(this.RedactBrithday);
            this.groupBox2.Controls.Add(this.RedactTxtSex);
            this.groupBox2.Controls.Add(this.RedactSex);
            this.groupBox2.Controls.Add(this.RedactTxtName);
            this.groupBox2.Controls.Add(this.RedactName);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(12, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(877, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "编辑";
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(707, 30);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(141, 56);
            this.Update.TabIndex = 28;
            this.Update.Text = "修改";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(707, 110);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(141, 55);
            this.Delete.TabIndex = 27;
            this.Delete.Text = "删除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Button2_Click);
            // 
            // LabeID
            // 
            this.LabeID.AutoSize = true;
            this.LabeID.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LabeID.Location = new System.Drawing.Point(185, 30);
            this.LabeID.Name = "LabeID";
            this.LabeID.Size = new System.Drawing.Size(19, 20);
            this.LabeID.TabIndex = 26;
            this.LabeID.Text = "0";
            // 
            // CurrentId
            // 
            this.CurrentId.AutoSize = true;
            this.CurrentId.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CurrentId.Location = new System.Drawing.Point(194, 30);
            this.CurrentId.Name = "CurrentId";
            this.CurrentId.Size = new System.Drawing.Size(0, 20);
            this.CurrentId.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "当前 ID:";
            // 
            // RedactTxtClass
            // 
            this.RedactTxtClass.Location = new System.Drawing.Point(569, 110);
            this.RedactTxtClass.Name = "RedactTxtClass";
            this.RedactTxtClass.Size = new System.Drawing.Size(100, 34);
            this.RedactTxtClass.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(471, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 22;
            this.label7.Text = "班级";
            // 
            // RedactTxtEmail
            // 
            this.RedactTxtEmail.Location = new System.Drawing.Point(335, 110);
            this.RedactTxtEmail.Name = "RedactTxtEmail";
            this.RedactTxtEmail.Size = new System.Drawing.Size(100, 34);
            this.RedactTxtEmail.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(237, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Email";
            // 
            // RedactTxtPhone
            // 
            this.RedactTxtPhone.Location = new System.Drawing.Point(104, 110);
            this.RedactTxtPhone.Name = "RedactTxtPhone";
            this.RedactTxtPhone.Size = new System.Drawing.Size(100, 34);
            this.RedactTxtPhone.TabIndex = 19;
            // 
            // RedactPhone
            // 
            this.RedactPhone.AutoSize = true;
            this.RedactPhone.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedactPhone.Location = new System.Drawing.Point(6, 117);
            this.RedactPhone.Name = "RedactPhone";
            this.RedactPhone.Size = new System.Drawing.Size(49, 20);
            this.RedactPhone.TabIndex = 18;
            this.RedactPhone.Text = "电话";
            // 
            // RedactTxtBrithday
            // 
            this.RedactTxtBrithday.Location = new System.Drawing.Point(569, 68);
            this.RedactTxtBrithday.Name = "RedactTxtBrithday";
            this.RedactTxtBrithday.Size = new System.Drawing.Size(100, 34);
            this.RedactTxtBrithday.TabIndex = 17;
            // 
            // RedactBrithday
            // 
            this.RedactBrithday.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedactBrithday.Location = new System.Drawing.Point(471, 75);
            this.RedactBrithday.Name = "RedactBrithday";
            this.RedactBrithday.Size = new System.Drawing.Size(79, 20);
            this.RedactBrithday.TabIndex = 16;
            this.RedactBrithday.Text = "生日";
            // 
            // RedactTxtSex
            // 
            this.RedactTxtSex.Location = new System.Drawing.Point(335, 68);
            this.RedactTxtSex.Name = "RedactTxtSex";
            this.RedactTxtSex.Size = new System.Drawing.Size(100, 34);
            this.RedactTxtSex.TabIndex = 15;
            // 
            // RedactSex
            // 
            this.RedactSex.AutoSize = true;
            this.RedactSex.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedactSex.Location = new System.Drawing.Point(237, 75);
            this.RedactSex.Name = "RedactSex";
            this.RedactSex.Size = new System.Drawing.Size(49, 20);
            this.RedactSex.TabIndex = 14;
            this.RedactSex.Text = "性别";
            // 
            // RedactTxtName
            // 
            this.RedactTxtName.Location = new System.Drawing.Point(104, 68);
            this.RedactTxtName.Name = "RedactTxtName";
            this.RedactTxtName.Size = new System.Drawing.Size(100, 34);
            this.RedactTxtName.TabIndex = 13;
            // 
            // RedactName
            // 
            this.RedactName.AutoSize = true;
            this.RedactName.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.RedactName.Location = new System.Drawing.Point(6, 75);
            this.RedactName.Name = "RedactName";
            this.RedactName.Size = new System.Drawing.Size(49, 20);
            this.RedactName.TabIndex = 12;
            this.RedactName.Text = "姓名";
            // 
            // Crud
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(901, 553);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.添加);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Crud";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生信息";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.添加.ResumeLayout(false);
            this.添加.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox 添加;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label AddName;
        private System.Windows.Forms.TextBox AddBoxClass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AddBoxEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AddBoxPhone;
        private System.Windows.Forms.Label AddPhone;
        private System.Windows.Forms.TextBox AddBoxBrithday;
        private System.Windows.Forms.Label AddBirthday;
        private System.Windows.Forms.TextBox AddBoxSex;
        private System.Windows.Forms.Label Sex;
        private System.Windows.Forms.TextBox AddBoxName;
        private System.Windows.Forms.TextBox RedactTxtClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RedactTxtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox RedactTxtPhone;
        private System.Windows.Forms.Label RedactPhone;
        private System.Windows.Forms.TextBox RedactTxtBrithday;
        private System.Windows.Forms.Label RedactBrithday;
        private System.Windows.Forms.TextBox RedactTxtSex;
        private System.Windows.Forms.Label RedactSex;
        private System.Windows.Forms.TextBox RedactTxtName;
        private System.Windows.Forms.Label RedactName;
        private System.Windows.Forms.Label CurrentId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label LabeID;
        private System.Windows.Forms.Button Add;
    }
}

