using Microsoft.VisualBasic;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace windows_activator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            info.Verb = ("runas");
            p.StartInfo = info;
            p.Start();

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    sw.WriteLine("start https://github.com/fvc8tecbjp-py");
                    sw.WriteLine("exit");
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int option = comboBox1.SelectedIndex;
            
            switch (option)
            {
                case 0:
                    cmd_command("NTRHT-XTHTG-GBWCG-4MTMP-HH64C");
                break;
                case 1:
                    cmd_command("7HNRX-D7KGG-3K4RQ-4WPJ4-YTDFH");
                break;
                case 2:
                    cmd_command("BT79Q-G7N6G-PGBYW-4YWX6-6F4BT");
                break;
                case 3:
                    cmd_command("TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");
                break;
                case 4:
                    cmd_command("TX9XD-98N7V-6WMQ6-BX7FG-H8Q99");
                break;
                case 5:
                    cmd_command("YTMG3-N6DKC-DKB77-7M9GH-8HVX7");
                break;
                case 6:
                    cmd_command("VK7JG-NPHTM-C97JM-9MPGT-3V66T");
                break;
                case 7:
                    cmd_command("W269N-WFGWX-YVC9B-4J6C9-T83GX");
                break;
                case 8:
                    cmd_command("NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                break;
                case 9:
                    cmd_command("NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                break;
                case 10:
                    cmd_command("NRG8B-VKK3Q-CXVCJ-9G2XF-6Q84J");
                break;
                case 11:
                    cmd_command("9FNHH-K3HBT-3W4TD-6383H-6XYWF");
                break;
                case 12:
                    cmd_command("NW6C2-QMPVW-D7KKK-3GKT6-VCFB2");
                break;
                case 13:
                    cmd_command("2WH4N-8QGBV-H22JP-CT43Q-MDWWJ");
                break;
                case 14:
                    cmd_command("6TP4R-GNPTD-KYYHQ-7B7DP-J447Y");
                break;
                case 15:
                    cmd_command("YVWGF-BXNMC-HTQYQ-CPQ99-66QFC");
                break;
                case 16:
                    cmd_command("NPPR9-FWDCX-D2C8J-H872K-2YT43");
                break;
                case 17:
                    cmd_command("YYVX9-NTFWV-6MDM3-9PT4T-4M68B");
                break;
                case 18:
                    cmd_command("44RPN-FTY23-9VTTB-MP9BX-T84FV");
                break;
                case 19:
                    cmd_command("DPH2V-TTNVB-4X9Q3-TJR4H-KHJW4");
                break;
                case 20:
                    cmd_command("FWN7H-PF93Q-4GGP8-M8RF3-MDWWW");
                break;
                case 21:
                    cmd_command("M7XTQ-FN8P6-TTKYV-9D4CC-J462D");
                break;
                case 22:
                    cmd_command("92NFX-8DJQP-P6BBQ-THF9C-7CG2H");
                break;
                case 23:
                    cmd_command("WMDGN-G9PQG-XVVXX-R3X43-63DFG");
                break;
                case 24:
                    cmd_command("N69G4-B89J2-4G8F4-WWYCC-J464C");
                break;
                case 25:
                    cmd_command("WVDHN-86M7X-466P6-VHXV7-YY726");
                break;
                case 26:
                    cmd_command("DCPHK-NFMTC-H88MJ-PFHPY-QJ4BJ");
                break;
            }
        }
        void cmd_command(string argument)
        {
            progressBar1.Value = 0;
            Process p = new Process();
            ProcessStartInfo info = new ProcessStartInfo();
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.FileName = "cmd.exe";
            info.RedirectStandardInput = true;
            info.UseShellExecute = false;
            info.Verb = ("runas");
            p.StartInfo = info;
            p.Start();
            progressBar1.Value = 33;

            using (StreamWriter sw = p.StandardInput)
            {
                if (sw.BaseStream.CanWrite)
                {
                    progressBar1.Value = 66;
                    sw.WriteLine("@echo off");
                    sw.WriteLine("cscript \"C:\\Windows\\System32\\slmgr.vbs\" /ipk " + argument);
                    sw.WriteLine("cscript \"C:\\Windows\\System32\\slmgr.vbs\" /skms kms.lotro.cc");
                    sw.WriteLine("cscript \"C:\\Windows\\System32\\slmgr.vbs\" /ato");
                    sw.WriteLine("msg \"%username%\" finished!");
                    progressBar1.Value = 100;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("bill gates thanks you for using this activator!");
            System.Windows.Forms.Application.ExitThread();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}