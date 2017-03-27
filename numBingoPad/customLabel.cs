using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numbingoPad
{
    class customLabel : Label 
    {
        public bool toggled;

        public customLabel()
        {
            toggled = false; 
            
        }
       
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Rectangle border = new Rectangle(1, 1, 100, 100);
            this.Font = new Font("Arial", 83, FontStyle.Bold);
            ControlPaint.DrawBorder(e.Graphics, border,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset,
                                         Color.Black, 1, ButtonBorderStyle.Inset);
        }

    }
}
