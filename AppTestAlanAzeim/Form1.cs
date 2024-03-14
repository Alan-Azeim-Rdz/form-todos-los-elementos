using System.Diagnostics;
using static System.Net.WebRequestMethods;

namespace AppTestAlanAzeim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //button
        private void button1_Click(object sender, EventArgs e)
        {
            leabelButon.Text = "you push the button";
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        //check box
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            BoxQuantity boxQuantity1 = new BoxQuantity(checkBox1);
            string result = boxQuantity1.ToString();

            LeabelCheck.Text = result;

            if (checkBox2.Checked && checkBox1.Checked)
            {
                BoxQuantity boxQuantity3 = new BoxQuantity(checkBox1, checkBox2);

                result = boxQuantity3.ToString();

                LeabelCheck.Text = result;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            BoxQuantity boxQuantity2 = new BoxQuantity(checkBox2);
            string result = boxQuantity2.ToString();

            LeabelCheck.Text = result;
            if (checkBox2.Checked && checkBox1.Checked)
            {
                BoxQuantity boxQuantity3 = new BoxQuantity(checkBox1, checkBox2);

                result = boxQuantity3.ToString();

                LeabelCheck.Text = result;
            }

        }

        private void checkedListBox1_ItemCheck(object sender, EventArgs e)
        {
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //llama a cmd y le dice que abra en el navegador predeterminado el link escrito
            System.Diagnostics.Process.Start("cmd", $"/c start {"https://github.com/Alan-Azeim-Rdz"}");
        }
    }
}
