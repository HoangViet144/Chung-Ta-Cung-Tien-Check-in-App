using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace assignment_oop
{
    class classManager
    {
        private dataManager _dataManager;
        public classManager()
        {
            _dataManager = dataManager.GetInstance;         
        }
        public void writeTest(string session, string subject, string toWrite)
        {
            // _dataManager.writeToFile(session, subject, toWrite);
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
