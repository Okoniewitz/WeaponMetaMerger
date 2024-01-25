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

namespace WeaponMetaMerger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] TextFile = new string[2] { "", "" };
        private void Start_Click(object sender, EventArgs e)
        {
            try
            {
                string[] Files = new string[2] { File1_Name.Text, File2_Name.Text };
                string[] files = Directory.GetFiles(WorkSpace.Text);
                TextFile[0] = FindFile(0, files, Files);
                TextFile[1] = FindFile(1, files, Files);
                File1.Text = File.ReadAllText(TextFile[0]);
                File2.Text = File.ReadAllText(TextFile[1]);
                File1_Label.Text = TextFile[0];
                File2_Label.Text = TextFile[1];
            } catch(Exception exc) { MessageBox.Show(exc.Message,"Błąd"); }
        }

        private string FindFile(int index, string[] str, string[] neededStr)
        {
            foreach (string file in str)
            {
                if (file.Contains(neededStr[index]))
                    return file;
            }
            return "";
        }
        private int[] FindLines(string[] File, string From, string To)
        {
            int FromIndex=0, ToIndex=0;
            foreach (string line in File)
            {
                if (line.Contains(From) && FromIndex == 0)
                    FromIndex = Array.IndexOf(File, line) + 1;
                if (line.Contains(To) && FromIndex != 0)
                    ToIndex = Array.IndexOf(File, line) + 1;
            }
            return new int[2] { FromIndex, ToIndex };
        }

        private void Merge_Click(object sender, EventArgs e)
        {
            string From = Edit1.Text;
            string To = "</"+Edit1.Text.Substring(1,Edit1.Text.Length-1);
            string EditText="";
            int[]Lines = FindLines(File2.Lines, From, To);
            List<string> EditLines = new List<string>();
            foreach(string line in File2.Lines)
            {
                 if(Array.IndexOf(File2.Lines, line)>= Lines[0]- 1 && Array.IndexOf(File2.Lines, line)<= Lines[1]- 1)
                {
                    EditLines.Add(line);
                }
            }
            string TextBefore = File1.Text.Substring(0, File1.Text.IndexOf(From));
            string TextAfter = File1.Text.Substring(File1.Text.IndexOf(To)+To.Length, File1.Text.Length - File1.Text.IndexOf(To)-To.Length);
            foreach(string line in EditLines)
            {
                EditText += line+ Environment.NewLine;
            }
            File4.Text = TextBefore +EditText+ TextAfter;
            EditLines.Clear();

            From = Edit2.Text;
            To = "</" + Edit2.Text.Substring(1, Edit2.Text.Length - 1);
            EditText = "";
            Lines = FindLines(File2.Lines, From, To);
            foreach (string line in File2.Lines)
            {
                if (Array.IndexOf(File2.Lines, line) >= Lines[0] - 1 && Array.IndexOf(File2.Lines, line) <= Lines[1] - 1)
                {
                    EditLines.Add(line);
                }
            }
            TextBefore = File4.Text.Substring(0, File4.Text.IndexOf(From));
            TextAfter = File4.Text.Substring(File4.Text.IndexOf(To) + To.Length, File4.Text.Length - File4.Text.IndexOf(To) - To.Length);
            foreach (string line in EditLines)
            {
                EditText += line + Environment.NewLine;
            }
            File3.Text = TextBefore + EditText + TextAfter;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            { 
            File.WriteAllText(TextFile[0].Substring(0,TextFile[0].IndexOf("pickups"))+".meta", File3.Text);
                File.Delete(TextFile[0]);
                File.Delete(TextFile[1]);
            }
            catch (Exception exc) { MessageBox.Show(exc.Message, "Błąd"); }
        }
    }
}
