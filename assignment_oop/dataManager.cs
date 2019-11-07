using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
