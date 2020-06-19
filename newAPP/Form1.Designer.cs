namespace newAPP
{
    partial class Form1
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
            this.name = new System.Windows.Forms.Label();
            this.bandcard = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.sex = new System.Windows.Forms.Label();
            this.homes = new System.Windows.Forms.Label();
            this.until = new System.Windows.Forms.Label();
            this.phonenum = new System.Windows.Forms.Label();
            this.qq = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.remarks = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.T_name = new System.Windows.Forms.TextBox();
            this.T_bandcard = new System.Windows.Forms.TextBox();
            this.T_sex = new System.Windows.Forms.ComboBox();
            this.T_age = new System.Windows.Forms.TextBox();
            this.T_homes = new System.Windows.Forms.TextBox();
            this.T_until = new System.Windows.Forms.TextBox();
            this.T_phonenum = new System.Windows.Forms.TextBox();
            this.T_qq = new System.Windows.Forms.TextBox();
            this.T_email = new System.Windows.Forms.TextBox();
            this.T_remark = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(80, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(94, 21);
            this.name.TabIndex = 0;
            this.name.Text = "用户姓名";
            // 
            // bandcard
            // 
            this.bandcard.AutoSize = true;
            this.bandcard.Location = new System.Drawing.Point(501, 42);
            this.bandcard.Name = "bandcard";
            this.bandcard.Size = new System.Drawing.Size(115, 21);
            this.bandcard.TabIndex = 1;
            this.bandcard.Text = "用户身份证\r\n";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Location = new System.Drawing.Point(501, 110);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(94, 21);
            this.age.TabIndex = 2;
            this.age.Text = "用户年龄";
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.Location = new System.Drawing.Point(80, 107);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(94, 21);
            this.sex.TabIndex = 3;
            this.sex.Text = "用户性别";
            // 
            // homes
            // 
            this.homes.AutoSize = true;
            this.homes.Location = new System.Drawing.Point(80, 172);
            this.homes.Name = "homes";
            this.homes.Size = new System.Drawing.Size(94, 21);
            this.homes.TabIndex = 4;
            this.homes.Text = "用户籍贯";
            // 
            // until
            // 
            this.until.AutoSize = true;
            this.until.Location = new System.Drawing.Point(501, 175);
            this.until.Name = "until";
            this.until.Size = new System.Drawing.Size(94, 21);
            this.until.TabIndex = 5;
            this.until.Text = "用户单位";
            // 
            // phonenum
            // 
            this.phonenum.AutoSize = true;
            this.phonenum.Location = new System.Drawing.Point(80, 247);
            this.phonenum.Name = "phonenum";
            this.phonenum.Size = new System.Drawing.Size(115, 21);
            this.phonenum.TabIndex = 14;
            this.phonenum.Text = "用户手机号";
            this.phonenum.Click += new System.EventHandler(this.label7_Click);
            // 
            // qq
            // 
            this.qq.AutoSize = true;
            this.qq.Location = new System.Drawing.Point(501, 243);
            this.qq.Name = "qq";
            this.qq.Size = new System.Drawing.Size(95, 21);
            this.qq.TabIndex = 15;
            this.qq.Text = "用户QQ号";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(80, 307);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(107, 21);
            this.Email.TabIndex = 17;
            this.Email.Text = "用户Email";
            // 
            // remarks
            // 
            this.remarks.AutoSize = true;
            this.remarks.Location = new System.Drawing.Point(95, 384);
            this.remarks.Name = "remarks";
            this.remarks.Size = new System.Drawing.Size(52, 21);
            this.remarks.TabIndex = 19;
            this.remarks.Text = "备注";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(229, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "确定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // T_name
            // 
            this.T_name.Location = new System.Drawing.Point(202, 35);
            this.T_name.Name = "T_name";
            this.T_name.Size = new System.Drawing.Size(259, 31);
            this.T_name.TabIndex = 23;
            // 
            // T_bandcard
            // 
            this.T_bandcard.Location = new System.Drawing.Point(639, 32);
            this.T_bandcard.Name = "T_bandcard";
            this.T_bandcard.Size = new System.Drawing.Size(259, 31);
            this.T_bandcard.TabIndex = 24;
            // 
            // T_sex
            // 
            this.T_sex.FormattingEnabled = true;
            this.T_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.T_sex.Location = new System.Drawing.Point(202, 98);
            this.T_sex.Name = "T_sex";
            this.T_sex.Size = new System.Drawing.Size(259, 29);
            this.T_sex.TabIndex = 25;
            // 
            // T_age
            // 
            this.T_age.Location = new System.Drawing.Point(639, 100);
            this.T_age.Name = "T_age";
            this.T_age.Size = new System.Drawing.Size(259, 31);
            this.T_age.TabIndex = 26;
            // 
            // T_homes
            // 
            this.T_homes.Location = new System.Drawing.Point(202, 169);
            this.T_homes.Name = "T_homes";
            this.T_homes.Size = new System.Drawing.Size(259, 31);
            this.T_homes.TabIndex = 27;
            // 
            // T_until
            // 
            this.T_until.Location = new System.Drawing.Point(639, 175);
            this.T_until.Name = "T_until";
            this.T_until.Size = new System.Drawing.Size(259, 31);
            this.T_until.TabIndex = 28;
            // 
            // T_phonenum
            // 
            this.T_phonenum.Location = new System.Drawing.Point(202, 240);
            this.T_phonenum.Name = "T_phonenum";
            this.T_phonenum.Size = new System.Drawing.Size(259, 31);
            this.T_phonenum.TabIndex = 29;
            // 
            // T_qq
            // 
            this.T_qq.Location = new System.Drawing.Point(639, 244);
            this.T_qq.Name = "T_qq";
            this.T_qq.Size = new System.Drawing.Size(259, 31);
            this.T_qq.TabIndex = 30;
            // 
            // T_email
            // 
            this.T_email.Location = new System.Drawing.Point(202, 297);
            this.T_email.Name = "T_email";
            this.T_email.Size = new System.Drawing.Size(259, 31);
            this.T_email.TabIndex = 31;
            // 
            // T_remark
            // 
            this.T_remark.Location = new System.Drawing.Point(187, 373);
            this.T_remark.Multiline = true;
            this.T_remark.Name = "T_remark";
            this.T_remark.Size = new System.Drawing.Size(711, 199);
            this.T_remark.TabIndex = 32;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 620);
            this.Controls.Add(this.T_remark);
            this.Controls.Add(this.T_email);
            this.Controls.Add(this.T_qq);
            this.Controls.Add(this.T_phonenum);
            this.Controls.Add(this.T_until);
            this.Controls.Add(this.T_homes);
            this.Controls.Add(this.T_age);
            this.Controls.Add(this.T_sex);
            this.Controls.Add(this.T_bandcard);
            this.Controls.Add(this.T_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.remarks);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.qq);
            this.Controls.Add(this.phonenum);
            this.Controls.Add(this.until);
            this.Controls.Add(this.homes);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.bandcard);
            this.Controls.Add(this.name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label bandcard;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.Label homes;
        private System.Windows.Forms.Label until;
        private System.Windows.Forms.Label phonenum;
        private System.Windows.Forms.Label qq;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label remarks;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox T_name;
        private System.Windows.Forms.TextBox T_bandcard;
        private System.Windows.Forms.ComboBox T_sex;
        private System.Windows.Forms.TextBox T_age;
        private System.Windows.Forms.TextBox T_homes;
        private System.Windows.Forms.TextBox T_until;
        private System.Windows.Forms.TextBox T_phonenum;
        private System.Windows.Forms.TextBox T_qq;
        private System.Windows.Forms.TextBox T_email;
        private System.Windows.Forms.TextBox T_remark;
    }
}

