namespace DoublePendulum
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.L1Scroll = new System.Windows.Forms.TrackBar();
            this.L1Label = new System.Windows.Forms.Label();
            this.L1TextBox = new System.Windows.Forms.TextBox();
            this.L2Scroll = new System.Windows.Forms.TrackBar();
            this.L2Label = new System.Windows.Forms.Label();
            this.L2TextBox = new System.Windows.Forms.TextBox();
            this.θ2Scroll = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.θ2TextBox = new System.Windows.Forms.TextBox();
            this.θ1Scroll = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.θ1TextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.m2TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m1TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.v2TextBox = new System.Windows.Forms.TextBox();
            this.v1TextBox = new System.Windows.Forms.TextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Record = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.θ2Scroll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.θ1Scroll)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(600, 615);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(1150, 577);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(100, 50);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // L1Scroll
            // 
            this.L1Scroll.BackColor = System.Drawing.SystemColors.Control;
            this.L1Scroll.Location = new System.Drawing.Point(829, 172);
            this.L1Scroll.Maximum = 100;
            this.L1Scroll.Minimum = 1;
            this.L1Scroll.Name = "L1Scroll";
            this.L1Scroll.Size = new System.Drawing.Size(421, 56);
            this.L1Scroll.TabIndex = 4;
            this.L1Scroll.TickFrequency = 90;
            this.L1Scroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.L1Scroll.Value = 50;
            this.L1Scroll.Scroll += new System.EventHandler(this.L1Scroll_Scroll);
            // 
            // L1Label
            // 
            this.L1Label.AutoSize = true;
            this.L1Label.Location = new System.Drawing.Point(683, 178);
            this.L1Label.Name = "L1Label";
            this.L1Label.Size = new System.Drawing.Size(34, 16);
            this.L1Label.TabIndex = 5;
            this.L1Label.Text = "L1 = ";
            // 
            // L1TextBox
            // 
            this.L1TextBox.Location = new System.Drawing.Point(723, 172);
            this.L1TextBox.Name = "L1TextBox";
            this.L1TextBox.Size = new System.Drawing.Size(100, 22);
            this.L1TextBox.TabIndex = 6;
            this.L1TextBox.Text = "50";
            this.L1TextBox.TextChanged += new System.EventHandler(this.L1TextBox_TextChanged);
            // 
            // L2Scroll
            // 
            this.L2Scroll.BackColor = System.Drawing.SystemColors.Control;
            this.L2Scroll.Location = new System.Drawing.Point(829, 234);
            this.L2Scroll.Maximum = 100;
            this.L2Scroll.Minimum = 1;
            this.L2Scroll.Name = "L2Scroll";
            this.L2Scroll.Size = new System.Drawing.Size(421, 56);
            this.L2Scroll.TabIndex = 4;
            this.L2Scroll.TickFrequency = 90;
            this.L2Scroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.L2Scroll.Value = 50;
            this.L2Scroll.Scroll += new System.EventHandler(this.L2Scroll_Scroll);
            // 
            // L2Label
            // 
            this.L2Label.AutoSize = true;
            this.L2Label.Location = new System.Drawing.Point(683, 240);
            this.L2Label.Name = "L2Label";
            this.L2Label.Size = new System.Drawing.Size(34, 16);
            this.L2Label.TabIndex = 5;
            this.L2Label.Text = "L2 = ";
            // 
            // L2TextBox
            // 
            this.L2TextBox.Location = new System.Drawing.Point(723, 234);
            this.L2TextBox.Name = "L2TextBox";
            this.L2TextBox.Size = new System.Drawing.Size(100, 22);
            this.L2TextBox.TabIndex = 6;
            this.L2TextBox.Text = "50";
            this.L2TextBox.TextChanged += new System.EventHandler(this.L2TextBox_TextChanged);
            // 
            // θ2Scroll
            // 
            this.θ2Scroll.BackColor = System.Drawing.SystemColors.Control;
            this.θ2Scroll.Location = new System.Drawing.Point(829, 358);
            this.θ2Scroll.Maximum = 180;
            this.θ2Scroll.Minimum = -180;
            this.θ2Scroll.Name = "θ2Scroll";
            this.θ2Scroll.Size = new System.Drawing.Size(421, 56);
            this.θ2Scroll.TabIndex = 4;
            this.θ2Scroll.TickFrequency = 90;
            this.θ2Scroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.θ2Scroll.Scroll += new System.EventHandler(this.θ2Scroll_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(683, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "θ2 =\r\n";
            // 
            // θ2TextBox
            // 
            this.θ2TextBox.Location = new System.Drawing.Point(723, 358);
            this.θ2TextBox.Name = "θ2TextBox";
            this.θ2TextBox.Size = new System.Drawing.Size(100, 22);
            this.θ2TextBox.TabIndex = 6;
            this.θ2TextBox.Text = "0";
            this.θ2TextBox.TextChanged += new System.EventHandler(this.θ2TextBox_TextChanged);
            // 
            // θ1Scroll
            // 
            this.θ1Scroll.BackColor = System.Drawing.SystemColors.Control;
            this.θ1Scroll.Location = new System.Drawing.Point(829, 296);
            this.θ1Scroll.Maximum = 180;
            this.θ1Scroll.Minimum = -180;
            this.θ1Scroll.Name = "θ1Scroll";
            this.θ1Scroll.Size = new System.Drawing.Size(421, 56);
            this.θ1Scroll.TabIndex = 4;
            this.θ1Scroll.TickFrequency = 90;
            this.θ1Scroll.TickStyle = System.Windows.Forms.TickStyle.None;
            this.θ1Scroll.Scroll += new System.EventHandler(this.θ1Scroll_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(683, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "θ1 =";
            // 
            // θ1TextBox
            // 
            this.θ1TextBox.Location = new System.Drawing.Point(723, 296);
            this.θ1TextBox.Name = "θ1TextBox";
            this.θ1TextBox.Size = new System.Drawing.Size(100, 22);
            this.θ1TextBox.TabIndex = 6;
            this.θ1TextBox.Text = "0";
            this.θ1TextBox.TextChanged += new System.EventHandler(this.θ1TextBox_TextChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 20;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(1150, 466);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 50);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(683, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "g =";
            // 
            // gTextBox
            // 
            this.gTextBox.Location = new System.Drawing.Point(723, 12);
            this.gTextBox.Name = "gTextBox";
            this.gTextBox.Size = new System.Drawing.Size(100, 22);
            this.gTextBox.TabIndex = 6;
            this.gTextBox.Text = "9,81";
            this.gTextBox.TextChanged += new System.EventHandler(this.gTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(683, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "m2 =";
            // 
            // m2TextBox
            // 
            this.m2TextBox.Location = new System.Drawing.Point(723, 68);
            this.m2TextBox.Name = "m2TextBox";
            this.m2TextBox.Size = new System.Drawing.Size(100, 22);
            this.m2TextBox.TabIndex = 6;
            this.m2TextBox.Text = "1";
            this.m2TextBox.TextChanged += new System.EventHandler(this.m2TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(683, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "m1 =";
            // 
            // m1TextBox
            // 
            this.m1TextBox.Location = new System.Drawing.Point(723, 40);
            this.m1TextBox.Name = "m1TextBox";
            this.m1TextBox.Size = new System.Drawing.Size(100, 22);
            this.m1TextBox.TabIndex = 6;
            this.m1TextBox.Text = "1";
            this.m1TextBox.TextChanged += new System.EventHandler(this.m1TextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(955, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "v2 =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(955, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "v1 =";
            // 
            // v2TextBox
            // 
            this.v2TextBox.Location = new System.Drawing.Point(995, 68);
            this.v2TextBox.Name = "v2TextBox";
            this.v2TextBox.Size = new System.Drawing.Size(100, 22);
            this.v2TextBox.TabIndex = 6;
            this.v2TextBox.Text = "0";
            this.v2TextBox.TextChanged += new System.EventHandler(this.v2TextBox_TextChanged);
            // 
            // v1TextBox
            // 
            this.v1TextBox.Location = new System.Drawing.Point(995, 40);
            this.v1TextBox.Name = "v1TextBox";
            this.v1TextBox.Size = new System.Drawing.Size(100, 22);
            this.v1TextBox.TabIndex = 6;
            this.v1TextBox.Text = "0";
            this.v1TextBox.TextChanged += new System.EventHandler(this.v1TextBox_TextChanged);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(723, 466);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(100, 50);
            this.Reset.TabIndex = 7;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(940, 466);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(100, 50);
            this.Stop.TabIndex = 8;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Record
            // 
            this.Record.Location = new System.Drawing.Point(723, 577);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(100, 50);
            this.Record.TabIndex = 9;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(940, 577);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 50);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.θ1TextBox);
            this.Controls.Add(this.θ2TextBox);
            this.Controls.Add(this.L2TextBox);
            this.Controls.Add(this.v1TextBox);
            this.Controls.Add(this.m1TextBox);
            this.Controls.Add(this.v2TextBox);
            this.Controls.Add(this.m2TextBox);
            this.Controls.Add(this.gTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.L1TextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.L2Label);
            this.Controls.Add(this.L1Label);
            this.Controls.Add(this.θ1Scroll);
            this.Controls.Add(this.θ2Scroll);
            this.Controls.Add(this.L2Scroll);
            this.Controls.Add(this.L1Scroll);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Double Pendulum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L1Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L2Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.θ2Scroll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.θ1Scroll)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.TrackBar L1Scroll;
        private System.Windows.Forms.Label L1Label;
        private System.Windows.Forms.TextBox L1TextBox;
        private System.Windows.Forms.TrackBar L2Scroll;
        private System.Windows.Forms.Label L2Label;
        private System.Windows.Forms.TextBox L2TextBox;
        private System.Windows.Forms.TrackBar θ2Scroll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox θ2TextBox;
        private System.Windows.Forms.TrackBar θ1Scroll;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox θ1TextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox m2TextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m1TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox v2TextBox;
        private System.Windows.Forms.TextBox v1TextBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Save;
    }
}

