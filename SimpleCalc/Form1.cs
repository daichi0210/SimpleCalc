namespace SimpleCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            // 変数の宣言
            int valueLeft;
            int valueRight;
            int valueAnswer;

            // 値の取り込み
            valueLeft = InputCheck(input1TextBox.Text, out valueLeft);
            valueRight = InputCheck(input2TextBox.Text, out valueRight);

            // 取り込んだ値の計算
            valueAnswer = valueLeft + valueRight;

            // 計算結果を出力
            answerTextBox.Text = valueAnswer.ToString();
        }

        private int InputCheck(string textValue, out int value)
        {
            /*
            if (int.TryParse(textValue, out value) == true)
            {
                value = int.Parse(textValue);
            }
            else
            {
                value = 0;
            }
            */

            if (int.TryParse(textValue, out value) != true)
            {
                value = 0;
            }
            
            return value;
        }

    }
}
