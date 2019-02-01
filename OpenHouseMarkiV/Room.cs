using System;
using System.Collections.Generic;
using System.Text;

namespace OpenHouseMarkiV
{
    class Room
    {
        public string Name { get; set; }
        public bool HasHardwoods { get; set; }
        public List<string> Descriptions { get; set; } = new List<string>();
        public int numberOFRooms { get; set; }

        
          public Room(string name, bool hasHardwoods, int numberOFRooms, bool hasGhosts)

          {
            Name = name;
            HasHardwoods = hasHardwoods;
            numberOFRooms = 0;
            
          }


        static void ShowRoom(Room roomToShow)
        {
            string answer = Program.GetUserResponse("Would you like to see" + "bathroom" + roomToShow.Name);
            if (Program.IsAffirmative(answer))
            {
                Console.WriteLine("Do you want to see the shower");
            }
            foreach (string description in roomToShow.Descriptions) 
            {
                Console.WriteLine(description);
            }
            if (answer == "Yes")
            {
                Console.WriteLine("How long have been a home owner?");
            }
            else
            {
                Console.WriteLine("Are you currently looking to buy property in this area!");
                string response2 = Console.ReadLine();

                Console.WriteLine("Do you currently own a home");
                string response3 = Console.ReadLine();
                answer = Console.ReadLine();


                Console.WriteLine();
            }
                       
        }
                          
    }
    
}

    


