namespace FilmServiceSystem
{
    partial class LogForm
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
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.LogButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PassTextBox = new System.Windows.Forms.TextBox();
            this.logPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.regOptionButton = new System.Windows.Forms.Button();
            this.logOptionButton = new System.Windows.Forms.Button();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.StartButton = new System.Windows.Forms.Button();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.snameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.logPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(53, 40);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(213, 20);
            this.LogTextBox.TabIndex = 1;
            this.LogTextBox.UseWaitCursor = true;
            // 
            // LogButton
            // 
            this.LogButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.LogButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogButton.ForeColor = System.Drawing.Color.White;
            this.LogButton.Location = new System.Drawing.Point(42, 146);
            this.LogButton.Name = "LogButton";
            this.LogButton.Size = new System.Drawing.Size(224, 27);
            this.LogButton.TabIndex = 2;
            this.LogButton.Text = "LOG IN";
            this.LogButton.UseVisualStyleBackColor = false;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "LOGIN";
            // 
            // PassTextBox
            // 
            this.PassTextBox.Location = new System.Drawing.Point(53, 86);
            this.PassTextBox.Name = "PassTextBox";
            this.PassTextBox.PasswordChar = '*';
            this.PassTextBox.Size = new System.Drawing.Size(213, 20);
            this.PassTextBox.TabIndex = 4;
            this.PassTextBox.UseWaitCursor = true;
            // 
            // logPanel
            // 
            this.logPanel.BackColor = System.Drawing.Color.Honeydew;
            this.logPanel.Controls.Add(this.LogButton);
            this.logPanel.Controls.Add(this.label1);
            this.logPanel.Controls.Add(this.PassTextBox);
            this.logPanel.Controls.Add(this.label2);
            this.logPanel.Controls.Add(this.LogTextBox);
            this.logPanel.Location = new System.Drawing.Point(3, 3);
            this.logPanel.Name = "logPanel";
            this.logPanel.Size = new System.Drawing.Size(495, 282);
            this.logPanel.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "PASSWORD";
            // 
            // regOptionButton
            // 
            this.regOptionButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.regOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regOptionButton.ForeColor = System.Drawing.Color.White;
            this.regOptionButton.Location = new System.Drawing.Point(110, 12);
            this.regOptionButton.Name = "regOptionButton";
            this.regOptionButton.Size = new System.Drawing.Size(86, 27);
            this.regOptionButton.TabIndex = 6;
            this.regOptionButton.Text = "REGISTER";
            this.regOptionButton.UseVisualStyleBackColor = false;
            this.regOptionButton.Click += new System.EventHandler(this.regOptionButton_Click);
            // 
            // logOptionButton
            // 
            this.logOptionButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.logOptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOptionButton.ForeColor = System.Drawing.Color.White;
            this.logOptionButton.Location = new System.Drawing.Point(15, 12);
            this.logOptionButton.Name = "logOptionButton";
            this.logOptionButton.Size = new System.Drawing.Size(89, 27);
            this.logOptionButton.TabIndex = 7;
            this.logOptionButton.Text = "LOG IN";
            this.logOptionButton.UseVisualStyleBackColor = false;
            this.logOptionButton.Click += new System.EventHandler(this.logOptionButton_Click);
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.Honeydew;
            this.registerPanel.Controls.Add(this.StartButton);
            this.registerPanel.Controls.Add(this.passTB);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Controls.Add(this.snameTB);
            this.registerPanel.Controls.Add(this.label5);
            this.registerPanel.Controls.Add(this.nameTB);
            this.registerPanel.Controls.Add(this.label4);
            this.registerPanel.Controls.Add(this.loginTB);
            this.registerPanel.Controls.Add(this.label3);
            this.registerPanel.Location = new System.Drawing.Point(3, 291);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(495, 285);
            this.registerPanel.TabIndex = 8;
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.Color.LightSeaGreen;
            this.StartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartButton.ForeColor = System.Drawing.Color.White;
            this.StartButton.Location = new System.Drawing.Point(298, 231);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(152, 27);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "GET STARTED";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // passTB
            // 
            this.passTB.Location = new System.Drawing.Point(132, 165);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(213, 20);
            this.passTB.TabIndex = 12;
            this.passTB.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(32, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password";
            // 
            // snameTB
            // 
            this.snameTB.Location = new System.Drawing.Point(132, 126);
            this.snameTB.Name = "snameTB";
            this.snameTB.Size = new System.Drawing.Size(213, 20);
            this.snameTB.TabIndex = 10;
            this.snameTB.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(32, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Surname";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(132, 78);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(213, 20);
            this.nameTB.TabIndex = 8;
            this.nameTB.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(32, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Name";
            // 
            // loginTB
            // 
            this.loginTB.Location = new System.Drawing.Point(132, 30);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(213, 20);
            this.loginTB.TabIndex = 6;
            this.loginTB.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(32, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Login";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.logPanel);
            this.flowLayoutPanel.Controls.Add(this.registerPanel);
            this.flowLayoutPanel.Location = new System.Drawing.Point(12, 45);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(498, 288);
            this.flowLayoutPanel.TabIndex = 9;
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(708, 345);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.logOptionButton);
            this.Controls.Add(this.regOptionButton);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "LogForm";
            this.Text = "LogForm";
            this.logPanel.ResumeLayout(false);
            this.logPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button LogButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PassTextBox;
        private System.Windows.Forms.Panel logPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button regOptionButton;
        private System.Windows.Forms.Button logOptionButton;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox snameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}