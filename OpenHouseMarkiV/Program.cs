using System;

namespace OpenHouseMarkiV
{
    class Program
    {
        public static string GetUserResponse(string question)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            return response;
        }

        public static bool IsAffirmative(string userResponse)

        {
            userResponse = userResponse.ToUpper();

            if (userResponse == "YEAH" || userResponse == "YES" || userResponse == "Yes" || userResponse == "Please")

            {
                return true;
            }

            else

            {
                return false;
            }

        }

        public static void ShowRoom(Room roomToShow)

        {
            string answer = GetUserResponse("Would you like to see the " + roomToShow.Name);
            if (IsAffirmative(answer))

            roomToShow.Name = "bathroom";
            roomToShow.Name = "livingroom";

        }

        static void Main(string[] args)

        {
            Room livingRoom = new Room("Living Room", false, 4, false);
            livingRoom.Name = "Living Room";
            livingRoom.HasHardwoods = true;
            livingRoom.Descriptions.Add("I can see myself living here!");

            Room bathRoom = new Room("bathRoom", true, 2, true);
            bathRoom.Name = "Bathroom";
            bathRoom.HasHardwoods = false;
            bathRoom.Descriptions.Add("bathroom");

            Console.WriteLine("Welcome! Thank you for coming to open house today!");

            string name = GetUserResponse("What is your name?");

            Console.WriteLine("Do you know anyone looking to buy a home in this area?");
            string answer = Console.ReadLine();

            Console.WriteLine("Do you have time for me to show you the house?");
            string answer1 = Console.ReadLine();

            Console.WriteLine("How soon will you be interested to mmove to the area?");
            string answer2 = Console.ReadLine();

            Console.WriteLine("Would you feel confident referring my services to other buyers and sellers?");
            string answer3 = Console.ReadLine();

            Console.WriteLine("Do you have any questions?");
            string response = Console.ReadLine();

            if (IsAffirmative(answer))
            {
                answer = GetUserResponse("Would you like to see the house?");
                answer = GetUserResponse("Would you like to see the bathroom?");
            }

            if (IsAffirmative(answer))
            { 
                Console.WriteLine("Do you want to see the heated shower");
            }
            if (answer == "Yes")

            {
                Console.WriteLine("How long have been a home owner?");
                answer = Console.ReadLine();
            }

            else

                Console.WriteLine("Are you currently looking to buy property in this area!");
            string response2 = Console.ReadLine();

            Console.WriteLine("Do you currently own a home");
            string response3 = Console.ReadLine();
            answer = Console.ReadLine();

            if (answer == "yes")

            { 
            Console.WriteLine("Are you thinking about selling or buying a new home!");
            answer = Console.ReadLine();
            }
            else
                   
            Console.WriteLine("Tell me, what is your plan for finding your next home!");
                       
            Console.ReadLine();

        }
    }
}