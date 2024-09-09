using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Win32;

// This app automtizes steps, described on this thread from serverFault portal:
// https://superuser.com/questions/1537466/how-to-change-language-of-windows-10-single-language-without-format

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

        private string ExecudeCommand(string Command, bool Showlog=true)
        {
            // Bing AI answer: simple cmd execute
            Process myProc = new Process();
            myProc.StartInfo.FileName = "cmd.exe";
            myProc.StartInfo.Arguments = "/C "+Command;
            myProc.StartInfo.RedirectStandardOutput = true;
            myProc.StartInfo.UseShellExecute = false;
            myProc.StartInfo.CreateNoWindow = true;

            myProc.Start();

            string cmdOut = myProc.StandardOutput.ReadToEnd();
            myProc.WaitForExit();

            if (Showlog)
            {
                textBox3.Clear();
                textBox3.Text = cmdOut;
            }
            return cmdOut;
        }

        private void RefreshLngList(bool showLog)
        {

            string[] oneLine = [""];
            oneLine = ExecudeCommand("dism /online /get-packages", showLog).Split(Environment.NewLine);

            for (int i = 0; i < oneLine.Length; i++)
            {
                if (oneLine[i].Contains("Microsoft-Windows-Client-LanguagePack-Package") == true)
                {
                    string[] langLine = oneLine[i].Split("~");
                    if (!listBox1.Items.Contains(langLine[3]))
                    {
                        listBox1.Items.Add(langLine[3]);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {            

            RefreshLngList(true);

            //listBox1.Items.AddRange(langLines);
            //listBox2.Items.AddRange(cmdOut.Split(Environment.NewLine));

            LangDicStor langDicStor = new LangDicStor();

            // Registry processing in C# are simple: Open subKey (Tree Brunch), modify key, close subkey.
            // https://codingvision.net/c-edit-registry-keys-or-values
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Nls\Language", true);
            textBox2.Text = langDicStor.GetLang(key.GetValue("Default").ToString());

            

            radioButton1.Enabled = true;

            foreach (var lang in langDicStor.GetFullList())
            {
                comboBox1.Items.Add(lang.Value);
            }

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
                "only overwrite either with this, or similar app./n/n Are you saved all your opened docs and ready to apply this path and reboot?", "Are yo ready to patch yor system?", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            comboBox1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex >= 0)
            {
                button2.Text = "Plaese wait ...";
                ExecudeCommand("powershell Install-Language -Language "+comboBox1.Text);
                RefreshLngList(false);
                //MessageBox.Show("powershell Install-Language -Language " + comboBox1.Text, "Info", MessageBoxButtons.OK);
                button2.Text = "Install Done!";
            }
        }
    }
}
