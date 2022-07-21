using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace MorphoAccessDateTimeSync
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Path.Combine(new string[]
            {
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location)
            }) + "\\ListMorphoAccess.txt";
            if (!File.Exists(text))
            {
                Console.WriteLine("ListMorphoAccess.txt not found! \nCreate file ListMorphoAccess.txt contains your MorphoAccess IPs");
                return;
            }
            using (var fs = new FileStream(text, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (var sr = new StreamReader(fs, Encoding.Default))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine("Synchronizing Date Time for Morpho Access with ip: "+line);
                        
                        var date = SyncDateTime.SetDateAndTimeConfiguration(line, DateTime.Now);
                        if (date[0].ToString() != "0")
                        {
                            foreach (var d in date)
                            {
                                Console.WriteLine(d);
                            }
                            continue;
                        }
                        foreach (var d in date)
                        {
                            Console.WriteLine(d);
                        }
                        date = SyncDateTime.GetDateAndTimeConfiguration(line);
                        foreach (var d in date)
                        {
                            Console.WriteLine(d);
                        }
                        Console.WriteLine("-------------");
                    }
                    sr.Dispose();
                }
                fs.Dispose();
            }
            Console.WriteLine("Done.");
        }
    }
}
