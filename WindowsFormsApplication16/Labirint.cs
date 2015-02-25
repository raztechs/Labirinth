using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication16
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            MoveToStart();
        }

        private void finishLabel_MouseEnter_1(object sender, EventArgs e)
        {
            MessageBox.Show(("Felicitari! Numar de reincercari: " + i).ToString());
            Close();
        }

        private void MoveToStart()
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(476, 376);
            Cursor.Position = PointToScreen(startingPoint);
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label17_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label12_MouseMove(object sender, MouseEventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
            i++;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

    }
}
