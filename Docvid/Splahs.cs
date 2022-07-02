using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Runtime.InteropServices;
using System.Net.Mail;

namespace Docvid
{
    public partial class Splahs : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
      (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
       );

        public Splahs()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            prograssbar1.Value = 0;
        }

        private void Splahs_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prograssbar1.Value += 1;
            prograssbar1.Text = prograssbar1.Value.ToString() + "%";

            if(prograssbar1.Value == 100)
            {
                timer1.Enabled = false;
                login se_form = new login();
                se_form.Show();
                this.Hide();
            }

        }
    }
}
