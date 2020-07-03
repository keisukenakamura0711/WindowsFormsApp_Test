using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp_Test
{
    public partial class Form1 : Form
    {
        private Form2 form2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            form2 = new Form2();

            form2.ResetPosition();

            trackBar_Move.Value = 100;
            label_MoveValue.Text = trackBar_Move.Value.ToString();

            trackBar_Width.Value = 300;
            label_WidthValue.Text = trackBar_Width.Value.ToString();
            form2.ChangeWidth(trackBar_Width.Value);

            trackBar_Height.Value = 200;
            label_HeightValue.Text = trackBar_Height.Value.ToString();
            form2.ChangeHeight(trackBar_Height.Value);

            trackBar_R.Value = 128;
            label_RValue.Text = trackBar_R.Value.ToString();
            trackBar_G.Value = 128;
            label_GValue.Text = trackBar_G.Value.ToString();
            trackBar_B.Value = 128;
            label_BValue.Text = trackBar_B.Value.ToString();
            form2.ChangeColor(trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);

            form2.Show();
        }

        private void button_Up_Click(object sender, EventArgs e)
        {
            form2.MoveVertical(-trackBar_Move.Value);
        }

        private void button_Down_Click(object sender, EventArgs e)
        {
            form2.MoveVertical(trackBar_Move.Value);
        }

        private void button_Left_Click(object sender, EventArgs e)
        {
            form2.MoveHorizontal(-trackBar_Move.Value);
        }

        private void button_Right_Click(object sender, EventArgs e)
        {
            form2.MoveHorizontal(trackBar_Move.Value);
        }

        private void button_ResetPosition_Click(object sender, EventArgs e)
        {
            form2.ResetPosition();
        }

        private void trackBar_Move_Scroll(object sender, EventArgs e)
        {
            label_MoveValue.Text = trackBar_Move.Value.ToString();
        }

        private void trackBar_Width_Scroll(object sender, EventArgs e)
        {
            label_WidthValue.Text = trackBar_Width.Value.ToString();
            form2.ChangeWidth(trackBar_Width.Value);
        }

        private void trackBar_Height_Scroll(object sender, EventArgs e)
        {
            label_HeightValue.Text = trackBar_Height.Value.ToString();
            form2.ChangeHeight(trackBar_Height.Value);
        }

        private void trackBar_R_Scroll(object sender, EventArgs e)
        {
            label_RValue.Text = trackBar_R.Value.ToString();
            form2.ChangeColor(trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);
        }

        private void trackBar_G_Scroll(object sender, EventArgs e)
        {
            label_GValue.Text = trackBar_G.Value.ToString();
            form2.ChangeColor(trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);
        }

        private void trackBar_B_Scroll(object sender, EventArgs e)
        {
            label_BValue.Text = trackBar_B.Value.ToString();
            form2.ChangeColor(trackBar_R.Value, trackBar_G.Value, trackBar_B.Value);
        }

        private void checkBox_DisplayWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_DisplayWindow.Checked)
            {
                form2.Show();
            }
            else
            {
                form2.Hide();
            }
        }
    }
}
