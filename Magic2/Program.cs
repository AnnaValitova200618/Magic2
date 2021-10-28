using System;
using System.IO;

namespace Magic2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Magic\spells.txt.2da";
            string line, zag;
            zag = "";
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                //string[] spells = new string[57];
                for (int i = 1; i <= 3; i++) //формируем переменную с заголовком
                {
                    line = sr.ReadLine();
                    zag = zag + line + "\n";

                }
            Console.WriteLine(zag);
            //Environment.Exit(0);
            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
                while ((line = sr.ReadLine()) != null)
                {
                    line = sr.ReadLine();

                    Console.WriteLine($"%{line}%");

                    if (line.Length > 5) //проверяем, что строка не пустая
                    {
                        //Console.WriteLine($"&{line}&");
                        string[] subs = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                        Console.WriteLine($"#{string.Compare(subs[13], "****")}#");
                        Console.WriteLine($"#{subs[13]}#");
                        if (string.Compare(subs[13], "****") != -1)//проверяем что значение Паладин не содержит звёздочек
                        {

                            Console.WriteLine(subs[13]);

                            // не смогла добиться результата

                            Console.WriteLine(subs[1]);
                            Console.WriteLine(subs[9]);
                            Console.ReadKey();
                        }
                        Console.Clear();
                        //else
                        //Console.WriteLine(subs[13]);
                        //string hu = "Paladin";
                    }


                    //int index = line.IndexOf("Paladin");



                    //loc = cat.IndexOf(CapitalAWithRing, 0, cat.Length, sc);
                    //int loc = 0;

                    //loc = line.IndexOf(hu, 0, line.Length, sc);

                    //string CapitalAWithRing = "\u00c5";
                    //char[] separators = new char[] { ' ' };

                    //string[] subs = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    //foreach (var sub in subs)
                    //{
                    //onsole.WriteLine($"Substring: {sub}");
                    //}

                }

        }
    }
}
