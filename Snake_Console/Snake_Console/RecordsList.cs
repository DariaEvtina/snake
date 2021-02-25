using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake_Console
{
    class RecordsList
    {
        public int strScores;
        public string name;
        public string WriteName()
        {
            Console.WriteLine("==================================\n ENTER YOURE NICKNAME OR USERNAME \n==================================");
            name = Console.ReadLine();
            return name;
        }
        public int strScoresPlus()
        {
            strScores += 1;
            return strScores;
        }
        public void WriteInRecords(string n,int s)
        {
            StreamWriter f = new StreamWriter(@"..\..\records.txt", true);
            f.WriteLine("\n" + n + " : " + s);
            f.Close();
        }
    }
}
