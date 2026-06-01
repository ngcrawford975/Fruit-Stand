using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Stand
{
    public partial class Form1 : Form
    {
        // Running total
        private decimal total = 0m;

        // Fruit prices per pound
        private const decimal BANANA_PRICE = 0.65m;
        private const decimal APPLE_PRICE = 1.35m;
        private const decimal ORANGE_PRICE = 1.60m;
        private const decimal PEAR_PRICE = 1.20m;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalLbl.Text = total.ToString("c");
        }

        private void bananaPic_Click(object sender, EventArgs e)
        {
            total += BANANA_PRICE;
            totalLbl.Text = total.ToString("c");
        }


        private void applePic_Click_1(object sender, EventArgs e)
        {
            total += APPLE_PRICE;
            totalLbl.Text = total.ToString("c");
        }

        private void orangePic_Click_1(object sender, EventArgs e)
        {
            total += ORANGE_PRICE;
            totalLbl.Text = total.ToString("c");
        }

        private void pearPic_Click_1(object sender, EventArgs e)
        {
            total += PEAR_PRICE;
            totalLbl.Text = total.ToString("c");
        }

        private void resetBtn_Click_1(object sender, EventArgs e)
        {
            total = 0m;
            totalLbl.Text = total.ToString("c");
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    
    }
    } 