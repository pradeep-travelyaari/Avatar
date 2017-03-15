namespace MonthlyCalculator
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginID = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.txtboxlogin = new System.Windows.Forms.TextBox();
            this.txtboxpwd = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.loginmsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginID
            // 
            this.LoginID.AutoSize = true;
            this.LoginID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginID.ForeColor = System.Drawing.Color.DarkGreen;
            this.LoginID.Location = new System.Drawing.Point(98, 104);
            this.LoginID.Name = "LoginID";
            this.LoginID.Size = new System.Drawing.Size(68, 17);
            this.LoginID.TabIndex = 0;
            this.LoginID.Text = "Login ID";
            this.LoginID.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.Color.DarkGreen;
            this.Password.Location = new System.Drawing.Point(98, 149);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(77, 17);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtboxlogin
            // 
            this.txtboxlogin.Location = new System.Drawing.Point(194, 104);
            this.txtboxlogin.Name = "txtboxlogin";
            this.txtboxlogin.Size = new System.Drawing.Size(189, 20);
            this.txtboxlogin.TabIndex = 3;
            this.txtboxlogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtboxpwd
            // 
            this.txtboxpwd.Location = new System.Drawing.Point(194, 149);
            this.txtboxpwd.Name = "txtboxpwd";
            this.txtboxpwd.Size = new System.Drawing.Size(189, 20);
            this.txtboxpwd.TabIndex = 4;
            this.txtboxpwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnlogin.Location = new System.Drawing.Point(194, 198);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(84, 35);
            this.btnlogin.TabIndex = 5;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // loginmsg
            // 
            this.loginmsg.AutoSize = true;
            this.loginmsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginmsg.ForeColor = System.Drawing.Color.ForestGreen;
            this.loginmsg.Location = new System.Drawing.Point(191, 66);
            this.loginmsg.Name = "loginmsg";
            this.loginmsg.Size = new System.Drawing.Size(0, 17);
            this.loginmsg.TabIndex = 6;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 284);
            this.Controls.Add(this.loginmsg);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtboxpwd);
            this.Controls.Add(this.txtboxlogin);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.LoginID);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MonthlyCalculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox txtboxlogin;
        private System.Windows.Forms.TextBox txtboxpwd;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label loginmsg;
    }
}

