using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public double lowerLimit, upperLimit, area;
        public string figureType;

        public Form1()
        {
            InitializeComponent();
            cmbFigureType.SelectedIndex = 0;
        }

        /// <summary>
        /// btnCalculate_Click выполняет действия по нажатию кнопки "Рассчитать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtLowerLimit.ForeColor = txtUpperLimit.ForeColor = textBox1.ForeColor = textBox2.ForeColor = Color.Black; // меняет цвет текста на чёрный
            lblResult.Text = string.Empty; // очищает lblResult
            // получаем значения верхнего и нижнего пределов интегрирования
            lowerLimit = EvaluateExpression(txtLowerLimit);
            upperLimit = EvaluateExpression(txtUpperLimit);
            lowerLimit = Test(lowerLimit);
            upperLimit = Test(upperLimit);
            figureType = cmbFigureType.SelectedItem.ToString(); // получаем выбранный тип фигуры
            area = CalculateArea(lowerLimit, upperLimit, figureType); // вычисляем площадь фигуры
            lblResult.Text = $"{area}"; // выводим результат
        }

        /// <summary>
        /// button1_Click выполняет действия по нажатию кнопки "Очистить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtLowerLimit.ForeColor = txtUpperLimit.ForeColor = textBox1.ForeColor = textBox2.ForeColor = Color.Black; // меняет цвет текста на чёрный
            // очистка текста
            txtUpperLimit.Clear();
            txtLowerLimit.Clear();
            textBox1.Clear();
            textBox2.Clear();
            lblResult.Text = string.Empty;
        }

        /// <summary>
        /// button2_Click выполняет действия по нажатию кнопки "Вывести в Word"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Word.Application word = new(); // создание объекта Word
            Word.Document doc = word.Documents.Add(); // создание нового документа Word
            if (cmbFigureType.Text == "Прямоугольник")
            {
                doc.Paragraphs[1].Range.Text = "Верхний предел интеграла:" + txtUpperLimit.Text + "\n" + "Нижний предел интеграла:" + txtLowerLimit.Text + "\n" + "Фигура:" + cmbFigureType.Text + "\n" + "Ширина прямоугольника:" + textBox1.Text + "\n" + "Высота прямоугольника:" + textBox2.Text + "\n" + "Результат:" + lblResult.Text; // вывод текста
            }
            if (cmbFigureType.Text == "Треугольник")
            {
                doc.Paragraphs[1].Range.Text = "Верхний предел интеграла:" + txtUpperLimit.Text + "\n" + "Нижний предел интеграла:" + txtLowerLimit.Text + "\n" + "Фигура:" + cmbFigureType.Text + "\n" + "Основание треугольника:" + textBox1.Text + "\n" + "Результат:" + lblResult.Text; // вывод текста
            }
            if (cmbFigureType.Text == "Круг")
            {
                doc.Paragraphs[1].Range.Text = "Верхний предел интеграла:" + txtUpperLimit.Text + "\n" + "Нижний предел интеграла:" + txtLowerLimit.Text + "\n" + "Фигура:" + cmbFigureType.Text + "\n" + "Основание треугольника:" + textBox1.Text + "\n" + "Результат:" + lblResult.Text; doc.Paragraphs[1].Range.Text = "Верхний предел интеграла:" + txtUpperLimit.Text + "\n" + "Нижний предел интеграла:" + txtLowerLimit.Text + "\n" + "Фигура:" + cmbFigureType.Text + "\n" + "Радиус круга:" + textBox1.Text + "\n" + "Результат:" + lblResult.Text; // вывод текста
            }
            word.Visible = true;
        }

        /// <summary>
        /// button3_Click выполняет действия по нажатию кнопки "Вывести в Excel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new(); // создание объекта Excel
            Excel.Workbook workbook = excel.Workbooks.Add(); // создание новой книги Excel
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet; // выбор активного листа
            if (cmbFigureType.Text == "Прямоугольник")
            {
                // вывод текста
                sheet.Cells[1, 1].Value = "Верхний предел интеграла";
                sheet.Cells[2, 1].Value = txtUpperLimit.Text;
                sheet.Cells[1, 2].Value = "Нижний предел интеграла";
                sheet.Cells[2, 2].Value = txtLowerLimit.Text;
                sheet.Cells[1, 3].Value = "Фигура";
                sheet.Cells[2, 3].Value = cmbFigureType.Text;
                sheet.Cells[1, 4].Value = "Ширина прямоугольника";
                sheet.Cells[2, 4].Value = textBox1.Text;
                sheet.Cells[1, 5].Value = "Высота прямоугольника";
                sheet.Cells[2, 5].Value = textBox2.Text;
                sheet.Cells[1, 6].Value = "Результат";
                sheet.Cells[2, 6].Value = lblResult.Text;
                sheet.Columns.AutoFit(); // выравнивание столбцов
                sheet.Rows.AutoFit(); // выравнивание строк
            }
            if (cmbFigureType.Text == "Треугольник")
            {
                // вывод текста
                sheet.Cells[1, 1].Value = "Верхний предел интеграла";
                sheet.Cells[2, 1].Value = txtUpperLimit.Text;
                sheet.Cells[1, 2].Value = "Нижний предел интеграла";
                sheet.Cells[2, 2].Value = txtLowerLimit.Text;
                sheet.Cells[1, 3].Value = "Фигура";
                sheet.Cells[2, 3].Value = cmbFigureType.Text;
                sheet.Cells[1, 4].Value = "Основание треугольника";
                sheet.Cells[2, 4].Value = textBox1.Text;
                sheet.Cells[1, 5].Value = "Результат";
                sheet.Cells[2, 5].Value = lblResult.Text;
                sheet.Columns.AutoFit(); // выравнивание столбцов
                sheet.Rows.AutoFit(); // выравнивание строк
            }
            if (cmbFigureType.Text == "Круг")
            {
                // вывод текста
                sheet.Cells[1, 1].Value = "Верхний предел интеграла";
                sheet.Cells[2, 1].Value = txtUpperLimit.Text;
                sheet.Cells[1, 2].Value = "Нижний предел интеграла";
                sheet.Cells[2, 2].Value = txtLowerLimit.Text;
                sheet.Cells[1, 3].Value = "Фигура";
                sheet.Cells[2, 3].Value = cmbFigureType.Text;
                sheet.Cells[1, 4].Value = "Радиус круга";
                sheet.Cells[2, 4].Value = textBox1.Text;
                sheet.Cells[1, 5].Value = "Результат";
                sheet.Cells[2, 5].Value = lblResult.Text;
                sheet.Columns.AutoFit(); // выравнивание столбцов
                sheet.Rows.AutoFit(); // выравнивание строк
            }
            excel.Visible = true;
        }

        /// <summary>
        /// button4_Click выполняет действия по нажатию кнопки "Выйти"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// cmbFigureType_SelectedIndexChanged выполняет действия при изменении cmbFigureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFigureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbFigureType.SelectedItem.ToString();
            if (selectedValue == "Прямоугольник")
            {
                textBox2.Enabled = true; // включает textBox2
            }
            else
            {
                textBox2.Enabled = false; // выключает textBox2
            }
        }

        /// <summary>
        /// EvaluateExpression преобразует выражения в числа
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static double EvaluateExpression(TextBox expression)
        {
            try
            {
                expression.Text = expression.Text.Replace(" ", ""); // удаление пробелов из выражения
                System.Data.DataTable dt = new(); // создание объекта для вычисления математических выражений
                var result = dt.Compute(expression.Text, ""); // вычисление математических выражений
                return Convert.ToDouble(result); // возврат результата
            }
            catch (Exception ex)
            {
                expression.ForeColor = Color.Red; // выделяет красным текст
                expression.Text = "0"; // приравнивает текст к нулю
                MessageBox.Show($"Ошибка в {expression}: " + ex.Message + "Все поля с ошибками были заменены на 0"); // вывод ошибки
                return 0.0;
            }
        }

        /// <summary>
        /// Test проверяет значения на бесконечность
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static double Test(double value)
        {
            if (double.IsInfinity(value))
            {
                value = 0.0;
                MessageBox.Show("На ноль делить нельзя! Все переменные, где произошло деление на ноль были приравнены к нулю"); // выводит сообщение об ошибке
            }
            return value;
        }

        /// <summary>
        /// CalculateArea вычисляет площадь фигуры
        /// </summary>
        /// <param name="lowerLimit"></param>
        /// <param name="upperLimit"></param>
        /// <param name="figureType"></param>
        /// <returns></returns>
        private double CalculateArea(double lowerLimit, double upperLimit, string figureType)
        {
            // интегрирование численным методом прямоугольников
            int numIntervals = 1000; // количество интервалов разбиения
            double intervalWidth = (upperLimit - lowerLimit) / numIntervals;
            double area = 0;
            for (int i = 0; i < numIntervals; i++)
            {
                double x = lowerLimit + (i + 0.5) * intervalWidth;
                double height = GetHeight(x, figureType);
                area += height * intervalWidth;
            }
            return area;
        }

        /// <summary>
        /// GetHeight рассчитывает высоту
        /// </summary>
        /// <param name="x"></param>
        /// <param name="figureType"></param>
        /// <returns></returns>
        private double GetHeight(double x, string figureType)
        {
            if (figureType == "Прямоугольник")
            {
                double width = EvaluateExpression(textBox1); // ширина прямоугольника
                width = Test(width);
                if (x >= 0 && x <= width)
                {
                    double height = EvaluateExpression(textBox2);
                    height = Test(height);
                    return height;
                }
            }
            if (figureType == "Треугольник")
            {
                double baseWidth = EvaluateExpression(textBox1); // основание треугольника
                baseWidth = Test(baseWidth);
                if (x >= 0 && x <= baseWidth)
                {
                    double height1 = (baseWidth - x) * 0.5; // высота треугольника
                    return height1;
                }
            }
            if (figureType == "Круг")
            {
                double radius = EvaluateExpression(textBox1); // радиус круга
                radius = Test(radius);
                if (Math.Abs(x) <= radius)
                {
                    double height2 = Math.Sqrt(radius * radius - x * x); // высота круга (по теореме Пифагора)
                    return height2;
                }
            }
            return 0;
        }

        /// <summary>
        /// txtUpperLimit_KeyPress выполняет действия при нажатии кнопок во время фокуса на txtUpperLimit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpperLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                txtLowerLimit.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// txtLowerLimit_KeyPress выполняет действия при нажатии кнопок во время фокуса на txtLowerLimit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLowerLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                cmbFigureType.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// cmbFigureType_KeyPress выполняет действия при нажатии кнопок во время фокуса на cmbFigureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFigureType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                textBox1.Focus(); // переводит фокус на другой TextBox
            }
        }

        /// <summary>
        /// textBox1_KeyPress выполняет действия при нажатии кнопок во время фокуса на textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedValue = cmbFigureType.SelectedItem.ToString();
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                if (selectedValue == "Прямоугольник")
                {
                    textBox2.Focus(); // переводит фокус на другой TextBox
                }
                else
                {
                    btnCalculate.PerformClick(); // выполняет действие, аналогичное нажатию кнопки
                }
            }
        }

        /// <summary>
        /// textBox2_KeyPress выполняет действия при нажатии кнопок во время фокуса на textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // предотвращает дальнейшую обработку нажатия клавиши Enter
                btnCalculate.PerformClick(); // выполняет действие, аналогичное нажатию кнопки
            }
        }
    }
}