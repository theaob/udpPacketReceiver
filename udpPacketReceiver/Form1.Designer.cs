namespace udpPacketReceiver
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.receivePortBox = new System.Windows.Forms.TextBox();
            this.startStopListenButton = new System.Windows.Forms.Button();
            this.saveMessagesButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.commandIDBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receive Port:";
            // 
            // receivePortBox
            // 
            this.receivePortBox.Location = new System.Drawing.Point(90, 6);
            this.receivePortBox.Name = "receivePortBox";
            this.receivePortBox.Size = new System.Drawing.Size(100, 20);
            this.receivePortBox.TabIndex = 1;
            this.receivePortBox.Text = "49003";
            // 
            // startStopListenButton
            // 
            this.startStopListenButton.Location = new System.Drawing.Point(115, 55);
            this.startStopListenButton.Name = "startStopListenButton";
            this.startStopListenButton.Size = new System.Drawing.Size(75, 23);
            this.startStopListenButton.TabIndex = 2;
            this.startStopListenButton.Text = "Start";
            this.startStopListenButton.UseVisualStyleBackColor = true;
            this.startStopListenButton.Click += new System.EventHandler(this.startStopListenButton_Click);
            // 
            // saveMessagesButton
            // 
            this.saveMessagesButton.Location = new System.Drawing.Point(113, 249);
            this.saveMessagesButton.Name = "saveMessagesButton";
            this.saveMessagesButton.Size = new System.Drawing.Size(75, 23);
            this.saveMessagesButton.TabIndex = 5;
            this.saveMessagesButton.Text = "Save";
            this.saveMessagesButton.UseVisualStyleBackColor = true;
            this.saveMessagesButton.Click += new System.EventHandler(this.saveMessagesButton_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Received : {{count}}";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 84);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 160);
            this.listBox1.TabIndex = 11;
            // 
            // commandIDBox
            // 
            this.commandIDBox.Location = new System.Drawing.Point(90, 29);
            this.commandIDBox.Name = "commandIDBox";
            this.commandIDBox.Size = new System.Drawing.Size(100, 20);
            this.commandIDBox.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Command ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 274);
            this.Controls.Add(this.commandIDBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saveMessagesButton);
            this.Controls.Add(this.startStopListenButton);
            this.Controls.Add(this.receivePortBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "XPlane Receiver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox receivePortBox;
        private System.Windows.Forms.Button startStopListenButton;
        private System.Windows.Forms.Button saveMessagesButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox commandIDBox;
        private System.Windows.Forms.Label label2;
    }
}

