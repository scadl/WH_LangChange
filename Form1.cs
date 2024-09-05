using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WH_LangChange
{
    public partial class Form1 : Form
    {

        int curWd;
        int curHt;
        int logHg;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //textBox2.WordWrap = true;
            curWd = this.Size.Width;
            curHt = this.Size.Height;
            logHg = textBox3.Size.Height;
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

            LangDicStor langDicStor = new LangDicStor();

            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Nls\Language", true);
            textBox2.Text = langDicStor.GetLang(key.GetValue("Default").ToString());

            textBox3.Text = cmdOut;

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (this.Size.Height <= curHt)
            {
                this.Size = new Size(curWd, curHt + logHg + 25);
            }
            else
            {
                this.Size = new Size(curWd, curHt);
            }
        }

        private void yes_cnage(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmAct = MessageBox.Show("You are about to change you computer registry values. On your windows edition, there is no way to roll back this action; " +
                "only overwrite either with this, or similar app./n/n Are you saved all your opened docs and ready to apply this path and reboot?", "Are yo ready to patch yor system?", MessageBoxButtons.YesNo);
            if (confirmAct == DialogResult.Yes)
            {

                string tgCode = listBox1.SelectedItem.ToString();

                RegistryKey keyNew = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Nls\Language", true);
                keyNew.SetValue("Default", tgCode);
                keyNew.SetValue("InstallLanguage", tgCode);

                Process.Start("shutdown", "/r /t 0");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioButton2.Enabled = true;
        }

        private void no_change(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Console.WriteLine(openFileDialog1.FileName);
            }
        }
    }
}
