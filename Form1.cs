using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shutupedge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string ExecuteCommand(string command)
        {

            ProcessStartInfo procStartInfo = new ProcessStartInfo("cmd", "/c " + command)
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process proc = new Process())
            {
                proc.StartInfo = procStartInfo;
                proc.Start();

                string output = proc.StandardOutput.ReadToEnd();

                if (string.IsNullOrEmpty(output))
                    output = proc.StandardError.ReadToEnd();

                return output;
            }

        }

        private void removebrowser_Click(object sender, EventArgs e)
        {
            Form2 ProgressForm = new Form2();
            ProgressForm.Show();
            ProgressForm.Text = "Uninstalling Microsoft Edge..";
            ProgressForm.Refresh();
            ExecuteCommand("taskkill /f /im msedge.exe");
            string output = ExecuteCommand("winget uninstall Microsoft.Edge --accept-source-agreements");
            if (output.Contains("No installed"))
            {
                ProgressForm.Close();
                MessageBox.Show(("Microsoft Edge isn't installed"), "ShutUpEdge");
            }
            else
            {
                ProgressForm.Close();
                MessageBox.Show(("Uninstalled Microsoft Edge"), "ShutUpEdge");
            }
        }

        private void installbrowser_Click(object sender, EventArgs e)
        {
            Form2 ProgressForm = new Form2();
            ProgressForm.Show();
            ProgressForm.Text = "Installing Microsoft Edge.. (this can take some time)";
            ProgressForm.Refresh();
            string output = ExecuteCommand("winget install Microsoft.Edge --accept-source-agreements  --accept-package-agreements");
            if (output.Contains("installed"))
            {
                ProgressForm.Close();
                MessageBox.Show(("Installed Microsoft Edge"), "ShutUpEdge");
            }
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ma0us/shutupedge");
        }
    }
}
