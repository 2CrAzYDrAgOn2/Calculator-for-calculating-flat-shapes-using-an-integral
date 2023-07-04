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
        /// btnCalculate_Click ��������� �������� �� ������� ������ "����������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtLowerLimit.ForeColor = txtUpperLimit.ForeColor = textBox1.ForeColor = textBox2.ForeColor = Color.Black; // ������ ���� ������ �� ������
            lblResult.Text = string.Empty; // ������� lblResult
            // �������� �������� �������� � ������� �������� ��������������
            lowerLimit = EvaluateExpression(txtLowerLimit);
            upperLimit = EvaluateExpression(txtUpperLimit);
            lowerLimit = Test(lowerLimit);
            upperLimit = Test(upperLimit);
            figureType = cmbFigureType.SelectedItem.ToString(); // �������� ��������� ��� ������
            area = CalculateArea(lowerLimit, upperLimit, figureType); // ��������� ������� ������
            lblResult.Text = $"{area}"; // ������� ���������
        }

        /// <summary>
        /// button1_Click ��������� �������� �� ������� ������ "��������"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            txtLowerLimit.ForeColor = txtUpperLimit.ForeColor = textBox1.ForeColor = textBox2.ForeColor = Color.Black; // ������ ���� ������ �� ������
            // ������� ������
            txtUpperLimit.Clear();
            txtLowerLimit.Clear();
            textBox1.Clear();
            textBox2.Clear();
            lblResult.Text = string.Empty;
        }

        /// <summary>
        /// button2_Click ��������� �������� �� ������� ������ "������� � Word"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            Word.Application word = new(); // �������� ������� Word
            Word.Document doc = word.Documents.Add(); // �������� ������ ��������� Word
            if (cmbFigureType.Text == "�������������")
            {
                doc.Paragraphs[1].Range.Text = "������� ������ ���������:" + txtUpperLimit.Text + "\n" + "������ ������ ���������:" + txtLowerLimit.Text + "\n" + "������:" + cmbFigureType.Text + "\n" + "������ ��������������:" + textBox1.Text + "\n" + "������ ��������������:" + textBox2.Text + "\n" + "���������:" + lblResult.Text; // ����� ������
            }
            if (cmbFigureType.Text == "�����������")
            {
                doc.Paragraphs[1].Range.Text = "������� ������ ���������:" + txtUpperLimit.Text + "\n" + "������ ������ ���������:" + txtLowerLimit.Text + "\n" + "������:" + cmbFigureType.Text + "\n" + "��������� ������������:" + textBox1.Text + "\n" + "���������:" + lblResult.Text; // ����� ������
            }
            if (cmbFigureType.Text == "����")
            {
                doc.Paragraphs[1].Range.Text = "������� ������ ���������:" + txtUpperLimit.Text + "\n" + "������ ������ ���������:" + txtLowerLimit.Text + "\n" + "������:" + cmbFigureType.Text + "\n" + "��������� ������������:" + textBox1.Text + "\n" + "���������:" + lblResult.Text; doc.Paragraphs[1].Range.Text = "������� ������ ���������:" + txtUpperLimit.Text + "\n" + "������ ������ ���������:" + txtLowerLimit.Text + "\n" + "������:" + cmbFigureType.Text + "\n" + "������ �����:" + textBox1.Text + "\n" + "���������:" + lblResult.Text; // ����� ������
            }
            word.Visible = true;
        }

        /// <summary>
        /// button3_Click ��������� �������� �� ������� ������ "������� � Excel"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new(); // �������� ������� Excel
            Excel.Workbook workbook = excel.Workbooks.Add(); // �������� ����� ����� Excel
            Excel.Worksheet sheet = (Excel.Worksheet)workbook.ActiveSheet; // ����� ��������� �����
            if (cmbFigureType.Text == "�������������")
            {
                // ����� ������
                sheet.Cells[1, 1].Value = "������� ������ ���������";
                sheet.Cells[2, 1].Value = txtUpperLimit.Text;
                sheet.Cells[1, 2].Value = "������ ������ ���������";
                sheet.Cells[2, 2].Value = txtLowerLimit.Text;
                sheet.Cells[1, 3].Value = "������";
                sheet.Cells[2, 3].Value = cmbFigureType.Text;
                sheet.Cells[1, 4].Value = "������ ��������������";
                sheet.Cells[2, 4].Value = textBox1.Text;
                sheet.Cells[1, 5].Value = "������ ��������������";
                sheet.Cells[2, 5].Value = textBox2.Text;
                sheet.Cells[1, 6].Value = "���������";
                sheet.Cells[2, 6].Value = lblResult.Text;
                sheet.Columns.AutoFit(); // ������������ ��������
                sheet.Rows.AutoFit(); // ������������ �����
            }
            if (cmbFigureType.Text == "�����������")
            {
                // ����� ������
                sheet.Cells[1, 1].Value = "������� ������ ���������";
                sheet.Cells[2, 1].Value = txtUpperLimit.Text;
                sheet.Cells[1, 2].Value = "������ ������ ���������";
                sheet.Cells[2, 2].Value = txtLowerLimit.Text;
                sheet.Cells[1, 3].Value = "������";
                sheet.Cells[2, 3].Value = cmbFigureType.Text;
                sheet.Cells[1, 4].Value = "��������� ������������";
                sheet.Cells[2, 4].Value = textBox1.Text;
                sheet.Cells[1, 5].Value = "���������";
                sheet.Cells[2, 5].Value = lblResult.Text;
                sheet.Columns.AutoFit(); // ������������ ��������
                sheet.Rows.AutoFit(); // ������������ �����
            }
            if (cmbFigureType.Text == "����")
            {
                // ����� ������
                sheet.Cells[1, 1].Value = "������� ������ ���������";
                sheet.Cells[2, 1].Value = txtUpperLimit.Text;
                sheet.Cells[1, 2].Value = "������ ������ ���������";
                sheet.Cells[2, 2].Value = txtLowerLimit.Text;
                sheet.Cells[1, 3].Value = "������";
                sheet.Cells[2, 3].Value = cmbFigureType.Text;
                sheet.Cells[1, 4].Value = "������ �����";
                sheet.Cells[2, 4].Value = textBox1.Text;
                sheet.Cells[1, 5].Value = "���������";
                sheet.Cells[2, 5].Value = lblResult.Text;
                sheet.Columns.AutoFit(); // ������������ ��������
                sheet.Rows.AutoFit(); // ������������ �����
            }
            excel.Visible = true;
        }

        /// <summary>
        /// button4_Click ��������� �������� �� ������� ������ "�����"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// cmbFigureType_SelectedIndexChanged ��������� �������� ��� ��������� cmbFigureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFigureType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbFigureType.SelectedItem.ToString();
            if (selectedValue == "�������������")
            {
                textBox2.Enabled = true; // �������� textBox2
            }
            else
            {
                textBox2.Enabled = false; // ��������� textBox2
            }
        }

        /// <summary>
        /// EvaluateExpression ����������� ��������� � �����
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        private static double EvaluateExpression(TextBox expression)
        {
            try
            {
                expression.Text = expression.Text.Replace(" ", ""); // �������� �������� �� ���������
                System.Data.DataTable dt = new(); // �������� ������� ��� ���������� �������������� ���������
                var result = dt.Compute(expression.Text, ""); // ���������� �������������� ���������
                return Convert.ToDouble(result); // ������� ����������
            }
            catch (Exception ex)
            {
                expression.ForeColor = Color.Red; // �������� ������� �����
                expression.Text = "0"; // ������������ ����� � ����
                MessageBox.Show($"������ � {expression}: " + ex.Message + "��� ���� � �������� ���� �������� �� 0"); // ����� ������
                return 0.0;
            }
        }

        /// <summary>
        /// Test ��������� �������� �� �������������
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static double Test(double value)
        {
            if (double.IsInfinity(value))
            {
                value = 0.0;
                MessageBox.Show("�� ���� ������ ������! ��� ����������, ��� ��������� ������� �� ���� ���� ���������� � ����"); // ������� ��������� �� ������
            }
            return value;
        }

        /// <summary>
        /// CalculateArea ��������� ������� ������
        /// </summary>
        /// <param name="lowerLimit"></param>
        /// <param name="upperLimit"></param>
        /// <param name="figureType"></param>
        /// <returns></returns>
        private double CalculateArea(double lowerLimit, double upperLimit, string figureType)
        {
            // �������������� ��������� ������� ���������������
            int numIntervals = 1000; // ���������� ���������� ���������
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
        /// GetHeight ������������ ������
        /// </summary>
        /// <param name="x"></param>
        /// <param name="figureType"></param>
        /// <returns></returns>
        private double GetHeight(double x, string figureType)
        {
            if (figureType == "�������������")
            {
                double width = EvaluateExpression(textBox1); // ������ ��������������
                width = Test(width);
                if (x >= 0 && x <= width)
                {
                    double height = EvaluateExpression(textBox2);
                    height = Test(height);
                    return height;
                }
            }
            if (figureType == "�����������")
            {
                double baseWidth = EvaluateExpression(textBox1); // ��������� ������������
                baseWidth = Test(baseWidth);
                if (x >= 0 && x <= baseWidth)
                {
                    double height1 = (baseWidth - x) * 0.5; // ������ ������������
                    return height1;
                }
            }
            if (figureType == "����")
            {
                double radius = EvaluateExpression(textBox1); // ������ �����
                radius = Test(radius);
                if (Math.Abs(x) <= radius)
                {
                    double height2 = Math.Sqrt(radius * radius - x * x); // ������ ����� (�� ������� ��������)
                    return height2;
                }
            }
            return 0;
        }

        /// <summary>
        /// txtUpperLimit_KeyPress ��������� �������� ��� ������� ������ �� ����� ������ �� txtUpperLimit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUpperLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                txtLowerLimit.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// txtLowerLimit_KeyPress ��������� �������� ��� ������� ������ �� ����� ������ �� txtLowerLimit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLowerLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                cmbFigureType.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// cmbFigureType_KeyPress ��������� �������� ��� ������� ������ �� ����� ������ �� cmbFigureType
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFigureType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                textBox1.Focus(); // ��������� ����� �� ������ TextBox
            }
        }

        /// <summary>
        /// textBox1_KeyPress ��������� �������� ��� ������� ������ �� ����� ������ �� textBox1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedValue = cmbFigureType.SelectedItem.ToString();
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                if (selectedValue == "�������������")
                {
                    textBox2.Focus(); // ��������� ����� �� ������ TextBox
                }
                else
                {
                    btnCalculate.PerformClick(); // ��������� ��������, ����������� ������� ������
                }
            }
        }

        /// <summary>
        /// textBox2_KeyPress ��������� �������� ��� ������� ������ �� ����� ������ �� textBox2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // ������������� ���������� ��������� ������� ������� Enter
                btnCalculate.PerformClick(); // ��������� ��������, ����������� ������� ������
            }
        }
    }
}