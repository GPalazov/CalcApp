namespace CalcApp
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
        /// 
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
        /// 

        //метод за инициализация на компонентите на формата
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Число №1 текстово поле
            // 
            textBox1.Location = new Point(36, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // Число №2 текстово поле
            // 
            textBox2.Location = new Point(225, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // бутон за събиране
            // 
            button1.BackColor = Color.BlueViolet;
            button1.Location = new Point(134, 129);
            button1.Name = "button1";
            button1.Size = new Size(40, 35);
            button1.TabIndex = 2;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonAddition_Click;
            // 
            // бутон за изваждане
            // 
            button2.BackColor = Color.Chartreuse;
            button2.Location = new Point(189, 129);
            button2.Name = "button2";
            button2.Size = new Size(40, 35);
            button2.TabIndex = 3;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSubtraction_Click;
            // 
            // бутон за умножение
            // 
            button3.BackColor = Color.Aquamarine;
            button3.FlatAppearance.BorderColor = Color.Black;
            button3.Location = new Point(134, 170);
            button3.Name = "button3";
            button3.Size = new Size(40, 35);
            button3.TabIndex = 4;
            button3.Text = "x";
            button3.UseVisualStyleBackColor = false;
            button3.Click += buttonMultiplication_Click;
            // 
            // бутон за деление
            // 
            button4.BackColor = Color.OrangeRed;
            button4.Location = new Point(189, 170);
            button4.Name = "button4";
            button4.Size = new Size(40, 35);
            button4.TabIndex = 5;
            button4.Text = "÷";
            button4.UseVisualStyleBackColor = false;
            button4.Click += buttonDivision_Click;
            // 
            // label за резултат
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "Резултат:";
            // 
            // label за първото число
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 7;
            label2.Text = "Число №1:";
            // 
            // label за второто число
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 70);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Число №2:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(357, 310);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
