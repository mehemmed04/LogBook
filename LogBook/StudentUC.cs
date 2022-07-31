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
            set
            {
                nameLbl.Text = value.Fullname;
                idLbl.Text = value.Id.ToString();
                dateLbl.Text = value.EnteredMystat.ToShortDateString();
                StudentDiamondCount = value.DiamondCount;
                profileimagePctrBx.Image = value.ProfileImage;
            }
        }

        public StudentUC()
        {
            InitializeComponent();
        }


        bool diamond1Checked = false;
        bool diamond2Checked = false;
        bool diamond3Checked = false;



        private void SetDiamonds()
        {
            if (StudentDiamondCount == 1)
            {
                diamond2.Image = Properties.Resources.icons8_diamond_48__1_;
                diamond3.Image = Properties.Resources.icons8_diamond_48__1_;
                if (Form1.DiamondCount > 0)
                {
                    diamond1.Image = Properties.Resources.icons8_diamond_48;
                    if (!diamond1Checked) Form1.DiamondCount -= 1;
                    diamond1Checked = true;
                }
                if (diamond2Checked)
                {
                    Form1.DiamondCount++;
                    diamond2Checked = false;
                }
                if (diamond3Checked)
                {
                    Form1.DiamondCount++;
                    diamond3Checked = false;
                }

            }
            else if (StudentDiamondCount == 2)
            {
                diamond3.Image = Properties.Resources.icons8_diamond_48__1_;

                if (Form1.DiamondCount > 0)
                {
                    diamond1.Image = Properties.Resources.icons8_diamond_48;
                    if (!diamond1Checked) Form1.DiamondCount -= 1;
                    diamond1Checked = true;
                    if (Form1.DiamondCount > 0)
                    {
                        diamond2.Image = Properties.Resources.icons8_diamond_48;
                        if (!diamond2Checked) Form1.DiamondCount -= 1;
                        diamond2Checked = true;
                    }
                }


                if (diamond3Checked)
                {
                    Form1.DiamondCount++;
                    diamond3Checked = false;
                }
            }
            else if (StudentDiamondCount == 3)
            {


                if (Form1.DiamondCount > 0)
                {
                    diamond1.Image = Properties.Resources.icons8_diamond_48;
                    if (!diamond1Checked) Form1.DiamondCount -= 1;
                    diamond1Checked = true;
                    if (Form1.DiamondCount >0)
                    {
                        diamond2.Image = Properties.Resources.icons8_diamond_48;
                        if (!diamond2Checked) Form1.DiamondCount -= 1;
                        diamond2Checked = true;
                        if (Form1.DiamondCount > 0)
                        {
                            diamond3.Image = Properties.Resources.icons8_diamond_48;
                            if (!diamond3Checked) Form1.DiamondCount -= 1;
                            diamond3Checked = true;

                        }

                    }
                }


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

            if (diamond1Checked)
            {
                Form1.DiamondCount++;
                diamond1Checked = false;
            }
            if (diamond2Checked)
            {
                Form1.DiamondCount++;
                diamond2Checked = false;
            }
            if (diamond3Checked)
            {
                Form1.DiamondCount++;
                diamond3Checked = false;
            }


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
            CommentLbl.Location = new Point(CommentGrpBx.Location.X, CommentGrpBx.Location.Y + 30);
            CommentGrpBx.Visible = false;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            CommentGrpBx.Visible = false;
        }

        private void profileimagePctrBx_Click(object sender, EventArgs e)
        {
            // open file dialog   
            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp; *.png";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                profileimagePctrBx.Image = new Bitmap(open.FileName);

            }
        }
    }
}
