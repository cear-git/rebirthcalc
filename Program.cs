using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Net;
using MySql.Data.MySqlClient;
using System.IO;

namespace ConsoleApp1
{
    static class Program
    {
        public static IEnumerable<(T i, int _i)> WithIndex<T>(this IEnumerable<T> s) => s?.Select((i, _i) => (i, _i)) ?? new List<(T, int)>();
        static void Main(string[] args)
        {
            List<string> l = new List<string>();
            long c = 0;
            string w = "";
            for (int i = 0; i < 2001; i++)
            {
                l.Add($"Rebirth {i}: ${c.ToString("#,##0")}");
                c += 3000000000;
            }
            foreach(string _l in l)
            {
                w += $"{_l}\n";
            }
            File.WriteAllText("rebirth.txt", w);
            Console.ReadLine();
        }
    }
}
