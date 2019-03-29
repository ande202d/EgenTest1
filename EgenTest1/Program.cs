using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EgenTest1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> Dic = new Dictionary<int, string>();
            string path1 = "C:\\Test\\TestXml.xml";
            StringBuilder CsvString = new StringBuilder();
            
            Dic.Add(1001,"A");
            Dic.Add(1002,"B");
            Dic.Add(1003,"C");

            Console.WriteLine("Before Dictionary clear");
            foreach (var dicKey in Dic.Keys)
            {
                CsvString.AppendFormat("{0},{1}", dicKey, Dic[dicKey]);
                CsvString.AppendLine();
                Console.WriteLine($"key: {dicKey}, value: {Dic[dicKey]}");
            }

            Dic.Clear();
            Dic.Add(1007, "X");
            Dic.Add(1008, "Y");
            Dic[1001] = "Hej";



            Console.WriteLine("\nAfter dictionary clear");
            foreach (var dicKey in Dic.Keys)
            {
                CsvString.AppendFormat("{0},{1}", dicKey, Dic[dicKey]);
                CsvString.AppendLine();
                Console.WriteLine($"key: {dicKey}, value: {Dic[dicKey]}");
            }

            File.WriteAllText(path1,CsvString.ToString());

            Console.WriteLine("\nPrinting the file");
            Console.WriteLine(CsvString.ToString());
            


            foreach (var value in Dic.Values)
            {
                
            }
            //File.WriteAllLines(path1, _dt.Columns);


            //if (!File.Exists(path1)) File.Create(path1);
            
            foreach (int s in Dic.Keys)
            {
                //File.WriteAllLines(path1,a1);
                //File.AppendAllLines(path1,$"");
            }

            


            Console.ReadKey();

            //File.Exists("C:\\TestCsv.csv")

        }
    }
}
