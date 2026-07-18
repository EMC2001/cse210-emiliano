using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    
    {     
        while(true)
        {
            Console.Clear();

            Console.WriteLine("Menu");
            Console.WriteLine("1 Lecture");
            Console.WriteLine("2 Reception");
            Console.WriteLine("3 Outdoor Gathering");
            Console.WriteLine("4 Quit");
            Console.Write("Select a choice from the menu: ");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Address lectureAddress = new Address(
                    "52 S 1st N",
                    "Rexburg",
                    "Idaho",
                    83440
                );

                Lecture lecture = new Lecture("Brother Godderidge", 67, lectureAddress);
                lecture.DisplayLectureFullInformation();
            }
            
            else if (userChoice == "2")
            {
                Address receptionAddress = new Address(
                    "67 S 89st N",
                    "West Columbia",
                    "Texas",
                    83440
                );

                Reception reception = new Reception(
                    "Hello, this Email is just a reminder to please confirm your attendance to our Big Cool Wedding. Please reply to this email to confirm your attendance.", 
                    receptionAddress);
                reception.DisplayReceptionFullInformation();
                
            }
            
            else if (userChoice == "3")
            {
                
            }
            
            else if (userChoice == "4")
            {
                break;
            }  
        }


    }
}