namespace SnakesNLadders___Client
{
    partial class Host
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Host));
            this.btn_close_server = new System.Windows.Forms.Button();
            this.Status_textBox = new System.Windows.Forms.TextBox();
            this.Bind_button = new System.Windows.Forms.Button();
            this.ReceivePort_textBox = new System.Windows.Forms.TextBox();
            this.IP_Address_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfClients_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Message_textBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close_server
            // 
            this.btn_close_server.Location = new System.Drawing.Point(576, 266);
            this.btn_close_server.Name = "btn_close_server";
            this.btn_close_server.Size = new System.Drawing.Size(108, 31);
            this.btn_close_server.TabIndex = 0;
            this.btn_close_server.Text = "Close Server";
            this.btn_close_server.UseVisualStyleBackColor = true;
            this.btn_close_server.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status_textBox
            // 
            this.Status_textBox.Location = new System.Drawing.Point(488, 85);
            this.Status_textBox.Name = "Status_textBox";
            this.Status_textBox.ReadOnly = true;
            this.Status_textBox.Size = new System.Drawing.Size(187, 20);
            this.Status_textBox.TabIndex = 12;
            // 
            // Bind_button
            // 
            this.Bind_button.Location = new System.Drawing.Point(36, 101);
            this.Bind_button.Name = "Bind_button";
            this.Bind_button.Size = new System.Drawing.Size(95, 37);
            this.Bind_button.TabIndex = 6;
            this.Bind_button.Text = "Start Server";
            this.Bind_button.UseVisualStyleBackColor = true;
            this.Bind_button.Click += new System.EventHandler(this.Bind_button_Click_1);
            // 
            // ReceivePort_textBox
            // 
            this.ReceivePort_textBox.Location = new System.Drawing.Point(136, 56);
            this.ReceivePort_textBox.Name = "ReceivePort_textBox";
            this.ReceivePort_textBox.Size = new System.Drawing.Size(69, 20);
            this.ReceivePort_textBox.TabIndex = 5;
            // 
            // IP_Address_textBox
            // 
            this.IP_Address_textBox.Location = new System.Drawing.Point(136, 19);
            this.IP_Address_textBox.Name = "IP_Address_textBox";
            this.IP_Address_textBox.ReadOnly = true;
            this.IP_Address_textBox.Size = new System.Drawing.Size(131, 20);
            this.IP_Address_textBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Local IP Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(33, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port for receiving :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(485, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Player\'s Online :";
            // 
            // NumberOfClients_textBox
            // 
            this.NumberOfClients_textBox.Location = new System.Drawing.Point(583, 23);
            this.NumberOfClients_textBox.Name = "NumberOfClients_textBox";
            this.NumberOfClients_textBox.ReadOnly = true;
            this.NumberOfClients_textBox.Size = new System.Drawing.Size(36, 20);
            this.NumberOfClients_textBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(485, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Recent Activity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(304, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Messages Received :";
            // 
            // Message_textBox
            // 
            this.Message_textBox.Location = new System.Drawing.Point(306, 157);
            this.Message_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.Message_textBox.Name = "Message_textBox";
            this.Message_textBox.ReadOnly = true;
            this.Message_textBox.Size = new System.Drawing.Size(379, 90);
            this.Message_textBox.TabIndex = 19;
            this.Message_textBox.Text = "";
            this.Message_textBox.TextChanged += new System.EventHandler(this.Message_textBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(304, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Connected Users";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(307, 43);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(121, 84);
            this.listBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(11, 153);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "\"Server Feed\"";
            this.label7.Visible = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Host
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 318);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Message_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NumberOfClients_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Status_textBox);
            this.Controls.Add(this.btn_close_server);
            this.Controls.Add(this.ReceivePort_textBox);
            this.Controls.Add(this.Bind_button);
            this.Controls.Add(this.IP_Address_textBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Host";
            this.Text = "Server Hosting - System Programming Project";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close_server;
        private System.Windows.Forms.TextBox ReceivePort_textBox;
        private System.Windows.Forms.TextBox Status_textBox;
        private System.Windows.Forms.Button Bind_button;
        private System.Windows.Forms.TextBox IP_Address_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NumberOfClients_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox Message_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
    }
}