using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; 
namespace Programming_Master
{
    public partial class Mainfrm : Form
    {
      
        private IconButton currentBtn,subcurrentBtn;
        private Panel leftBorderBtn,subleftBorderBtn;
        private Form currentChildForm;
        private bool checkProblemClick=false;
        public Mainfrm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7,50);
            panelMenu.Controls.Add(leftBorderBtn);

            subleftBorderBtn = new Panel();
            subleftBorderBtn.Size = new Size(7, 50);
            panelSubMenu.Controls.Add(subleftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            //panel
            panelSubMenu.Visible = false;
            panelOpenProblem.Visible = false;

        }

        //Structs
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }


        //Methods
        private void SubActivationButton(object subsenderBtn,Color color)
        {
            if(subsenderBtn != null)
            {
                SubDisableButton();
                //Button
                subcurrentBtn = (IconButton)subsenderBtn;
                subcurrentBtn.BackColor = Color.FromArgb(37, 36, 81);
                subcurrentBtn.ForeColor = color;
                subcurrentBtn.TextAlign = ContentAlignment.MiddleCenter;
                subcurrentBtn.IconColor = color;
                subcurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                subcurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                subleftBorderBtn.BackColor = color;
                subleftBorderBtn.Location = new Point(0, subcurrentBtn.Location.Y);
                subleftBorderBtn.Visible = true;
                subleftBorderBtn.BringToFront();
                //Icon Current Button
                iconcurrentfrom.IconChar = subcurrentBtn.IconChar;
                iconcurrentfrom.IconColor = color;
            }
        }
        private void ActivationButton(object senderBtn,Color color)
        {
            if(senderBtn != null)
            {
                DisableButton();
                //Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                //Icon Current Button
                iconcurrentfrom.IconChar = currentBtn.IconChar;
                iconcurrentfrom.IconColor = color;        
            }
        }

        private void SubDisableButton()
        {
            if(subcurrentBtn != null)
            {
                subcurrentBtn.BackColor = Color.FromArgb(20, 20, 50);
                subcurrentBtn.ForeColor = Color.Gainsboro;
                subcurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                subcurrentBtn.IconColor = Color.Gainsboro;
                subcurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                subcurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31,30,68);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }


       
        private void OpenChildForm(Form childForm)
        {

            if(currentChildForm != null)
            {
                //open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void BttnProblem_Click(object sender, EventArgs e)
        {
            ActivationButton(sender, RGBColors.color1);
            //clear child form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            //check for some condition for good UI
            if (panelSubMenu.Visible == false)
            {
                panelSubMenu.Visible = true;
                checkProblemClick = true;
            }
            else
            {
                panelSubMenu.Visible = false;
                checkProblemClick = false;
                Reset();  
            }

        }

        private void bttnSubmission_Click(object sender, EventArgs e)
        {
            if(checkProblemClick == true)
            {
                panelSubMenu.Visible = false;
                checkProblemClick = false;
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                Reset();
            }
            ActivationButton(sender, RGBColors.color3);
            titleChildform.Text = "Submission";
            OpenChildForm(new Submit());
        }


        private void bttnAbout_Click(object sender, EventArgs e)
        {
            if (checkProblemClick == true)
            {
                panelSubMenu.Visible = false;
                checkProblemClick = false;
                if (currentChildForm != null)
                {
                    currentChildForm.Close();
                }
                Reset();
            }
            ActivationButton(sender, RGBColors.color2);
            titleChildform.Text = "About Me";
            OpenChildForm(new AboutMe());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }

        private void panalHome_Click(object sender, EventArgs e)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            Reset();
        }


        private void bttnBeginner_Click(object sender, EventArgs e)
        {
            SubActivationButton(sender, RGBColors.color4);
            titleChildform.Text = "Beginner List";
            OpenChildForm(new ProblemList(1));
            if (panelOpenProblem.Visible == false)
            {
                panelOpenProblem.Visible = true;
            }
            
        }

        private void bttnDataStructure_Click(object sender, EventArgs e)
        {
            SubActivationButton(sender, RGBColors.color3);
            titleChildform.Text = "Data Structure List";
            OpenChildForm(new ProblemList(2));
            if (panelOpenProblem.Visible == false)
            {
                panelOpenProblem.Visible = true;
            }
        }

        private void bttnMathemitics_Click(object sender, EventArgs e)
        {
            SubActivationButton(sender, RGBColors.color6);
            titleChildform.Text = "Mathemitics List";
            OpenChildForm(new ProblemList(3));
            if (panelOpenProblem.Visible == false)
            {
                panelOpenProblem.Visible = true;
            }
        }

        private void bttnAdHoc_Click(object sender, EventArgs e)
        {
            SubActivationButton(sender, RGBColors.color5);
            titleChildform.Text = "Ad-Hoc List";
            OpenChildForm(new ProblemList(4));
            if (panelOpenProblem.Visible == false)
            {
                panelOpenProblem.Visible = true;
            }
        }

        private void bttnShow_Click(object sender, EventArgs e)
        {
            string SetVal = textviewProblemNo.Text.Trim();

            if (SetVal.Length != 0)
            {
                string path = Environment.CurrentDirectory + "\\src\\problem_list\\%custom_dir%".Replace("%custom_dir%", SetVal);
                if (Directory.Exists(path))
                {
                    Reset();
                    OpenChildForm(new Problem(SetVal));
                    panelOpenProblem.Visible = false;
                }
                else
                    MessageBox.Show("Worng! Please enter correct Problem No");

            }
            else
                MessageBox.Show("Please Enter the Problem No first");
        }

        private void Reset()
        {
            titleChildform.Text = "Home";
            DisableButton();
            SubDisableButton();
            leftBorderBtn.Visible = false;
            subleftBorderBtn.Visible = false;

            panelSubMenu.Visible = false;
            panelOpenProblem.Visible = false;

            iconcurrentfrom.IconChar = IconChar.Home;
            iconcurrentfrom.IconColor = Color.MediumPurple;
        }






        //Frag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg,int WParam, int lParam);

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
       
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
                WindowState = FormWindowState.Normal;
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }  
    }
}
