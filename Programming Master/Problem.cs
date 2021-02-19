using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Programming_Master
{
    public partial class Problem : Form
    {
        string custom_dir;
        public Problem(string val)
        {
            InitializeComponent();
            custom_dir = val;

        }

        private void Problem_Load(object sender, EventArgs e)
        {
            textboxinput1.SelectionAlignment = HorizontalAlignment.Center;
            textboxinput2.SelectionAlignment = HorizontalAlignment.Center;
            textboxinput3.SelectionAlignment = HorizontalAlignment.Center;

            textboxoutput1.SelectionAlignment = HorizontalAlignment.Center;
            textboxoutput2.SelectionAlignment = HorizontalAlignment.Center;
            textboxoutput3.SelectionAlignment = HorizontalAlignment.Center;



            string path = Environment.CurrentDirectory + "\\src\\problem_list\\%custom_dir%".Replace("%custom_dir%", custom_dir);
            string problem_file = "problem.txt";
            string input_file1 = "input_sample_1.txt";
            string input_file2 = "input_sample_2.txt";
            string input_file3 = "input_sample_3.txt";
            string output_file1 = "output_sample_1.txt";
            string output_file2 = "output_sample_2.txt";
            string output_file3 = "output_sample_3.txt";
            string header_file = "header.txt";

            string data;

            string name_Path = Path.Combine(path, header_file);
            data = File.ReadAllText(name_Path);
            labelHeader.Text = data;

            string problem_Path = Path.Combine(path, problem_file);
            data = File.ReadAllText(problem_Path);
            textboxProblem.Text = data;

            string input_Path_1 = Path.Combine(path, input_file1);
            data = File.ReadAllText(input_Path_1);
            textboxinput1.Text = data;

            string input_Path_2 = Path.Combine(path, input_file2);
            data = File.ReadAllText(input_Path_2);
            textboxinput2.Text = data;

            string input_Path_3 = Path.Combine(path, input_file3);
            data = File.ReadAllText(input_Path_3);
            textboxinput3.Text = data;

            string output_Path_1 = Path.Combine(path, output_file1);
            data = File.ReadAllText(output_Path_1);
            textboxoutput1.Text = data;

            string output_Path_2 = Path.Combine(path, output_file2);
            data = File.ReadAllText(output_Path_2);
            textboxoutput2.Text = data;

            string output_Path_3 = Path.Combine(path, output_file3);
            data = File.ReadAllText(output_Path_3);
            textboxoutput3.Text = data;

        }
    }
}
