using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Security.Principal;
//using System.Security.Cryptography; 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TextHistory();

            //Console.ReadKey();
        }

        static void TextHistory()
        {
        StartFunction:
            string UserNameWin = Environment.UserName;
            //Console.Write("1/any (AppData): ");
            string path = @"C:\Users\" + UserNameWin + @"\AppData\Roaming\.NamesFolder\Names.txt";
            string pathDir = @"C:\Users\" + UserNameWin + @"\AppData\Roaming\.NamesFolder";

            //bool PathIf = Console.ReadLine() == "1" ? true : false;
            bool PathIf = false;

            if (PathIf)
            {
                var DeskTopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                path = DeskTopPath + @"\.NamesFolder\Names.txt";
                pathDir = DeskTopPath + @"\.NamesFolder";
            }

            bool speedAnim = true;
            char SpeedHist = '~';
            string history = HistoryReturn(path);
            

            if (history != "")
            {
                if (history[0] == '~') 
                { 
                    history = history.Remove(0, 2);
                } 
                else 
                { 
                    speedAnim = false;
                    SpeedHist = '`';
                    history = history.Remove(0, 2);
                }
                if (history[0] == '\n') history = history.Remove(0, 1);
            }


            if (Directory.Exists(pathDir) == false)
            {
                Directory.CreateDirectory(pathDir);
            }

            //
            foreach(char symb in "Введите текст: ")
            {
                Console.Write(symb);
                if (speedAnim == true) Thread.Sleep(25);
            }
            string WriteWord = Console.ReadLine();
            File.WriteAllText(path, SpeedHist + "\n" + history + WriteWord + '[' + DateTime.Now + '|' + "\n");
            history = HistoryReturn(path);

            //

            AnimTxt("\nИстория введенных данных: ", speedAnim);

            string word = "";
            string date = "";
            int i = 0;
            bool DateOrWord = false;
            if (history != "")
            {
                foreach (char symbol in history)
                {
                    switch (symbol)
                    {
                        case '~':
                            break;
                        case '`':
                            break;
                        case '\n':
                            break;
                        case '[':
                            DateOrWord = true;
                            break;
                        case '|':
                            DateOrWord = false;
                            AnimTxt(" "+ ++i + ")\t" + date + " \t" + word, speedAnim);
                            word = "";
                            date = "";
                            break;
                        default:
                            if (DateOrWord)
                            {
                                date += symbol;
                            }
                            else
                            {
                                word += symbol;
                            }
                            break;
                    }

                }
            }

        //
        Mark1:
            AnimTxt("\n\nКоманды для ввода:\n   r\t- перезапуск программы;\n   del\t- удаление каталога с историей введенных команд;\n   info\t- получить информацию;\n   on/off\t- включить/выключить анимацию ввода текста;\n *Ввод иных команд приведет к закрытию программы.\n", speedAnim);

            switch (Console.ReadLine().ToLower())
            {
                case "info":
                    AnimTxt("\n  - Путь к каталогу с файлом хрянищим данные: AppData\\Roaming\\.NamesFolder;\n  - Каталог \".NamesFolder\" был создан программой, не хранит в себе ничего, кроме истории ввода;\n  - После выполнения команды \"del\" будет удален каталог \".NamesFolder\";\n  - Открыть каталог \"AppData\" можно сочетанием клавиш \"Win + R\", вводом \"%AppData%\"  и нажатием \"Ок\";\n *Перед удалением программы выполните команду \"del\", что-бы избавиться от ненужного каталога на системном диске.", speedAnim);
                    goto Mark1;
                case "off":
                    speedAnim = false;
                    SpeedHist = '`';
                    File.WriteAllText(path, SpeedHist + history);
                    history = HistoryReturn(path);
                    AnimTxt("  Анимации выключены (0.8 sec..)", speedAnim);
                    Thread.Sleep(800);
                    goto Mark1;
                case "on":
                    speedAnim = true;
                    SpeedHist = '~';
                    File.WriteAllText(path, SpeedHist + history);
                    history = HistoryReturn(path);
                    AnimTxt("  Анимации включены (0.8 sec..)", speedAnim);
                    Thread.Sleep(800);
                    goto Mark1;
                case "s":
                    goto EndProgram;
                case "del":
                    AnimTxt("  **Вы действительно хотите удалить исторю? (yes/no)",speedAnim);
                    if (Console.ReadLine().ToLower() == "yes")
                    {
                        
                        Directory.Delete(pathDir,true);
                        AnimTxt("\t*История успешно удалена..", speedAnim);
                        goto Mark1;
                    }
                    else
                    {
                        AnimTxt("\t*История не тронута..", speedAnim);
                        goto Mark1;
                    }
                case "r":
                    AnimTxt("  Запущен рестарт программы (0.8 sec..)", speedAnim);
                    Thread.Sleep(800);
                    Console.Clear();
                    goto StartFunction;
                case "r0":
                    Console.Clear();
                    goto StartFunction;
            }
            AnimTxt("  Программа закрывается (1.2 sec..)", speedAnim);
            Thread.Sleep(1200);
        EndProgram:
            Console.WriteLine();
        }
        
        static string HistoryReturn(string path)
        {
            string txt = "";
            bool speed = true;
            try
            {
                txt = File.ReadAllText(path);
                if (path[0] == '`')
                {
                    speed = false;
                }
            }
            catch (Exception)
            {
                AnimTxt("   Первый запуск...\n\tДанная программа умеет запоминать однажды введенные в нее данные, после чего выводит их.\n",speed);
            }
            return txt;
        }

        static void AnimTxt(string txt, bool speed)
        {
            int i = 0;
            foreach (char sym in txt)
            {
                Console.Write(sym);
                if (speed == true)
                {
                    Thread.Sleep(30 - i);
                    if (i < 15) i++;
                }
            }
            Console.WriteLine();
        }
        
    }
}
