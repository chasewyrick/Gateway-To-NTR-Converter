using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Gateway2NTR
{
    public partial class Converter : Form
    {
        public Converter(string G_Textbox)
        {
            InitializeComponent();
            Gateway_Textbox.Text = G_Textbox;
        }

        private void Converter_Load(object sender, EventArgs e)
        {
            Conversion();
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

        private void Conversion()
        {
            string data = Gateway_Textbox.Text;

            C_Textbox.Text = "";
            String temp = null;
            string line = null;
            StringReader LineString = new StringReader(data);

            int Tabs = 0;

            while (true)
            {
                line = LineString.ReadLine();
                if ((line == "") && (Tabs != 0))
                {
                    C_Textbox.Text += "}" + System.Environment.NewLine + System.Environment.NewLine;
                    Tabs--;
                }
                if (line == null)
                {
                    if (Tabs != 0)
                    {
                        C_Textbox.Text += "}" + System.Environment.NewLine + System.Environment.NewLine;
                        Tabs--;
                    }
                    break;
                }
                if (line.StartsWith("["))
                {
                    temp = line.Replace(" ", "_").Replace("+", "_").Replace("+", "_").Replace("-", "_"); // add more exceptions
                    temp = temp.Replace("[", "void\t").Replace("]", "(void)" + System.Environment.NewLine + "{" + System.Environment.NewLine);
                    Tabs = 1;

                    C_Textbox.Text += temp;
                }
                if (line.StartsWith("0")) // 32 bit write
                {
                    var regex = new Regex(Regex.Escape("0"));
                    temp = regex.Replace(line, "WRITEU32(offset_+_0x", 1);
                    temp = temp.Replace(" ", ", 0x");
                    temp += ");";
                    string result = new String('\t', Tabs);
                    result += temp;
                    result += System.Environment.NewLine;
                    result = result.Replace("_", " ");
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("1")) // 16 bit write
                {
                    var regex = new Regex(Regex.Escape("1"));
                    temp = regex.Replace(line, "WRITEU16(offset_+_0x", 1);
                    temp = temp.Replace(" ", ", 0x");
                    temp += ");";
                    string result = new String('\t', Tabs);
                    result += temp;
                    result += System.Environment.NewLine;
                    result = result.Replace("_", " ");
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("2")) // 8 bit write
                {
                    var regex = new Regex(Regex.Escape("2"));
                    temp = regex.Replace(line, "WRITEU8(offset_+_0x", 1);
                    temp = temp.Replace(" ", ", 0x");
                    temp += ");";
                    string result = new String('\t', Tabs);
                    result += temp;
                    result += System.Environment.NewLine;
                    result = result.Replace("_", " ");
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("DD000000 ")) // button activator
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("DD000000 "));
                    temp = regex.Replace(line, "if (is_pressed(0x", 1);
                    result += temp;
                    result += "))" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("3")) // 32 bit greater Than
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") > 0x");
                    var regex = new Regex(Regex.Escape("3"));
                    temp = regex.Replace(line, "if (READU32(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("4")) // 32 bit less Than
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") < 0x");
                    var regex = new Regex(Regex.Escape("4"));
                    temp = regex.Replace(line, "if (READU32(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("5")) // 32 bit equal
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") == 0x");
                    var regex = new Regex(Regex.Escape("5"));
                    temp = regex.Replace(line, "if (READU32(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("6")) // 32 bit not equal
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") != 0x");
                    var regex = new Regex(Regex.Escape("6"));
                    temp = regex.Replace(line, "if (READU32(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("7")) // 16 bit greater
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") > 0x");
                    var regex = new Regex(Regex.Escape("7"));
                    temp = regex.Replace(line, "if (READU16(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("8")) // 16 bit less
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") < 0x");
                    var regex = new Regex(Regex.Escape("8"));
                    temp = regex.Replace(line, "if (READU16(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("9")) // 16 bit equal
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") == 0x");
                    var regex = new Regex(Regex.Escape("9"));
                    temp = regex.Replace(line, "if (READU16(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("A")) // 16 bit not equal
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" ", ") != 0x");
                    var regex = new Regex(Regex.Escape("A"));
                    temp = regex.Replace(line, "if (READU16(offset + 0x", 1);
                    result += temp;
                    result += ")" + System.Environment.NewLine;
                    result += new String('\t', Tabs);
                    result += "{" + System.Environment.NewLine;
                    Tabs++;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("B")) // pointer
                {
                    string result = new String('\t', Tabs);
                    line = line.Replace(" 00000000", ");" + System.Environment.NewLine);
                    var regex = new Regex(Regex.Escape("B"));
                    temp = regex.Replace(line, "offset = READU32(offset + 0x", 1);
                    result += temp;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D3000000 ")) // set offset
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D3000000 "));
                    temp = regex.Replace(line, "offset = 0x", 1);
                    temp += ";" + System.Environment.NewLine;
                    result += temp;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("DC000000 ")) // add to offset
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("DC000000 "));
                    temp = regex.Replace(line, "offset += 0x", 1);
                    temp += ";" + System.Environment.NewLine;
                    result += temp;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("C000")) // loop, work on later
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("DC000000 "));
                    temp = regex.Replace(line, "offset += 0x", 1);
                    temp += ";";
                    result += temp;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D0000000") && Tabs != 0) // terminator
                {
                    Tabs--;
                    string result = new String('\t', Tabs);
                    result += "}" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D1000000")) // loop, work on later
                {
                    Tabs--;
                    string result = new String('\t', Tabs);
                    result += "}" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }

                if (line.StartsWith("D2000000") && Tabs != 0) // terminator
                {
                    string result = new String('\t', Tabs);
                    result += "offset = 0;" + System.Environment.NewLine + result + "data = 0;" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                    for (int i = 1; i < Tabs; i++)
                    {
                        result = new String('\t', (Tabs - i));
                        result += "}" + System.Environment.NewLine;
                        C_Textbox.Text += result;
                    }
                    Tabs = 1;
                }
                if (line.StartsWith("D4000000")) // add to data register
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D4000000 "));
                    temp = regex.Replace(line, "data += 0x", 1);
                    result += temp + ";" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D5000000")) // set data register
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D5000000 "));
                    temp = regex.Replace(line, "data = 0x", 1);
                    result += temp + ";" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D6000000")) // write data register to memory 32 bit
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D6000000 "));
                    temp = regex.Replace(line, "WRITEU32(offset + 0x", 1);
                    result += temp + ", data);" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D7000000")) // write data register to memory 16 bit
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D7000000 "));
                    temp = regex.Replace(line, "WRITEU16(offset + 0x", 1);
                    result += temp + ", data);" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D8000000")) // write data register to memory 8 bit
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D8000000 "));
                    temp = regex.Replace(line, "WRITEU8(offset + 0x", 1);
                    result += temp + ", data);" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("D9000000")) // load to data register 32 bit
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("D9000000 "));
                    temp = regex.Replace(line, "data = READU32(offset + 0x", 1);
                    result += temp + ");" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("DA000000")) // load to data register 16 bit
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("DA000000 "));
                    temp = regex.Replace(line, "data = READU16(offset + 0x", 1);
                    result += temp + ");" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("DB000000")) // load to data register 8 bit
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("DA000000 "));
                    temp = regex.Replace(line, "data = READU8(offset + 0x", 1);
                    result += temp + ");" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("E")) // memory patch, work on later
                {
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("DA000000 "));
                    temp = regex.Replace(line, "data = READU8(offset + 0x", 1);
                    result += temp + ");" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }
                if (line.StartsWith("F")) // memory copy
                {
                    line = line.Replace(" ", "), (void*)(offset)), 0x");
                    string result = new String('\t', Tabs);
                    var regex = new Regex(Regex.Escape("F"));
                    temp = regex.Replace(line, "memcpy((void *)(", 1);
                    result += temp + ");" + System.Environment.NewLine;
                    C_Textbox.Text += result;
                }

                this.ActiveControl = Gateway_Textbox;
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

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Restart_Timer.Start();
        }

        private void Restart_Timer_Tick(object sender, EventArgs e)
        {
            this.Opacity = this.Opacity - .1;

            if (this.Opacity == 0)
            {
                Restart_Timer.Stop();
                Application.Restart();
            }
        }

        private void Optimize_Button_Click(object sender, EventArgs e)
        {
            String readall = C_Textbox.Text;
            string line = null;
            StringReader LineString = new StringReader(readall);
            C_Textbox.Text = "";
            while (true)
            {
                line = LineString.ReadLine();
                if (line == null)
                {
                    break;
                }
                if (line.Contains("0x0"))
                {
                    for (int i = 0; i < 8; i++)
                    {
                        line = line.Replace("0x0", "0x");
                    }
                }
                if (line.Contains("0x)") || line.Contains("0x,") || line.Contains("0x;"))
                {
                    line = line.Replace("0x)", "0)").Replace("0x,", "0,").Replace("0x;", "0;");
                }
                C_Textbox.Text += line + System.Environment.NewLine;
            }
        }

        private void Build_Button_Click(object sender, EventArgs e)
        {
            String cheats_c = "#include \"cheats.h\"\n#include <stdbool.h>\n#include \"hid.h\"\n#include \"values.h\"\n#include <string.h>\n\nu32 offset = 0;\nu32 data = 0;\n\n";
            cheats_c += C_Textbox.Text;
            File.WriteAllText(System.Environment.CurrentDirectory + "/pluginMenu/Sources/cheats.c", cheats_c);
            String cheats_h = "#ifndef CHEATS_H\n#define CHEATS_H\n\n#include \"plugin.h\"\n\n";
            String create_menu_c = "#include \"cheats.h\"\n\n#define ENTRY_COUNT 300\n\ntypedef struct s_menu\n{\n\tint         count;\n\tint         status;\n\tu32         f[ENTRY_COUNT];\n\tu32         s[ENTRY_COUNT];\n\tint         a[ENTRY_COUNT];\n\tconst char  *t[ENTRY_COUNT];\n\tconst char  *n[ENTRY_COUNT];\n\tvoid        (*fp[ENTRY_COUNT])();\n}             t_menu;\n\n\ntypedef void    (*FuncPointer)(void);\nextern t_menu menu;\n\n\nvoid    new_super_unselectable_entry(char *str, FuncPointer function)\n{\n\tint index;\n\n\tindex = menu.count;\n\tif (index >= 300)\n\t\treturn;\n\tnew_unselectable_entry(str);\n\tmenu.f[index] |= BIT(0) | BIT(1);\n\tmenu.fp[index] = function;\n}\n\nvoid with_note_common(const char *name, const char *note, void (*cheatfunction)(void), int type)\n{\n\tint     index;\n\n\tif (type == 0)\n\t\tindex = new_entry((char *)name, cheatfunction);\n\telse if (type == 1)\n\t\tindex = new_radio_entry((char *)name, cheatfunction);\n\telse if (type == 2)\n\t\tindex = new_spoiler((char *)name);\n\telse return;\n\tset_note(note, index);\n}\n\ninline void new_entry_with_note(const char *name, const char *note, void (*cheatfunction)(void))\n{\n\twith_note_common(name, note, cheatfunction, 0);\n}\n\ninline void new_radio_entry_with_note(const char *name, const char *note, void (*cheatfunction)(void))\n{\n\twith_note_common(name, note, cheatfunction, 1);\n}\n\ninline void new_spoiler_with_note(const char *name, const char *note)\n{\n\twith_note_common(name, note, NULL, 2);\n}\n\nchar	*builder_name = \"" + P_Textbox.Text + "\";\n\n\t/* static const char * const code1 = \"This is a note for code1\";     #format: new_entry_with_note(\"Visible Code Name\", note_name, code_name); */\n\nvoid    my_menus(void)\n{\n";
            string line = null;
            StringReader LineString = new StringReader(C_Textbox.Text);
            while (true)
            {
                line = LineString.ReadLine();
                if (line == null)
                {
                    cheats_h += "\n#endif\n";
                    File.WriteAllText(System.Environment.CurrentDirectory + "/pluginMenu/Sources/cheats.h", cheats_h);

                    break;
                }
                if (line.StartsWith("void"))
                {
                    cheats_h += line + ";\n";
                }
            }

            string Ldata = Gateway_Textbox.Text;
            LineString = new StringReader(Ldata);
            while (true)
            {
                line = LineString.ReadLine();
                if (line == null)
                {
                    create_menu_c += "}\n";
                    File.WriteAllText(System.Environment.CurrentDirectory + "/pluginMenu/Sources/create_menu.c", create_menu_c);
                    break;
                }
                if (line.StartsWith("["))
                {
                    String originalTitle = line.Replace("[", "").Replace("]", "");
                    String newTitle = originalTitle.Replace(" ", "_").Replace("+", "_").Replace("+", "_").Replace("-", "_");
                    String MenuEntry = "\tnew_entry(\"" + originalTitle + "\", " + newTitle + ");" + System.Environment.NewLine;
                    create_menu_c += MenuEntry;
                }
            }
            System.Diagnostics.Process.Start(System.Environment.CurrentDirectory + "/pluginMenu/build.bat");
        }

        private void Copy_Button_Click(object sender, EventArgs e)
        {
            if (C_Textbox.Text != "")
            {
                Clipboard.SetText(C_Textbox.Text);
                MessageBox.Show("Copied to Clipboard!");
            }
            else
            {
                MessageBox.Show("Output cannot be empty!");
            }
        }
    }
}
