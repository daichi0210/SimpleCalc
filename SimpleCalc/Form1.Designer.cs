namespace SimpleCalc
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
            input1TextBox = new TextBox();
            plusLabel = new Label();
            input2TextBox = new TextBox();
            equalLabel = new Label();
            answerTextBox = new TextBox();
            CalcButton = new Button();
            SuspendLayout();
            // 
            // input1TextBox
            // 
            input1TextBox.Location = new Point(12, 12);
            input1TextBox.Name = "input1TextBox";
            input1TextBox.Size = new Size(100, 23);
            input1TextBox.TabIndex = 0;
            // 
            // plusLabel
            // 
            plusLabel.AutoSize = true;
            plusLabel.Location = new Point(118, 15);
            plusLabel.Name = "plusLabel";
            plusLabel.Size = new Size(15, 15);
            plusLabel.TabIndex = 1;
            plusLabel.Text = "+";
            // 
            // input2TextBox
            // 
            input2TextBox.Location = new Point(139, 12);
            input2TextBox.Name = "input2TextBox";
            input2TextBox.Size = new Size(100, 23);
            input2TextBox.TabIndex = 2;
            // 
            // equalLabel
            // 
            equalLabel.AutoSize = true;
            equalLabel.Location = new Point(245, 15);
            equalLabel.Name = "equalLabel";
            equalLabel.Size = new Size(15, 15);
            equalLabel.TabIndex = 3;
            equalLabel.Text = "=";
            // 
            // answerTextBox
            // 
            answerTextBox.Location = new Point(266, 12);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(100, 23);
            answerTextBox.TabIndex = 4;
            // 
            // CalcButton
            // 
            CalcButton.Location = new Point(12, 41);
            CalcButton.Name = "CalcButton";
            CalcButton.Size = new Size(354, 23);
            CalcButton.TabIndex = 5;
            CalcButton.Text = "button1";
            CalcButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 71);
            Controls.Add(CalcButton);
            Controls.Add(answerTextBox);
            Controls.Add(equalLabel);
            Controls.Add(input2TextBox);
            Controls.Add(plusLabel);
            Controls.Add(input1TextBox);
            Name = "Form1";
            Text = "簡単計算プログラム";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox input1TextBox;
        private Label plusLabel;
        private TextBox input2TextBox;
        private Label equalLabel;
        private TextBox answerTextBox;
        private Button CalcButton;
    }
}
