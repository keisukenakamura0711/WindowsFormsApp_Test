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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ChangeWidth(int width)
        {
            this.Width = width;
        }

        public void ChangeHeight(int height)
        {
            this.Height = height;
        }

        public void MoveVertical(int move)
        {
            this.Top += move;
        }

        public void MoveHorizontal(int move)
        {
            this.Left += move;
        }

        public void ResetPosition()
        {
            this.Left = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            this.Top = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
        }

        public void ChangeColor(int r, int g, int b)
        {
            this.BackColor = Color.FromArgb(r, g, b);
        }
    }
}
