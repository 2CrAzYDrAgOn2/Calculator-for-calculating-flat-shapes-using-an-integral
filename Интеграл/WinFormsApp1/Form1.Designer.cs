namespace WinFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtLowerLimit = new TextBox();
            txtUpperLimit = new TextBox();
            cmbFigureType = new ComboBox();
            btnCalculate = new Button();
            lblResult = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label7 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // txtLowerLimit
            // 
            txtLowerLimit.Location = new Point(188, 69);
            txtLowerLimit.MaxLength = 15;
            txtLowerLimit.Name = "txtLowerLimit";
            txtLowerLimit.Size = new Size(65, 23);
            txtLowerLimit.TabIndex = 0;
            txtLowerLimit.KeyPress += txtLowerLimit_KeyPress;
            // 
            // txtUpperLimit
            // 
            txtUpperLimit.Location = new Point(188, 40);
            txtUpperLimit.MaxLength = 15;
            txtUpperLimit.Name = "txtUpperLimit";
            txtUpperLimit.Size = new Size(65, 23);
            txtUpperLimit.TabIndex = 1;
            txtUpperLimit.KeyPress += txtUpperLimit_KeyPress;
            // 
            // cmbFigureType
            // 
            cmbFigureType.AllowDrop = true;
            cmbFigureType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFigureType.FormattingEnabled = true;
            cmbFigureType.Items.AddRange(new object[] { "Прямоугольник", "Треугольник", "Круг" });
            cmbFigureType.Location = new Point(108, 102);
            cmbFigureType.Name = "cmbFigureType";
            cmbFigureType.Size = new Size(139, 23);
            cmbFigureType.TabIndex = 2;
            cmbFigureType.SelectedIndexChanged += cmbFigureType_SelectedIndexChanged;
            cmbFigureType.KeyPress += cmbFigureType_KeyPress;
            // 
            // btnCalculate
            // 
            btnCalculate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCalculate.Location = new Point(738, 12);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(133, 63);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Рассчитать";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // lblResult
            // 
            lblResult.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblResult.Location = new Point(101, 325);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 28);
            lblResult.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 141);
            textBox1.MaxLength = 15;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 5;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(188, 190);
            textBox2.MaxLength = 15;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(163, 23);
            textBox2.TabIndex = 6;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 7;
            label1.Text = "Верхний предел интеграла";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 72);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 8;
            label2.Text = "Нижний предел интеграла";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 128);
            label3.Name = "label3";
            label3.Size = new Size(175, 45);
            label3.TabIndex = 9;
            label3.Text = "Для прямоугольника: ширина\r\nДля треугольника: основание\r\nДля круга: радиус";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 183);
            label4.Name = "label4";
            label4.Size = new Size(167, 30);
            label4.TabIndex = 10;
            label4.Text = "Поле предназначено только \r\nдля высоты прямоугольника";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 11;
            label5.Text = "Выбор фигуры";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label6.AutoSize = true;
            label6.Location = new Point(12, 336);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 12;
            label6.Text = "Результат:";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.Location = new Point(738, 81);
            button1.Name = "button1";
            button1.Size = new Size(133, 63);
            button1.TabIndex = 13;
            button1.Text = "Очистить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.Location = new Point(738, 150);
            button2.Name = "button2";
            button2.Size = new Size(133, 63);
            button2.TabIndex = 14;
            button2.Text = "Вывести в Word";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.Location = new Point(738, 219);
            button3.Name = "button3";
            button3.Size = new Size(133, 63);
            button3.TabIndex = 15;
            button3.Text = "Вывести в Excel";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button4.Location = new Point(738, 288);
            button4.Name = "button4";
            button4.Size = new Size(133, 63);
            button4.TabIndex = 16;
            button4.Text = "Выйти";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ImageAlign = ContentAlignment.TopCenter;
            label7.Location = new Point(90, 9);
            label7.Name = "label7";
            label7.Size = new Size(595, 28);
            label7.TabIndex = 17;
            label7.Text = "Калькулятор вычисления плоских фигур с помощью интеграла";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top;
            label8.AutoSize = true;
            label8.Location = new Point(362, 53);
            label8.Name = "label8";
            label8.Size = new Size(370, 120);
            label8.TabIndex = 18;
            label8.Text = resources.GetString("label8.Text");
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 363);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblResult);
            Controls.Add(btnCalculate);
            Controls.Add(cmbFigureType);
            Controls.Add(txtUpperLimit);
            Controls.Add(txtLowerLimit);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLowerLimit;
        private TextBox txtUpperLimit;
        private ComboBox cmbFigureType;
        private Button btnCalculate;
        private Label lblResult;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label7;
        private Label label8;
    }
}