using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogBook
{
    public partial class StudentUC : UserControl
    {
        private Student student;
        public int StudentDiamondCount { get; set; }
        public Student Student
        {
            get { return student; }
            set { 
                nameLbl.Text = value.Fullname;
                idLbl.Text = value.Id.ToString();
                dateLbl.Text = value.EnteredMystat.ToShortDateString();
                StudentDiamondCount = value.DiamondCount;
            }
        }

        public StudentUC()
        {
            InitializeComponent();
        }

        private void SetDiamonds()
        {
           if(StudentDiamondCount == 1)
            {
                diamond1.Image = Properties.Resources.icons8_diamond_48;
                diamond2.Image = Properties.Resources.icons8_diamond_48__1_;
                diamond3.Image = Properties.Resources.icons8_diamond_48__1_;
                Form1.DiamondCount -= 1;
            }
            else if(StudentDiamondCount == 2)
            {
                diamond1.Image = Properties.Resources.icons8_diamond_48;
                diamond2.Image = Properties.Resources.icons8_diamond_48;
                diamond3.Image = Properties.Resources.icons8_diamond_48__1_;
                Form1.DiamondCount -= 2;
            }
            else if (StudentDiamondCount == 3)
            {
                diamond1.Image = Properties.Resources.icons8_diamond_48;
                diamond2.Image = Properties.Resources.icons8_diamond_48;
                diamond3.Image = Properties.Resources.icons8_diamond_48;
                Form1.DiamondCount -= 3;
            }
        }


        private void diamond1_Click(object sender, EventArgs e)
        {
            StudentDiamondCount = 1;
            SetDiamonds();
        }

        private void diamond2_Click(object sender, EventArgs e)
        {

            StudentDiamondCount = 2;
            SetDiamonds();
        }

        private void diamond3_Click(object sender, EventArgs e)
        {
            StudentDiamondCount = 3;
            SetDiamonds();
        }

        private void diamondCancel_Click(object sender, EventArgs e)
        {
            diamond1.Image = Properties.Resources.icons8_diamond_48__1_;
            diamond2.Image = Properties.Resources.icons8_diamond_48__1_;
            diamond3.Image = Properties.Resources.icons8_diamond_48__1_;
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            
            if (!CommentGrpBx.Visible) { CommentGrpBx.Visible = true; CommentLbl.Visible = false; }
            else CommentGrpBx.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CommentBtn_Click(object sender, EventArgs e)
        {
            CommentLbl.Text = CommentRchTxtb.Text;
            CommentLbl.Visible = true;
            CommentLbl.Location = new Point(CommentGrpBx.Location.X, CommentGrpBx.Location.Y+30);
            CommentGrpBx.Visible=false;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
             CommentGrpBx.Visible = false;
        }
    }
}
