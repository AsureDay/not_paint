using System;
using System.Drawing;
using System.Windows.Forms;


namespace drowing_lines_and_other_things
{
    public partial class FormColorChange : Form
    {
        private string hexText;
        private int red;
        private int green;
        private int blue;

        private bool hexLastChanged = false;
        private bool rgbLastChanged = false;
        public Color GetColor()
        {
            if (hexLastChanged && hexText.Length == 6) return ColorTranslator.FromHtml("#" + hexText);
            if (rgbLastChanged) return Color.FromArgb(red,green,blue);
            return Color.Aqua;
        }

        private string textWith = "3";
        public float GetPenWidth()
        {
            //todo
            return Convert.ToInt16(textWith,10);
        }
        public FormColorChange()
        {
            InitializeComponent();
        }

        private void HexFieldTextChanged(object sender, EventArgs e)
        {
            fieldHexColor.Text = fieldHexColor.Text.ToUpper();
            hexText = fieldHexColor.Text;
            hexLastChanged = true;
            rgbLastChanged = false;
        }

        private void RTextChanged(object sender, EventArgs e)
        {
            red =  Convert.ToInt16(maskedTextBox1.Text,10);
            hexLastChanged = false;
            rgbLastChanged = true;
        }

        private void GTextChanged(object sender, EventArgs e)
        {
            green = Convert.ToInt16(maskedTextBox2.Text, 10);
            hexLastChanged = false;
            rgbLastChanged = true;
        }

        private void BTextChanged(object sender, EventArgs e)
        {
            blue = Convert.ToInt16(maskedTextBox3.Text, 10);
            hexLastChanged = false;
            rgbLastChanged = true;
        }

        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            textWith = sizeTextBox.Text;
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
