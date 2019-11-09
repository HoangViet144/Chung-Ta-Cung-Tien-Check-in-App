using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment_oop
{
    //Double Check Locking Singleton
    public sealed class dataManager
    {
        private static int counter = 0;
        private static readonly object Instancelock = new object();
        private dataManager()
        {
            //do something
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static dataManager instance = null;

        public static dataManager GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new dataManager();
                        }
                    }
                }
                return instance;
            }
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
       /* public classRoom readFromFile(string session, string subject)
        {
            string fileName = session + "_" + subject + ".csv";
            classRoom tmp = new classRoom();
            //stu
            //tmp.insert()
            return tmp;
        }*/
        public void writeToFile(string session, string subject,string toWrite)
        {
            string fileName = session + "_" + subject + ".csv";
            string filePath = "D:\\" + fileName;
            classRoom tmp = new classRoom();
            //stu
            //tmp.insert()
            var csv = new StringBuilder();

            //in your loop
            var first = "viet";
            var second = toWrite;
            //Suggestion made by KyleMit
            var newLine = string.Format("{0},{1}", first, second);
            csv.AppendLine(newLine);

            //after your loop
            File.WriteAllText(filePath, csv.ToString());
        }
    }
}
