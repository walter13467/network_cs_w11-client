﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button_sendAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_main = new System.Windows.Forms.TextBox();
            this.listBox_onlineList = new System.Windows.Forms.ListBox();
            this.button_send = new System.Windows.Forms.Button();
            this.textBox_sendMsg = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "伺服器IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "玩家名稱";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "伺服器Port";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "127.0.0.1";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(265, 14);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(69, 55);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "登入伺服器";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_sendAll
            // 
            this.button_sendAll.Location = new System.Drawing.Point(450, 12);
            this.button_sendAll.Name = "button_sendAll";
            this.button_sendAll.Size = new System.Drawing.Size(75, 23);
            this.button_sendAll.TabIndex = 7;
            this.button_sendAll.Text = "廣播";
            this.button_sendAll.UseVisualStyleBackColor = true;
            this.button_sendAll.Click += new System.EventHandler(this.button_sendAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "線上使用者";
            // 
            // textBox_main
            // 
            this.textBox_main.Location = new System.Drawing.Point(69, 118);
            this.textBox_main.Multiline = true;
            this.textBox_main.Name = "textBox_main";
            this.textBox_main.Size = new System.Drawing.Size(296, 232);
            this.textBox_main.TabIndex = 9;
            // 
            // listBox_onlineList
            // 
            this.listBox_onlineList.FormattingEnabled = true;
            this.listBox_onlineList.ItemHeight = 12;
            this.listBox_onlineList.Location = new System.Drawing.Point(435, 118);
            this.listBox_onlineList.Name = "listBox_onlineList";
            this.listBox_onlineList.Size = new System.Drawing.Size(120, 232);
            this.listBox_onlineList.TabIndex = 10;
            // 
            // button_send
            // 
            this.button_send.Enabled = false;
            this.button_send.Location = new System.Drawing.Point(435, 387);
            this.button_send.Name = "button_send";
            this.button_send.Size = new System.Drawing.Size(120, 23);
            this.button_send.TabIndex = 11;
            this.button_send.Text = "送出";
            this.button_send.UseVisualStyleBackColor = true;
            this.button_send.Click += new System.EventHandler(this.button_send_Click);
            // 
            // textBox_sendMsg
            // 
            this.textBox_sendMsg.Location = new System.Drawing.Point(133, 387);
            this.textBox_sendMsg.Name = "textBox_sendMsg";
            this.textBox_sendMsg.Size = new System.Drawing.Size(296, 22);
            this.textBox_sendMsg.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "發言內容";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(450, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "登出";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 422);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_sendMsg);
            this.Controls.Add(this.button_send);
            this.Controls.Add(this.listBox_onlineList);
            this.Controls.Add(this.textBox_main);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_sendAll);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "TCP 客戶端";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_sendAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_main;
        private System.Windows.Forms.ListBox listBox_onlineList;
        private System.Windows.Forms.Button button_send;
        private System.Windows.Forms.TextBox textBox_sendMsg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
    }
}

