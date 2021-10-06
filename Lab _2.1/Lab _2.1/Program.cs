using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab__2._1
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
        public static string replace_text(string text, string word1, string word2)
        {

                if (!text.Contains(word1))
                {
                text = "Слово не найдено";
               
                }
                else
                {
                    text = Regex.Replace(text, word1, word2);
                }

                Console.ReadLine();
            return text;
            }
        }
 
    }

