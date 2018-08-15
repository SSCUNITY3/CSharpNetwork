namespace WindowsFormsApp1
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
            this.ipAddressLabel = new System.Windows.Forms.Label();
            this.portNumberLabel = new System.Windows.Forms.Label();
            this.ipAddressTextBox = new System.Windows.Forms.TextBox();
            this.portNumberTextBox = new System.Windows.Forms.TextBox();
            this.sendTextBox = new System.Windows.Forms.TextBox();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ipAddressLabel
            // 
            this.ipAddressLabel.AutoSize = true;
            this.ipAddressLabel.Location = new System.Drawing.Point(12, 43);
            this.ipAddressLabel.Name = "ipAddressLabel";
            this.ipAddressLabel.Size = new System.Drawing.Size(76, 17);
            this.ipAddressLabel.TabIndex = 0;
            this.ipAddressLabel.Text = "IP Address";
            // 
            // portNumberLabel
            // 
            this.portNumberLabel.AutoSize = true;
            this.portNumberLabel.Location = new System.Drawing.Point(12, 101);
            this.portNumberLabel.Name = "portNumberLabel";
            this.portNumberLabel.Size = new System.Drawing.Size(88, 17);
            this.portNumberLabel.TabIndex = 1;
            this.portNumberLabel.Text = "Port Number";
            // 
            // ipAddressTextBox
            // 
            this.ipAddressTextBox.Location = new System.Drawing.Point(106, 43);
            this.ipAddressTextBox.Name = "ipAddressTextBox";
            this.ipAddressTextBox.Size = new System.Drawing.Size(571, 22);
            this.ipAddressTextBox.TabIndex = 2;
            this.ipAddressTextBox.TextChanged += new System.EventHandler(this.ipAddressTextBox_TextChanged);
            // 
            // portNumberTextBox
            // 
            this.portNumberTextBox.Location = new System.Drawing.Point(106, 101);
            this.portNumberTextBox.Name = "portNumberTextBox";
            this.portNumberTextBox.Size = new System.Drawing.Size(571, 22);
            this.portNumberTextBox.TabIndex = 3;
            // 
            // sendTextBox
            // 
            this.sendTextBox.Location = new System.Drawing.Point(15, 221);
            this.sendTextBox.Multiline = true;
            this.sendTextBox.Name = "sendTextBox";
            this.sendTextBox.Size = new System.Drawing.Size(306, 149);
            this.sendTextBox.TabIndex = 4;
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(355, 221);
            this.displayTextBox.Multiline = true;
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(306, 149);
            this.displayTextBox.TabIndex = 5;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(283, 161);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(105, 28);
            this.connectButton.TabIndex = 6;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(15, 376);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(105, 28);
            this.sendButton.TabIndex = 7;
            this.sendButton.Text = "Send To Server";
            this.sendButton.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(556, 376);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(105, 28);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.sendTextBox);
            this.Controls.Add(this.portNumberTextBox);
            this.Controls.Add(this.ipAddressTextBox);
            this.Controls.Add(this.portNumberLabel);
            this.Controls.Add(this.ipAddressLabel);
            this.Name = "Form1";
            this.Text = "SSC NetworkTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ipAddressLabel;
        private System.Windows.Forms.Label portNumberLabel;
        private System.Windows.Forms.TextBox ipAddressTextBox;
        private System.Windows.Forms.TextBox portNumberTextBox;
        private System.Windows.Forms.TextBox sendTextBox;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.Button closeButton;
    }
}