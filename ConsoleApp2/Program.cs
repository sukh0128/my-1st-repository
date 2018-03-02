
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 2;

        

            for (int i = 0; i < N; i++)
            {
                string word = Console.ReadLine();
                List<char> word_list = word.ToList();
                List<string> odds = new List<string>();
                List<string> evens = new List<string>();
                int word_size = word.Length;

                for (int j = 0; j < word_size; j++)
                {

                    Console.Write(j);
                    if (j % 2 == 0)
                    {
                        evens.Add(char.ToString(word_list[j]));
                        Console.WriteLine("gaga");
                    }
                    else if (j % 2 != 0)
                    {

                        odds.Add(char.ToString(word_list[j]));
                        Console.WriteLine("dada");
                    }
                }
               
                for (int a = 0; a < evens.Count; a++)
                {
                    Console.Write(evens[a]);

                }
                Console.Write("");
                for (int a = 0; a < odds.Count; a++)
                {
                    Console.Write(odds[a]);
                }
                Console.ReadLine();
            }
            }
        }
    }

