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
    public partial class Form1 : Form
    {
        public static int DiamondCount = 5;
        List<StudentUC> studentUCs = new List<StudentUC>();
        public Form1()
        {
            InitializeComponent();
            propertiesPnl.BackColor = Color.FromArgb(227, 246, 255);
            propertiesPnl.ForeColor = Color.FromArgb(76, 179, 243);
            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();
            List<Student> students = new List<Student>
            {
                new Student
                {
                     Fullname ="Huseyn Abbasov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault
                },
                new Student
                {
                     Fullname ="Ali Ahmedov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                },
                new Student
                {
                     Fullname ="Ayxan Ahmadzade",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                },
                new Student
                {
                     Fullname ="Mehemmed Bayramov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault
                },
                new Student
                {
                     Fullname ="Omer Cavanshirov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                }
                ,
                new Student
                {
                     Fullname ="Coshqun Gulmemmedli",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                },
                new Student
                {
                     Fullname ="Nurlan Shirinov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                },
                new Student
                {
                     Fullname ="Ilkin Suleymanov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                },
                new Student
                {
                     Fullname ="Alirza Zaidov",
                      EnteredMystat = DateTime.Now,
                       ProfileImage = Properties.Resources.profileImageDefault

                },
            };
          
            int x = 0, y = 0;

            foreach (Student student in students)
            {
                StudentUC studentUC = new StudentUC();
                studentUC.Student = student;
                studentUC.Location = new Point(x, y);
                y += studentUC.Height;
                guna2Panel1.Controls.Add(studentUC);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            diamondCountLbl.Text = DiamondCount.ToString();
        }

        private void subjectLessonPctrBx_Click(object sender, EventArgs e)
        {
            if (!LessonSubjectGrpBx.Visible) LessonSubjectGrpBx.Visible = true;
            else LessonSubjectGrpBx.Visible = false;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            LessonSubjectLbl.Text = richTextBox1.Text;
            LessonSubjectGrpBx.Visible = false;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            LessonSubjectGrpBx.Visible = false;
        }

        public void selectAllChckBx_CheckedChanged(object sender, EventArgs e)
        {
            bool Buttonchecked = false;
            if (selectAllChckBx.Checked)
            {
                Buttonchecked = true;
            }
            else
            {
                Buttonchecked = false;
            }
            foreach (var item in guna2Panel1.Controls)
            {
                if (item is StudentUC UC)
                {

                    foreach (var item2 in UC.Controls)
                    {
                        if (item2 is Guna.UI2.WinForms.Guna2Panel pnl)
                        {

                            foreach (var item3 in pnl.Controls)
                            {
                                if (item3 is Guna.UI2.WinForms.Guna2GroupBox grpBx)
                                {
                                    foreach (var item4 in grpBx.Controls)
                                    {
                                        if (item4 is Guna.UI2.WinForms.Guna2CustomRadioButton cRdBtn)
                                        {
                                            if (cRdBtn.Name == "participatedRdBtn")
                                            {
                                                cRdBtn.Checked = Buttonchecked;

                                            }
                                        }
                                    }
                                }

                            }

                        }
                    }
                }
            }
        }
    }
}
