using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace TextAnalysis
{
    public class Program
    {
        static void Main(string[] args)
        {           
            Dictionary<string, int> dic = new Dictionary<string, int>();
            FileStream fs = new FileStream(@"D:\shevchenko-taras-hryhorovych-kobzar3545.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line = sr.ReadToEnd();
            string[] st = line.Split(' ', '.', ',', '!', '?', '"', '(', ')', '\n');
            
            for (int i = 0; i < st.Length; i++)
            {
                if (!dic.ContainsKey(st[i]))
                {
                    if (st[i].Length > 3)
                    {
                        dic.Add(st[i], 1);
                    }
                }
                else
                {
                    dic[st[i]] += 1;
                }
            }

            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(string.Format("{0} - згадується {1} раз", st[i].ToLowerInvariant(), st[i].Count()));
            }            
        }
    }
}

