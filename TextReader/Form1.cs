using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextReader
{
    public partial class Form1 : Form
    {
        string inform = "";
        int countS = 0;
        string settings = "";
        bool Anim = true;
        int a = 0;
        private int IdSymbvols = 0;
        private string txtDrop;

        bool Theme = true;
        short IdColor = 1;

        public int PathId = 1;
        List<Color> ColorsOfInterface = new List<Color>();

        #region Paths of program..
        List<string> PathsFile = new List<string>();
        List<string> PathsDirectory = new List<string>();
        #endregion
        
        
        static string HistReturn(string path)
        {
            string txt = "";
            try
            {
                txt = File.ReadAllText(path);
            }
            catch (Exception)
            {

            }
            return txt;
        }


        public Form1()
        {
            InitializeComponent();
            
            #region Paths of program..
            PathsDirectory.Add(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.C# localSettings");
            PathsFile.Add(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.C# localSettings\Project - TextReader.txt");

            PathsDirectory.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
            PathsFile.Add(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\txt.txt");

            PathsDirectory.Add(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.C# projects\TextReader");
            PathsFile.Add(@"C:\Users\" + Environment.UserName + @"\AppData\Roaming\.C# projects\TextReader\History.txt");

            #endregion

            #region CreatingListOfColorsTheme..
            ColorsOfInterface.Add(GoButton.BackColor);
            ColorsOfInterface.Add(Color.White);
            ColorsOfInterface.Add(Color.Black);
            ColorsOfInterface.Add(panel1.BackColor);
            #endregion


            try
            {
                string s = "";
                short idParam = 1;
                settings = LoadSettings();
                foreach(char se in settings)
                {
                    if (se == ',')
                    {
                        switch (idParam)
                        {
                            case 1:
                                countS = int.Parse(s)+1;
                                inform += "Количество запусков программы = " + countS + Environment.NewLine;
                                idParam++;
                                break;
                            case 2:
                                if (int.Parse(s) == 1)
                                {
                                    IdColor = 1;
                                    Theme = true;
                                    inform += "Установлена ТЕМНАЯ тема" + Environment.NewLine;
                                }
                                else 
                                {
                                    IdColor = 1;
                                    Theme = false;
                                    inform += "Установлена СВЕТЛАЯ тема" + Environment.NewLine;
                                }
                                    
                                if (Theme == false)
                                {
                                    OutPutText.BackColor = ColorsOfInterface[IdColor];
                                    OutPutText.ForeColor = ColorsOfInterface[IdColor + 1];
                                    GoButton.BackColor = ColorsOfInterface[IdColor];
                                    GoButton.ForeColor = ColorsOfInterface[IdColor + 1];
                                    InPutText.BackColor = ColorsOfInterface[IdColor];
                                    InPutText.ForeColor = ColorsOfInterface[IdColor + 1];

                                    SwitchTheme.BackColor = ColorsOfInterface[IdColor];
                                    SwitchTheme.ForeColor = ColorsOfInterface[IdColor + 1];
                                    PathMenu.BackColor = ColorsOfInterface[IdColor];
                                    PathMenu_1.BackColor = ColorsOfInterface[IdColor];
                                    PathMenu_1.ForeColor = ColorsOfInterface[IdColor + 1];

                                    PathMenu_1_1.BackColor = ColorsOfInterface[IdColor];
                                    PathMenu_1_1.ForeColor = ColorsOfInterface[IdColor + 1];
                                    PathMenu_1_2.BackColor = ColorsOfInterface[IdColor];
                                    PathMenu_1_2.ForeColor = ColorsOfInterface[IdColor + 1];

                                    Tools_1.BackColor = ColorsOfInterface[IdColor];
                                    Tools_1.ForeColor = ColorsOfInterface[IdColor + 1];
                                    Tool_1.BackColor = ColorsOfInterface[IdColor];
                                    Tool_1.ForeColor = ColorsOfInterface[IdColor + 1];
                                    Tool_2.BackColor = ColorsOfInterface[IdColor];
                                    Tool_2.ForeColor = ColorsOfInterface[IdColor + 1];
                                    Tool_3.BackColor = ColorsOfInterface[IdColor];
                                    Tool_3.ForeColor = ColorsOfInterface[IdColor + 1];

                                    IdColor--;
                                }
                                idParam++;
                                break;

                            case 3:
                                if (int.Parse(s) == 1) { Anim = true; inform += "Анимации текста включены" + Environment.NewLine; }
                                 else { Anim = false; inform += "Анимации текста выключены" + Environment.NewLine; }
                                idParam++;
                                break;
                                
                            case 4:
                                switch(s)
                                {
                                    case "1":
                                        PathId = 1;
                                        inform += "Путь сохранения истории: DeskTop" + Environment.NewLine;
                                        break;
                                    case "2":
                                        PathId = 2;
                                        inform += "Путь сохранения истории: AppData" + Environment.NewLine;
                                        break;
                                }
                                idParam++;
                                break;
                        }
                        
                        s = "";
                    }
                    else
                    {
                        s += se;
                    }
                }
                idParam = 0;
                SaveSettings();
            }
            catch (Exception)
            {
                Directory.CreateDirectory(PathsDirectory[0]);
            }
            //AnimTxt("\tСтарт программы." + Environment.NewLine + "Ожидается ввод текста..", Anim);
            //inform += "\tСтарт программы." + Environment.NewLine + "Ожидается ввод текста..";
            AnimTxt("\tСтарт программы." + Environment.NewLine + "Ожидается ввод текста..", Anim);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            bool endbutton = false;
            if (Directory.Exists(PathsDirectory[PathId]) == false) Directory.CreateDirectory(PathsDirectory[PathId]);
            string history = HistReturn(PathsFile[PathId]);

            if(InPutText.Text.Length == 0) SaveSettings();

            string word = "";
            foreach (char sym in InPutText.Text.ToLower())
            {
                word += sym;
                switch (word)
                {
                    case "/info":
                        InPutText.Text = "";
                        AnimTxt("/del\t- удаление истории ввода из текущей директории;" + Environment.NewLine + "/anim __\t- включени/выключение анимации текста (on/off);" + Environment.NewLine + "/path __\t- директория хранения истории (1 - DeskTop, 2 - AppData);" + Environment.NewLine + inform,Anim);
                        goto EndButton;
                    case "/del":
                        File.Delete(PathsFile[PathId]);
                        InPutText.Text = "";
                        AnimTxt("Файл с историей успешно удален.", Anim);
                        SaveSettings();
                        goto EndButton;
                    case "/path 1":
                        PathId = 1;
                        InPutText.Text = "";
                        AnimTxt($"Настройки успешно применены. Выбран путь - DeskTop", Anim);
                        SaveSettings();
                        goto EndButton;
                    case "/path 2":
                        PathId = 2;
                        InPutText.Text = "";
                        AnimTxt($"Настройки успешно применены. Выбран путь - Appdata", Anim);
                        SaveSettings();
                        goto EndButton;
                    case "/anim off":
                        Anim = false;
                        InPutText.Text = "";
                        AnimTxt("Анимация текста успешно выключена." ,Anim);
                        SaveSettings();
                        goto EndButton;
                    case "/anim on":
                        Anim = true;
                        InPutText.Text = "";
                        AnimTxt("Анимация текста успешно включена.", Anim);
                        SaveSettings();
                        goto EndButton;
                    default:
                        SaveSettings();
                        break;
                }
            }
            SettingsEnd:

            File.WriteAllText(PathsFile[PathId], history + InPutText.Text + Environment.NewLine);
            history = HistReturn(PathsFile[PathId]);
            InPutText.Text = "";
            AnimTxt(history, Anim);


            //if (InPutText.Text.Length != 0)
            //{
            //    if (InPutText.Text[0] == '`')
            //    {
            //        File.Delete(PathsFile[PathId]);
            //    }
            //}
        EndButton:
            endbutton = !endbutton;
        }

        string LoadSettings()
        {
            string settings = File.ReadAllText(PathsFile[0]);
            string outT = "";
            string word = "";
            bool tr = false;
            foreach(char s in settings)
            {
                if (s == ']')
                {
                    tr = false;
                    outT += word + ',';
                }

                if (tr)
                {
                    word += s;
                }
                else
                {
                    word = "";
                }

                if (s == '[')
                {
                    tr = true;
                }


            }
            return outT;
        }
        void SaveSettings()
        {
            string txt = "";
            
            txt += $"count [{countS}]" + Environment.NewLine;
            
            if (Theme) txt += $"theme [1]" + Environment.NewLine; else txt += "theme [0]" + Environment.NewLine;
            
            if (Anim) txt += "anim [1]" + Environment.NewLine; else txt += "anim [0]" + Environment.NewLine;
            
            switch (PathId)
            {
                case 1:
                    txt += $"path [{PathId}]" + Environment.NewLine;
                    break;
                case 2:
                    txt += $"path [{PathId}]" + Environment.NewLine;
                    break;
                default:
                    txt += "path 1" + Environment.NewLine;
                    break;
            }

            
            File.WriteAllText(PathsFile[0], txt);
        }

        void AnimTxt(string txt, bool anim)
        {
            if (anim)
            {
                timer1.Interval = 5;
                OutPutText.Text = null;
                GoButton.Enabled = false;
                PathMenu.Enabled = false;
                txtDrop = txt;
                timer1.Start();
            }
            else
            {
                txtDrop = txt;
                OutPutText.Text = txt;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            OutPutText.Text += txtDrop[IdSymbvols++];

            if (IdSymbvols == txtDrop.Length)
            {
                GoButton.Enabled = true;
                PathMenu.Enabled = true;
                IdSymbvols = 0;
                timer1.Stop();
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (Theme)
            {
                //переключение на светлую тему
                OutPutText.BackColor = ColorsOfInterface[IdColor];
                OutPutText.ForeColor = ColorsOfInterface[IdColor + 1];
                GoButton.BackColor = ColorsOfInterface[IdColor];
                GoButton.ForeColor = ColorsOfInterface[IdColor + 1];
                InPutText.BackColor = ColorsOfInterface[IdColor];
                InPutText.ForeColor = ColorsOfInterface[IdColor + 1];

                SwitchTheme.BackColor = ColorsOfInterface[IdColor];
                SwitchTheme.ForeColor = ColorsOfInterface[IdColor + 1];
                PathMenu.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1.ForeColor = ColorsOfInterface[IdColor + 1];

                PathMenu_1_1.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1_1.ForeColor = ColorsOfInterface[IdColor + 1];
                PathMenu_1_2.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1_2.ForeColor = ColorsOfInterface[IdColor + 1];

                Tools_1.BackColor = ColorsOfInterface[IdColor];
                Tools_1.ForeColor = ColorsOfInterface[IdColor + 1];
                Tool_1.BackColor = ColorsOfInterface[IdColor];
                Tool_1.ForeColor = ColorsOfInterface[IdColor + 1];
                Tool_2.BackColor = ColorsOfInterface[IdColor];
                Tool_2.ForeColor = ColorsOfInterface[IdColor + 1];
                Tool_3.BackColor = ColorsOfInterface[IdColor];
                Tool_3.ForeColor = ColorsOfInterface[IdColor + 1];

                IdColor--;
            }
            else
            {
                //переключение на темную тему
                OutPutText.BackColor = ColorsOfInterface[IdColor];
                OutPutText.ForeColor = ColorsOfInterface[IdColor + 1];
                GoButton.BackColor = ColorsOfInterface[IdColor];
                GoButton.ForeColor = ColorsOfInterface[IdColor + 1];
                InPutText.BackColor = ColorsOfInterface[IdColor];
                InPutText.ForeColor = ColorsOfInterface[IdColor + 1];

                SwitchTheme.BackColor = ColorsOfInterface[IdColor];
                SwitchTheme.ForeColor = ColorsOfInterface[IdColor + 1];
                PathMenu.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1.ForeColor = ColorsOfInterface[IdColor + 1];

                PathMenu_1_1.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1_1.ForeColor = ColorsOfInterface[IdColor + 1];
                PathMenu_1_2.BackColor = ColorsOfInterface[IdColor];
                PathMenu_1_2.ForeColor = ColorsOfInterface[IdColor + 1];

                Tools_1.BackColor = ColorsOfInterface[IdColor];
                Tools_1.ForeColor = ColorsOfInterface[IdColor + 1];
                Tool_1.BackColor = ColorsOfInterface[IdColor];
                Tool_1.ForeColor = ColorsOfInterface[IdColor + 1];
                Tool_2.BackColor = ColorsOfInterface[IdColor];
                Tool_2.ForeColor = ColorsOfInterface[IdColor + 1];
                Tool_3.BackColor = ColorsOfInterface[IdColor];
                Tool_3.ForeColor = ColorsOfInterface[IdColor + 1];

                IdColor++;
            }
            Theme = !Theme;
            //OutPutText.Text = Convert.ToString(Theme);
            SaveSettings();
        }

        #region Any.. trashcan

        private void InPutText_TextChanged(object sender, EventArgs e)
        {

        }

        private void path1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //OutPutText.Text = "wtf";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #endregion
        private void appDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region DeskTop..
            AnimTxt($"Настройки успешно применены. Выбран путь - DeskTop", Anim);
            PathId = 1;
            SaveSettings();
            #endregion
        }


        private void appDataRoamingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            #region AppData..
            AnimTxt($"Настройки успешно применены. Выбран путь - Appdata", Anim);
            PathId = 2;
            SaveSettings();
            #endregion
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            File.Delete(PathsFile[PathId]);
            AnimTxt("Файл с историей успешно удален.", Anim);
            SaveSettings();
        }

        private void Tool_2_Click(object sender, EventArgs e)
        {
            if (Anim)
            {
                Anim = false;
                AnimTxt("Анимация текста успешно выключена.", Anim);
                SaveSettings();
            }
            else
            {
                Anim = true;
                AnimTxt("Анимация текста успешно включена.", Anim);
                SaveSettings();
            }
        }

        private void Tool_3_Click(object sender, EventArgs e)
        {
            AnimTxt("/del\t- удаление истории ввода из текущей директории;" + Environment.NewLine + "/anim __\t- включени/выключение анимации текста (on/off);" + Environment.NewLine + "/path __\t- директория хранения истории (1 - DeskTop, 2 - AppData);", Anim);
        }
    }

    

}
