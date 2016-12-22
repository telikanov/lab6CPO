using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {            
            string[] input = File.ReadAllText(@"C:\Users\telik\OneDrive\Документы\Visual Studio 2015\Projects\Slozhnaaa\Slozhnaaa\Program.cs").Replace("\r", "").Replace("\n", "").Split(' ');
            List<string> lex_table = new List<string>();
            foreach (string str in input)
            {
                if (!lex_table.Contains(str))
                {
                    if (str == " ")
                    {

                    }
                    if (str.Contains("if") || str.Contains("else") || str.Contains("then"))
                    {
                        lex_table.Add(str);
                        lex_table.Add("       Ключевое слово");
                    }
                    if (str.Contains("<") || str.Contains(">") || str.Contains("=="))
                    {
                        lex_table.Add(str);
                        lex_table.Add("       Знак логического сравнения");
                    }
                    if (str.Contains("(") || str.Contains(")") || str.Contains(";"))
                    {
                        lex_table.Add(str);
                        lex_table.Add("       Разделительный символ");
                    }
                    if (str.Contains(":="))
                    {
                        lex_table.Add(str);
                        lex_table.Add("       Символ присваивания");
                    }
                    if (str.Contains("result") || str.Contains("count"))
                    {
                        lex_table.Add(str);
                        lex_table.Add("       Константа");
                    }
                    if (str.Contains("0") || str.Contains(",") || str.Contains("1"))
                    {
                        lex_table.Add(str);
                        lex_table.Add("       Числовое значение");
                    }
                }
            }
            for (int i = 0; i < lex_table.Count; i = i + 2)
            {
                Console.WriteLine(lex_table[i] + lex_table[i + 1]);
            }
            Console.ReadKey();

        }
    }

}
