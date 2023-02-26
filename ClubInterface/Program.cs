using System;
namespace Club
{
    interface IClub
    {
        //Properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        string DisplayName();

        int DisplayTier();

        int DisplayAge();

        string DisplayRewards();


        //Methods




    }
    class Program
    {
        class ClubMember : IClub
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public int Tier { get; set; }

            public int Age { get; set; } 

            public string RewardsMember { get; set; }

            
        
            public ClubMember()
            {
                Id = 0;
                FirstName = string.Empty;
                LastName = string.Empty;
                Tier = 0;
                Age = 0;
                RewardsMember = string.Empty;

            }
            public ClubMember(int id, string firstName, string lastName, int tier, int age, string rewardsmember)
            {
                Id = id;
                FirstName = firstName;
                LastName = lastName;
                Tier = tier;
                Age = age;
                RewardsMember = rewardsmember;
               
            }

            public string DisplayName()
            {
                return FirstName + " " + LastName;



            }
            public int DisplayTier()
            {
                return Tier;



            }
            public int DisplayAge()
            {
                return Age;



            }
            public string DisplayRewards()
            {
                return RewardsMember;



            }

        }

      
        static void Main(string[] args)
        {
            //ClubMember object created using parameterized constructor
            ClubMember bob = new ClubMember(10, "Bob", "Williams", 1, 50, "Rewards Member: Yes");
            Console.WriteLine("Member Information:");
            Console.WriteLine("Full Name: " + bob.DisplayName());
            Console.WriteLine("Member Tier: " + bob.DisplayTier());
            Console.WriteLine("Age: " + bob.DisplayAge());
            Console.WriteLine(bob.DisplayRewards());
            Console.WriteLine();


            //ClubMember object created using the default constructor
            //values are assigned using properties
            ClubMember tim = new ClubMember();
            tim.Id = 20;
            tim.FirstName = "Tim";
            tim.LastName = "Williams";
            tim.Tier = 2;
            tim.Age = 30;
            tim.RewardsMember = "Rewards Member: No";
            Console.WriteLine("Member Information:");
            Console.WriteLine("Full Name: " + tim.DisplayName());
            Console.WriteLine("Member Tier: " + tim.DisplayTier());
            Console.WriteLine("Age: " + tim.DisplayAge());
            Console.WriteLine(tim.DisplayRewards());
            Console.WriteLine();


        }
    }
}
