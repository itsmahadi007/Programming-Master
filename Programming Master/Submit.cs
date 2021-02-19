using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Master
{
    public partial class Submit : Form
    {
        public Submit()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string problem_No = textboxProblemNo.Text.Trim();
            string code = textboxCode.Text;

            string header_file = "a.cpp";
         //   string py_file = "compiler.exe";
            string finaloutput = "finaloutput.txt";
            

            string s_path_py = Environment.CurrentDirectory + @"\compiler-tester.exe";

            string s_path_src = Environment.CurrentDirectory + @"\src\problem_solution\";
            string s_path = Path.Combine(s_path_src, problem_No);

           

            // string s_path1 = Path.Combine(s_path, testFolder);// change dir to test  folder
            string s_path2 = Path.Combine(s_path, header_file);// a.cpp file location
            string s_path_output = Path.Combine(s_path, finaloutput);// finaloutput file location


            if (!File.Exists(s_path2))
            {
                File.CreateText(s_path2);
                File.WriteAllText(s_path2, code);

            }
            else
            {
                File.WriteAllText(s_path2, code);
                //await File.WriteAllTextAsync(s_path2, code);
            }

            //System.Threading.Thread.Sleep(1000);

            try
            {
                //  C: \Users\itsma\anaconda3
                Process.Start(s_path_py);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            System.Threading.Thread.Sleep(4000);

            MessageBox.Show(File.ReadAllText(s_path_output));
        }
    }
}
