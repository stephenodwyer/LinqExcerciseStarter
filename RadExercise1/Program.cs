using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadExercise1
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        static void QuestionOne(string[] args)
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    Console.WriteLine(c.Info);
                }
                Console.ReadKey();
            }
        }

        static void QuestionTwo(DateTime date)
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    var query2 = from clbE in c.ClubEvents
                                 where clbE.StartDateTime.Date == date.Date
                                 select clbE;

                    foreach (ClubEvent clbE in query2)
                    {
                        Console.WriteLine(clbE.Venue);
                    }
                }
            }

        }

        static void QuestionThree()
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    var query3 = from clbE in c.ClubEvents
                                 where c.ClubName == "ITS FC"
                                 select clbE;

                    foreach (ClubEvent clbE in query3)
                    {
                        Console.WriteLine(c.ClubName + ' ' + clbE.Venue);
                    }
                }
            }
        }

        static void QuestionFour()
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    var query4 = from m in c.ClubMembers
                                 where m.approved == true
                                 select m;

                    foreach (Member m in query4)
                    {
                        Console.WriteLine(m.StudentID);
                    }
                }
            }
        }

        static void QuestionFive()
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    var query5 = from m in c.ClubMembers
                                 where m.approved == false
                                 select m;

                    foreach (Member m in query5)
                    {
                        Console.WriteLine(m.StudentID);
                    }
                }
            }
        }

        //static void QuestionSix()
        //{
        //    using (TestDbContext db = new TestDbContext())
        //    {
        //        foreach (Club c in db.Clubs)
        //        {


        //        }
        //    }
        //}

        static void QuestionSeven()
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    var query7 = from clbN in db.Clubs
                                 orderby clbN.ClubName ascending
                                 select clbN;

                    Console.WriteLine(c.ClubName);
                }
            }
        }

        static void QuestionEight()
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    var query8 = from a in db.Clubs
                                 join b in db.Students on a.adminID equals b.playerid
                                 orderby b.FirstName
                                 select b;

                    foreach (Student stud in query8)
                    {
                        Console.WriteLine(stud.FirstName + ' ' + stud.SecondName);
                    }
                }
            }
        }

        static void QuestionNine()
        {
            using (TestDbContext db = new TestDbContext())
            {
                foreach (Club c in db.Clubs)
                {
                    //var query9 = 
                }
            }
        }
    }
}
