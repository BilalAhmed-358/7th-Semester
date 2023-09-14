namespace Question05
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
            label1 = new Label();
            x1 = new TextBox();
            x2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            y1 = new TextBox();
            y2 = new TextBox();
            Calculate = new Button();
            Results = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 26);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 0;
            label1.Text = "x1";
            label1.Click += label1_Click;
            // 
            // x1
            // 
            x1.Location = new Point(69, 23);
            x1.Name = "x1";
            x1.Size = new Size(100, 23);
            x1.TabIndex = 1;
            // 
            // x2
            // 
            x2.Location = new Point(69, 63);
            x2.Name = "x2";
            x2.Size = new Size(100, 23);
            x2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 66);
            label2.Name = "label2";
            label2.Size = new Size(19, 15);
            label2.TabIndex = 3;
            label2.Text = "x2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(341, 26);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 4;
            label3.Text = "y1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 71);
            label4.Name = "label4";
            label4.Size = new Size(19, 15);
            label4.TabIndex = 5;
            label4.Text = "y2";
            // 
            // y1
            // 
            y1.Location = new Point(377, 23);
            y1.Name = "y1";
            y1.Size = new Size(100, 23);
            y1.TabIndex = 6;
            // 
            // y2
            // 
            y2.Location = new Point(377, 68);
            y2.Name = "y2";
            y2.Size = new Size(100, 23);
            y2.TabIndex = 7;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(217, 117);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(75, 23);
            Calculate.TabIndex = 8;
            Calculate.Text = "Calculate";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Results
            // 
            Results.AutoSize = true;
            Results.Location = new Point(69, 184);
            Results.Name = "Results";
            Results.Size = new Size(44, 15);
            Results.TabIndex = 9;
            Results.Text = "Results";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 404);
            Controls.Add(Results);
            Controls.Add(Calculate);
            Controls.Add(y2);
            Controls.Add(y1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(x2);
            Controls.Add(x1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox x1;
        private TextBox x2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox y1;
        private TextBox y2;
        private Button Calculate;
        private Label Results;
    }
}