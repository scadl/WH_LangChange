using System.Diagnostics;

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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Bing AI answer: simple cmd execute
            Process myProc = new Process();
            myProc.StartInfo.FileName = "cmd.exe";
            myProc.StartInfo.Arguments = "/C dir";
            myProc.StartInfo.RedirectStandardOutput = true;
            myProc.StartInfo.UseShellExecute = false;
            myProc.StartInfo.CreateNoWindow = true;

            myProc.Start();

            string cmdOut = myProc.StandardOutput.ReadToEnd();
            myProc.WaitForExit();

            Console.WriteLine(cmdOut);
            label1.Text = cmdOut;
        }


    }
}
