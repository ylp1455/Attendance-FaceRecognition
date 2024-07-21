using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPython.Hosting;
using TheArtOfDev.HtmlRenderer.Adapters;
 using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System.Diagnostics;


namespace C_Assingment
{
    public partial class dashboard : Form
    {
        public dashboard()
        {
            InitializeComponent();
        }


        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("marked");
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("dasboard");
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("add");
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("marking");
        }

        private void bunifuButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("update");
        }

        private void bunifuButton6_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("about");
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton13_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("add");
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("marking");
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("marked");
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("update");
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            bunifuPages1.SetPage("about");
        }

        private void bunifuButton14_Click(object sender, EventArgs e)
        {

            try {

                Process process = new Process();
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = "cmd.exe"; // Set the program to be executed (CMD)

                // Set the working directory to the desired path
                startInfo.WorkingDirectory = @"C#Assingment\Python\main\";

                // Set the first command to change the directory
                startInfo.Arguments = "/k cd " + startInfo.WorkingDirectory;

                // Execute the first command to change the directory
                process.StartInfo = startInfo;
                process.Start();

                // Wait for the first command to complete before executing the second command
                

                // Reset the arguments for the second command (main.exe)
                startInfo.Arguments = "/c main.exe";

                // Execute the second command (main.exe)
                process.StartInfo = startInfo;
                process.Start();

            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }


        }
    }
}
