using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cinema_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do  //infinite loop to replay the booking system after user is finished
            {
                List<string> filmlist = new List<string>();  //this chunk is creating the lists and adding the data to them
                List<int> ratings = new List<int>();
                filmlist.Add("Rush");
                filmlist.Add("How I live now");
                filmlist.Add("Thor: the dark world");
                filmlist.Add("Filth");
                filmlist.Add("Planes");
                ratings.Add(15);
                ratings.Add(15);
                ratings.Add(12);
                ratings.Add(18);
                ratings.Add(0);

                int film = 0;
                int catcher = 0;
                Console.WriteLine("Welcome to Aquinas Multiplex\r\nWe are presently showing:\r\n1. Rush (15)\r\n2. How I Live Now (15)\r\n3. Thor: The Dark World (12)\r\n4. Filth (18)\r\n5. Planes (U)"); //telling the user the movies available
                while (catcher == 0)
                {


                    try //asking user to input the data they need to see the movie, i.e movie number and age. selection is used to tell the user if they are too young
                    {
                        Console.WriteLine("please enter the number of the film you want to see");
                        film = int.Parse(Console.ReadLine());
                        catcher = 1;
                    }
                    catch
                    {
                        Console.WriteLine("please enter a number");  

                    }
                    if (film > 5 || film < 1)
                    {
                        Console.WriteLine("please enter a number between one and five");
                        film = int.Parse(Console.ReadLine());
                    }
                }
                try
                {
                    Console.WriteLine("enter your age please");
                    int age = int.Parse(Console.ReadLine());
                }catch
                {
                    console.WriteLine("please enter a number")
                    age = int.parse(Console.ReadLine());    
                }
                string filmchoice = filmlist[film - 1];
                int rating = ratings[film - 1];
                catcher = 0;
                while (catcher == 0)
                {
                    if (age < rating)
                    {
                        Console.WriteLine("sorry you are too young for this movie");
                        Console.WriteLine("please enter your age");
                        age = int.Parse (Console.ReadLine());
                    }
                    else
                    {
                      
                        DateTime current = DateTime.Now;       //this chunck is deciding the date for the movie and checking if it is valid
                        Console.WriteLine("you have selected " + filmchoice + " rated " + rating);
                        try
                        {
                            Console.WriteLine("please enter a date, no longer than a week away");
                            string dateString = Console.ReadLine();
                        } catch
                        { 

                        }
                        
                        DateTime date = DateTime.Parse(dateString);
                        TimeSpan weeks = date.Subtract(current);
                        double totaldays = weeks.TotalDays;


                        if (totaldays > 7)
                        {
                            Console.WriteLine("please no longer than a week away");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("--------------------\r\nAquinas Multiplex\r\nFilm : " + filmchoice + " \r\nDate : " + date.Date + " \r\nEnjoy the film\r\n--------------------");
                            Console.ReadLine();
                            Console.Clear();
                        }
                        catcher = 1;
                    }
                }
            }while (true);
        }
    }
}
