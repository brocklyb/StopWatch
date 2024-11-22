namespace Stopwatch
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
            btn_start = new Button();
            btn_stop = new Button();
            btn_reset = new Button();
            textBox_total_time = new TextBox();
            textBox_delta = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_start
            // 
            btn_start.Location = new Point(21, 156);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 0;
            btn_start.Text = "Start";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // btn_stop
            // 
            btn_stop.Location = new Point(21, 185);
            btn_stop.Name = "btn_stop";
            btn_stop.Size = new Size(75, 23);
            btn_stop.TabIndex = 1;
            btn_stop.Text = "Stop";
            btn_stop.UseVisualStyleBackColor = true;
            btn_stop.Click += btn_stop_Click;
            // 
            // btn_reset
            // 
            btn_reset.Location = new Point(21, 214);
            btn_reset.Name = "btn_reset";
            btn_reset.Size = new Size(75, 23);
            btn_reset.TabIndex = 2;
            btn_reset.Text = "Reset";
            btn_reset.UseVisualStyleBackColor = true;
            btn_reset.Click += btn_reset_Click;
            // 
            // textBox_total_time
            // 
            textBox_total_time.Location = new Point(21, 36);
            textBox_total_time.Name = "textBox_total_time";
            textBox_total_time.Size = new Size(100, 23);
            textBox_total_time.TabIndex = 3;
            // 
            // textBox_delta
            // 
            textBox_delta.Location = new Point(21, 90);
            textBox_delta.Name = "textBox_delta";
            textBox_delta.Size = new Size(100, 23);
            textBox_delta.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 5;
            label1.Text = "Timer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 72);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 6;
            label2.Text = "Delta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(194, 387);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_delta);
            Controls.Add(textBox_total_time);
            Controls.Add(btn_reset);
            Controls.Add(btn_stop);
            Controls.Add(btn_start);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_start;
        private Button btn_stop;
        private Button btn_reset;
        private TextBox textBox_total_time;
        private TextBox textBox_delta;
        private Label label1;
        private Label label2;
    }
}
