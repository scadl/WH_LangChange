using System.Diagnostics;
using Microsoft.Win32;

namespace WH_LangChange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox2.WordWrap = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bing AI answer: simple cmd execute
            Process myProc = new Process();
            myProc.StartInfo.FileName = "cmd.exe";
            myProc.StartInfo.Arguments = "/C dism /online /get-packages";
            myProc.StartInfo.RedirectStandardOutput = true;
            myProc.StartInfo.UseShellExecute = false;
            myProc.StartInfo.CreateNoWindow = true;

            myProc.Start();

            string[] oneLine = [""];
            string cmdOut = myProc.StandardOutput.ReadToEnd();
            myProc.WaitForExit();
            oneLine = cmdOut.Split(Environment.NewLine);

            for (int i = 0; i < oneLine.Length; i++)
            {
                if (oneLine[i].Contains("Microsoft-Windows-Client-LanguagePack-Package") == true)
                {
                    string[] langLine = oneLine[i].Split("~");
                    listBox1.Items.Add(langLine[3]);
                }
            }

            //listBox1.Items.AddRange(langLines);
            //listBox2.Items.AddRange(cmdOut.Split(Environment.NewLine));

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Nls\Language", true);
            textBox2.Text = key.GetValue("Default").ToString();

            textBox3.Text = cmdOut;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (this.Size.Height < 1060 ) {
                this.Size = new Size(638, 1062);
            } else
            {
                this.Size = new Size(638, 578);
            }
        }
    }
}
