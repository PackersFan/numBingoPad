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
        customLabel num0 = new customLabel();
        customLabel num1 = new customLabel();
        customLabel num2 = new customLabel();
        customLabel num3 = new customLabel();
        customLabel num4 = new customLabel();
        customLabel num5 = new customLabel();
        customLabel num6 = new customLabel();
        customLabel num7 = new customLabel();
        customLabel num8 = new customLabel();
        customLabel num9 = new customLabel();

        public Form1()
        {
           /*
            * 
            *      
        Keys on the numeric keypad.
        NumPad0 = 96,
        NumPad1 = 97,
        NumPad2 = 98,
        NumPad3 = 99,
        NumPad4 = 100,
        NumPad5 = 101,
        NumPad6 = 102,
        NumPad7 = 103,
        NumPad8 = 104,
        NumPad9 = 105,
        Multiply = 106,
        Add = 107,
        Separator = 108,
        Subtract = 109,
        Decimal = 110,
        Divide = 111,

        */


            this.Size = new Size(500, 800);

            Label title = new Label();
            title.Size = new Size(500, 100);
            title.Text = "NumBingoPad - Press a button to cycle between on and off";
            title.Font = new Font("Arial", 10, FontStyle.Bold);
            title.Location = new System.Drawing.Point(65, 20);
            this.Controls.Add(title);

            this.KeyPreview = true;
            this.KeyPress +=
                new KeyPressEventHandler(Form1_KeyPress);

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

            num0.Click += new EventHandler(label_Click);
            num1.Click += new EventHandler(label_Click);
            num2.Click += new EventHandler(label_Click);
            num3.Click += new EventHandler(label_Click);
            num4.Click += new EventHandler(label_Click);
            num5.Click += new EventHandler(label_Click);
            num6.Click += new EventHandler(label_Click);
            num7.Click += new EventHandler(label_Click);
            num8.Click += new EventHandler(label_Click);
            num9.Click += new EventHandler(label_Click);

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


        //private void label_Click(object sender, EventArgs e)
        //{
        //    customLabel clickedLabel = sender as customLabel;
            
        //    if (clickedLabel.toggled == false)
        //    {
        //        clickedLabel.toggled = true; 
        //        clickedLabel.ForeColor = Color.Green;
        //    } else
        //    {
        //        clickedLabel.toggled = false;
        //        clickedLabel.ForeColor = Color.Red; 
        //    }
        //}

        void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case (char)48:
                    if(num0.toggled == false)
                    {
                        num0.toggled = true;
                        num0.ForeColor = Color.Green;
                    } else
                    {
                        num0.toggled = false;
                        num0.ForeColor = Color.Red;
                    }
                    break;
                case (char)49:
                    if (num1.toggled == false)
                    {
                        num1.toggled = true;
                        num1.ForeColor = Color.Green;
                    }
                    else
                    {
                        num1.toggled = false;
                        num1.ForeColor = Color.Red;
                    }
                    break;
                case (char)50:
                    if (num2.toggled == false)
                    {
                        num2.toggled = true;
                        num2.ForeColor = Color.Green;
                    }
                    else
                    {
                        num2.toggled = false;
                        num2.ForeColor = Color.Red;
                    }
                    break;
                case (char)51:
                    if (num3.toggled == false)
                    {
                        num3.toggled = true;
                        num3.ForeColor = Color.Green;
                    }
                    else
                    {
                        num3.toggled = false;
                        num3.ForeColor = Color.Red;
                    }
                    break;
                case (char)52:
                    if (num4.toggled == false)
                    {
                        num4.toggled = true;
                        num4.ForeColor = Color.Green;
                    }
                    else
                    {
                        num4.toggled = false;
                        num4.ForeColor = Color.Red;
                    }
                    break;
                case (char)53:
                    if (num5.toggled == false)
                    {
                        num5.toggled = true;
                        num5.ForeColor = Color.Green;
                    }
                    else
                    {
                        num5.toggled = false;
                        num5.ForeColor = Color.Red;
                    }
                    break;
                case (char)54:
                    if (num6.toggled == false)
                    {
                        num6.toggled = true;
                        num6.ForeColor = Color.Green;
                    }
                    else
                    {
                        num6.toggled = false;
                        num6.ForeColor = Color.Red;
                    }
                    break;
                case (char)55:
                    if (num7.toggled == false)
                    {
                        num7.toggled = true;
                        num7.ForeColor = Color.Green;
                    }
                    else
                    {
                        num7.toggled = false;
                        num7.ForeColor = Color.Red;
                    }
                    break;
                case (char)56:
                    if (num8.toggled == false)
                    {
                        num8.toggled = true;
                        num8.ForeColor = Color.Green;
                    }
                    else
                    {
                        num8.toggled = false;
                        num8.ForeColor = Color.Red;
                    }
                    break;
                case (char)57:
                    if (num9.toggled == false)
                    {
                        num9.toggled = true;
                        num9.ForeColor = Color.Green;
                    }
                    else
                    {
                        num9.toggled = false;
                        num9.ForeColor = Color.Red;
                    }
                    break;
            }
        }
    }
}
