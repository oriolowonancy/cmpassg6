using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practisingswitchstatement
{
    class Program
    {
        static void Main(string[] args)
        {
            string FULLNAME;
            string GREETING;
            Console.Write("PLEASE ENTER YOUR FULLNAME: ");
            FULLNAME = Console.ReadLine();

            switch (FULLNAME)
            {
                case "BILL GATES":
                    GREETING = "NICE JOB ON C#";
                    break;
                case "JAMES GOSLING":
                    GREETING = "NICE JOB ON JAVA";  
                    break;
                default:
                    GREETING = "WE AWAIT YOUR CONTRIBUTION TO COMPUTER SCIENCE " + FULLNAME;
                    break;
            }
                    Console.WriteLine(GREETING);
                    Console.ReadLine();
        }
    }
}
