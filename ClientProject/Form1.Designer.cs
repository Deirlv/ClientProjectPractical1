namespace ClientProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxIP = new TextBox();
            textBox2 = new TextBox();
            btnSend = new Button();
            textBoxPort = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxIP
            // 
            textBoxIP.Location = new Point(12, 37);
            textBoxIP.Name = "textBoxIP";
            textBoxIP.Size = new Size(149, 23);
            textBoxIP.TabIndex = 0;
            textBoxIP.Text = "192.168.56.1";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 104);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(543, 311);
            textBox2.TabIndex = 1;
            // 
            // btnSend
            // 
            btnSend.Location = new Point(607, 104);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // textBoxPort
            // 
            textBoxPort.Location = new Point(239, 37);
            textBoxPort.Name = "textBoxPort";
            textBoxPort.Size = new Size(149, 23);
            textBoxPort.TabIndex = 3;
            textBoxPort.Text = "1024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(17, 15);
            label1.TabIndex = 4;
            label1.Text = "IP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 9);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 5;
            label2.Text = "Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPort);
            Controls.Add(btnSend);
            Controls.Add(textBox2);
            Controls.Add(textBoxIP);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIP;
        private TextBox textBox2;
        private Button btnSend;
        private TextBox textBoxPort;
        private Label label1;
        private Label label2;
    }
}
