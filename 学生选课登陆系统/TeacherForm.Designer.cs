namespace 学生选课登陆系统
{
    partial class TeacherForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课要求ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息ToolStripMenuItem,
            this.选课信息ToolStripMenuItem,
            this.选课要求ToolStripMenuItem,
            this.选课成绩查询ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 个人信息ToolStripMenuItem
            // 
            this.个人信息ToolStripMenuItem.Name = "个人信息ToolStripMenuItem";
            this.个人信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.个人信息ToolStripMenuItem.Text = "个人信息";
            this.个人信息ToolStripMenuItem.Click += new System.EventHandler(this.个人信息ToolStripMenuItem_Click);
            // 
            // 选课信息ToolStripMenuItem
            // 
            this.选课信息ToolStripMenuItem.Name = "选课信息ToolStripMenuItem";
            this.选课信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选课信息ToolStripMenuItem.Text = "选课信息";
            this.选课信息ToolStripMenuItem.Click += new System.EventHandler(this.选课信息ToolStripMenuItem_Click);
            // 
            // 选课要求ToolStripMenuItem
            // 
            this.选课要求ToolStripMenuItem.Name = "选课要求ToolStripMenuItem";
            this.选课要求ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.选课要求ToolStripMenuItem.Text = "选课要求";
            this.选课要求ToolStripMenuItem.Click += new System.EventHandler(this.选课要求ToolStripMenuItem_Click);
            // 
            // 选课成绩查询ToolStripMenuItem
            // 
            this.选课成绩查询ToolStripMenuItem.Name = "选课成绩查询ToolStripMenuItem";
            this.选课成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.选课成绩查询ToolStripMenuItem.Text = "选课成绩查询";
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "欢迎";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(691, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "老师进入本系统";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(614, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(78, 21);
            this.textBox1.TabIndex = 3;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::学生选课登陆系统.Properties.Resources.bg3;
            this.ClientSize = new System.Drawing.Size(798, 335);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师系统";
            this.Load += new System.EventHandler(this.TeacherForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课要求ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}