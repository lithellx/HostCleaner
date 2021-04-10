using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ResetHosts
{
    public partial class Form1 : Form
    {
        public Form1()
        {
			FormClosed += Form1_FormClosed;
			FormClosing += Form1_FormClosing;
			InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
			try
			{
				File.WriteAllText("C:\\Program Files (x86)\\connect.bat", Text_BatEditClear.Text);
				File.WriteAllText("C:\\Program Files (x86)\\connect.bat", Text_BatEditClear.Text);
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Program Files (x86)\\connect.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
				File.Delete("C:\\Program Files (x86)\\connect.bat");
				if (!Directory.Exists("C:\\Windows\\System32\\drivers\\etc"))
				{
					Directory.CreateDirectory("C:\\Windows\\System32\\drivers\\etc");
				}
				if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\networks"))
				{
					StreamWriter streamWriter = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\networks");
					streamWriter.Write("");
					streamWriter.Close();
				}
				if (File.Exists("C:\\Windows\\System32\\drivers\\etc\\networks"))
				{
					StreamWriter streamWriter2 = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\networks");
					streamWriter2.Write("");
					streamWriter2.Close();
					if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts"))
					{
						File.Copy("C:\\Windows\\System32\\drivers\\etc\\networks", "C:\\Windows\\System32\\drivers\\etc\\hosts");
					}
					if (!File.Exists("C:\\Windows\\System32\\drivers\\etc\\hosts.ics"))
					{
						File.Copy("C:\\Windows\\System32\\drivers\\etc\\networks", "C:\\Windows\\System32\\drivers\\etc\\hosts.ics");
					}
					Process.Start(new ProcessStartInfo("cmd", "/c echo|attrib +h +s +a %windir%\\System32\\drivers\\etc\\hosts.ics & echo|attrib +h +s +a \"%windir%\\System32\\drivers\\etc\\hosts.ics\" & echo|attrib +h +s +a %windir%\\System32\\drivers\\etc\\hosts & echo|attrib +h +s +a \"%windir%\\System32\\drivers\\etc\\hosts\"")
					{
						WindowStyle = ProcessWindowStyle.Hidden
					});
				}
				Process.Start("notepad", "C:\\Windows\\System32\\drivers\\etc\\hosts");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu.", "HackinGuide.Net - Host Cleaner");
			}
		}

        private void button2_Click(object sender, EventArgs e)
        {
			try
			{
				File.WriteAllText("C:\\Program Files (x86)\\connect.bat", Text_BatResetClear.Text);
				File.WriteAllText("C:\\Program Files (x86)\\connect.bat", Text_BatResetClear.Text);
				Process process = new Process();
				process.StartInfo.FileName = "C:\\Program Files (x86)\\connect.bat";
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
				File.Delete("C:\\Program Files (x86)\\connect.bat");
				if (!Directory.Exists("C:\\Windows\\System32\\drivers\\etc"))
				{
					Directory.CreateDirectory("C:\\Windows\\System32\\drivers\\etc");
				}
				if (File.Exists("C:\\Windows\\System32\\drivers\\etc\\networks"))
				{
					File.Copy("C:\\Windows\\System32\\drivers\\etc\\networks", "C:\\Windows\\System32\\drivers\\etc\\hosts.ics");
					File.Copy("C:\\Windows\\System32\\drivers\\etc\\networks", "C:\\Windows\\System32\\drivers\\etc\\hosts");
					Process.Start(new ProcessStartInfo("cmd", "/c echo|attrib +h +s +a %windir%\\System32\\drivers\\etc\\hosts.ics & echo|attrib +h +s +a \"%windir%\\System32\\drivers\\etc\\hosts.ics\" & echo|attrib +h +s +a %windir%\\System32\\drivers\\etc\\hosts & echo|attrib +h +s +a \"%windir%\\System32\\drivers\\etc\\hosts\"")
					{
						WindowStyle = ProcessWindowStyle.Hidden
					});
				}
				MessageBox.Show("İşlem tamamlandı.", "HackinGuide.Net - Host Cleaner");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Bir hata oluştu.", "HackinGuide.Net - Host Cleaner");
			}
		}

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (File.Exists("C:\\Program Files (x86)\\connect.bat"))
            {
                File.Delete("C:\\Program Files (x86)\\connect.bat");
            }
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (File.Exists("C:\\Program Files (x86)\\connect.bat"))
            {
                File.Delete("C:\\Program Files (x86)\\connect.bat");
            }
            Application.Exit();
        }
    }
}
