namespace smallTalk
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
            this.components = new System.ComponentModel.Container();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.Label_Name = new System.Windows.Forms.Label();
            this.label_Name2 = new System.Windows.Forms.Label();
            this.textBox_Name2 = new System.Windows.Forms.TextBox();
            this.textBox_talk = new System.Windows.Forms.TextBox();
            this.button_send = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // textBox_Name
            // 
            this.textBox_Name.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Name.Location = new System.Drawing.Point(178, 6);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(166, 42);
            this.textBox_Name.TabIndex = 0;
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Label_Name.Location = new System.Drawing.Point(12, 18);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(73, 30);
            this.Label_Name.TabIndex = 1;
            this.Label_Name.Text = "昵称";
            // 
            // label_Name2
            // 
            this.label_Name2.AutoSize = true;
            this.label_Name2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_Name2.Location = new System.Drawing.Point(12, 66);
            this.label_Name2.Name = "label_Name2";
            this.label_Name2.Size = new System.Drawing.Size(133, 30);
            this.label_Name2.TabIndex = 2;
            this.label_Name2.Text = "对方昵称";
            // 
            // textBox_Name2
            // 
            this.textBox_Name2.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_Name2.Location = new System.Drawing.Point(177, 54);
            this.textBox_Name2.Name = "textBox_Name2";
            this.textBox_Name2.Size = new System.Drawing.Size(167, 42);
            this.textBox_Name2.TabIndex = 3;
            // 
            // textBox_talk
            // 
            this.textBox_talk.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_talk.Location = new System.Drawing.Point(209, 361);
            this.textBox_talk.Name = "textBox_talk";
            this.textBox_talk.Size = new System.Drawing.Size(427, 42);
            this.textBox_talk.TabIndex = 4;
            this.textBox_talk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_talk_KeyPress);
            // 
            // button_send
            // 
            this.button_send.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_send.Location = new System.Drawing.Point(642, 361);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(135, 42);
            this.button_send.TabIndex = 5;
            this.button_send.Text = "发送";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.Button1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Location = new System.Drawing.Point(386, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 323);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "时间";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "昵称";
            this.columnHeader3.Width = 50;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "消息";
            this.columnHeader4.Width = 800;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.textBox_talk);
            this.Controls.Add(this.textBox_Name2);
            this.Controls.Add(this.label_Name2);
            this.Controls.Add(this.Label_Name);
            this.Controls.Add(this.textBox_Name);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.Label label_Name2;
        private System.Windows.Forms.TextBox textBox_Name2;
        private System.Windows.Forms.TextBox textBox_talk;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

