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

namespace Gateway2NTR
{
    public partial class Gateway : Form
    {
        public Gateway()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FI_Timer.Start();
        }

        protected override void OnMouseDown(MouseEventArgs e)

        {
            base.OnMouseDown(e);
            if (e.Button == MouseButtons.Left)
            {
                this.Capture = false;
                Message msg = Message.Create(this.Handle, 0XA1, new IntPtr(2), IntPtr.Zero);
                this.WndProc(ref msg);
            }
        }

        private void FI_Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity + .1;

            if (this.Opacity == 1)
            {
                FI_Timer.Stop();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FO_Timer.Start();
        }

        private void FO_Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - .1;

            if (this.Opacity == 0)
            {
                FO_Timer.Stop();
                Application.Exit();
            }
        }

        private void nDSCodetypeReferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://doc.kodewerx.org/hacking_nds.html");
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All codes need to have a name, enclosed in brackets []." + System.Environment.NewLine + System.Environment.NewLine + "If a code does not convert properly, please leave a comment on my YouTube video (DarkFlare69)." + System.Environment.NewLine + System.Environment.NewLine + "The Automatic Code Checker will only check certain elements of your input to ensure the codes will convert properly. This assumes your input is still valid codes.", "Information", MessageBoxButtons.OK);
        }

        private void creditsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Program by DarkFlare" + System.Environment.NewLine + "NTR CFW by cell9" + System.Environment.NewLine + "Blank Cheat Menu by Nanquitas" + System.Environment.NewLine + "Application Rewrite by 6ilent", "Credits", MessageBoxButtons.OK);
        }

        private void G_Button_Click(object sender, EventArgs e)
        {
            this.G_Button.Click += new System.EventHandler(this.G_Button_Click);
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.Title = "Open Text File";
            FileDialog.Filter = "Text files|*.txt";
            if (FileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = FileDialog.FileName;
                string[] filelines = File.ReadAllLines(filename);
                G_Textbox.Text = "";
                foreach (string line in filelines)
                {
                    G_Textbox.Text += line + System.Environment.NewLine;
                }
            }
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            string line = null;
            StringReader LineString = new StringReader(G_Textbox.Text);

            int SpaceCount = 1;
            int BracketCount = 0;

            while (true)
            {
                line = LineString.ReadLine();
                if (line == null)
                {
                    if (BracketCount == SpaceCount)
                    {
                        Next_Timer.Start();
                    }
                    else
                    {
                        MessageBox.Show("There appears to be a problem with your codes. Assuming you inputted actual codes, this is probably due to improper/missing titles or lack of space between codes.", "Results", MessageBoxButtons.OK);
                    }
                    break;
                }
                if (line == "")
                {
                    SpaceCount++;
                }
                if (line.StartsWith("[") && line.Contains("]"))
                {
                    BracketCount++;
                }
            }
        }

        private void Next_Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - .1;

            if (this.Opacity == 0)
            {
                Next_Timer.Stop();
                this.Hide();

                Converter Converter = new Converter(G_Textbox.Text);
                Converter.ShowDialog();
            }
        }
    }
}
