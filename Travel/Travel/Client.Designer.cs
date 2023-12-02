
namespace Travel
{
    partial class Client
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
            this.connectButton = new System.Windows.Forms.Button();
            this.localaddrLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.addrTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.keyLabel = new System.Windows.Forms.Label();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.logLabel = new System.Windows.Forms.Label();
            this.logTextBox = new System.Windows.Forms.TextBox();
            this.sendLabel = new System.Windows.Forms.Label();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(54, 44);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(122, 42);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // localaddrLabel
            // 
            this.localaddrLabel.AutoSize = true;
            this.localaddrLabel.Location = new System.Drawing.Point(245, 44);
            this.localaddrLabel.Name = "localaddrLabel";
            this.localaddrLabel.Size = new System.Drawing.Size(60, 17);
            this.localaddrLabel.TabIndex = 1;
            this.localaddrLabel.Text = "Address";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(245, 69);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(73, 17);
            this.usernameLabel.TabIndex = 2;
            this.usernameLabel.Text = "Username";
            // 
            // addrTextBox
            // 
            this.addrTextBox.Location = new System.Drawing.Point(325, 41);
            this.addrTextBox.Multiline = true;
            this.addrTextBox.Name = "addrTextBox";
            this.addrTextBox.Size = new System.Drawing.Size(115, 24);
            this.addrTextBox.TabIndex = 3;
            this.addrTextBox.Text = "127.0.0.1";
            this.addrTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(325, 71);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(115, 22);
            this.usernameTextBox.TabIndex = 4;
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(477, 44);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 17);
            this.portLabel.TabIndex = 5;
            this.portLabel.Text = "Port";
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(477, 76);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(32, 17);
            this.keyLabel.TabIndex = 6;
            this.keyLabel.Text = "Key";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(546, 43);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 22);
            this.portTextBox.TabIndex = 7;
            this.portTextBox.Text = "9000";
            this.portTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // keyTextBox
            // 
            this.keyTextBox.Location = new System.Drawing.Point(546, 76);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(101, 22);
            this.keyTextBox.TabIndex = 8;
            this.keyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(546, 113);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(59, 21);
            this.checkBox.TabIndex = 9;
            this.checkBox.Text = "Hide";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(546, 140);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 29);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // logLabel
            // 
            this.logLabel.AutoSize = true;
            this.logLabel.Location = new System.Drawing.Point(352, 167);
            this.logLabel.Name = "logLabel";
            this.logLabel.Size = new System.Drawing.Size(32, 17);
            this.logLabel.TabIndex = 11;
            this.logLabel.Text = "Log";
            // 
            // logTextBox
            // 
            this.logTextBox.Location = new System.Drawing.Point(6, 187);
            this.logTextBox.Multiline = true;
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.Size = new System.Drawing.Size(782, 193);
            this.logTextBox.TabIndex = 12;
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // sendLabel
            // 
            this.sendLabel.AutoSize = true;
            this.sendLabel.Location = new System.Drawing.Point(12, 383);
            this.sendLabel.Name = "sendLabel";
            this.sendLabel.Size = new System.Drawing.Size(41, 17);
            this.sendLabel.TabIndex = 13;
            this.sendLabel.Text = "Send";
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(15, 399);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(773, 39);
            this.sendTextBox.TabIndex = 14;
            this.sendTextBox.TextChanged += new System.EventHandler(this.sendTextBox_TextChanged);
            this.sendTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sendTextBox_KeyDown);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 459);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.sendLabel);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.logLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.keyLabel);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.addrTextBox);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.localaddrLabel);
            this.Controls.Add(this.connectButton);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label localaddrLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox addrTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label logLabel;
        private System.Windows.Forms.TextBox logTextBox;
        private System.Windows.Forms.Label sendLabel;
        private System.Windows.Forms.TextBox sendTextBox;
    }
}