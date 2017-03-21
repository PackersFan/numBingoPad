using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbingoPad
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            this.Size = new Size(500, 800);

            Label title = new Label();
            title.Size = new Size(500, 100);
            title.Text = "NumBingoPad - Press a button to cycle between on and off";
            title.Font = new Font("Arial", 10, FontStyle.Bold);
            title.Location = new System.Drawing.Point(65, 20);
            this.Controls.Add(title);

            Label num0 = new Label();
            Label num1 = new Label();
            Label num2 = new Label();
            Label num3 = new Label();
            Label num4 = new Label();
            Label num5 = new Label();
            Label num6 = new Label();
            Label num7 = new Label();
            Label num8 = new Label();
            Label num9 = new Label();

            num0.Text = "0";
            num1.Text = "1";
            num2.Text = "2";
            num3.Text = "3";
            num4.Text = "4";
            num5.Text = "5";
            num6.Text = "6";
            num7.Text = "7";
            num8.Text = "8";
            num9.Text = "9";


            num0.Location = new System.Drawing.Point(250, 500);
            num1.Location = new System.Drawing.Point(125, 375);
            num2.Location = new System.Drawing.Point(250, 375);
            num3.Location = new System.Drawing.Point(375, 375);
            num4.Location = new System.Drawing.Point(125, 250);
            num5.Location = new System.Drawing.Point(250, 250);
            num6.Location = new System.Drawing.Point(375, 250);
            num7.Location = new System.Drawing.Point(125, 125);
            num8.Location = new System.Drawing.Point(250, 125);
            num9.Location = new System.Drawing.Point(375, 125);


            num0.AutoSize = true;
            num1.AutoSize = true;
            num2.AutoSize = true;
            num3.AutoSize = true;
            num4.AutoSize = true;
            num5.AutoSize = true;
            num6.AutoSize = true;
            num7.AutoSize = true;
            num8.AutoSize = true;
            num9.AutoSize = true;


            this.Controls.Add(num0);
            this.Controls.Add(num1);
            this.Controls.Add(num2);
            this.Controls.Add(num3);
            this.Controls.Add(num4);
            this.Controls.Add(num5);
            this.Controls.Add(num6);
            this.Controls.Add(num7);
            this.Controls.Add(num8);
            this.Controls.Add(num9);
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
