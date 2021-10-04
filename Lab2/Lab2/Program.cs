using System;
using System.IO;
using System.Net.Mime;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            replace_text();

        }

        static void replace_text()
        {

            using (FileStream file = new FileStream(@"C:\UsersПолина\source\repos\Laba_2\Laba_2\text.txt", FileMode.Open,
                FileAccess.Read))
            {
                byte[] array = new byte[file.Length];

                file.Read(array, 0, array.Length);

                string textFromFile = System.Text.Encoding.Default.GetString(array);
                Console.WriteLine($"Текст из файла: {textFromFile}");

                Console.WriteLine("Введите слово которое надо заменить: ");
                string word1 = Console.ReadLine();


                if (!textFromFile.Contains(word1))
                {
                    Console.WriteLine("Слово не найдено");
                }
                else
                {
                    
                    Console.WriteLine("Введите слово на которое надо заменить: ");
                    string word2 = Console.ReadLine();

                    string text = File.ReadAllText(@"C:\UsersПолина\source\repos\Laba_2\Laba_2\text.txt");
                    text = Regex.Replace(text, word1, word2);

                    File.WriteAllText($"note.txt", text);
                    Console.WriteLine($"Текст из файла: {text}");
                }

                Console.ReadLine();
            }
        }
    }
}