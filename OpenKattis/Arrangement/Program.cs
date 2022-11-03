using System;

namespace myNamespace
{
    class myProgram
    {
        static void Main()
        {
            int numberOfRooms = int.Parse(Console.ReadLine());
            int numberOfTeams = int.Parse(Console.ReadLine());

            int teamsPerRoom = numberOfTeams / numberOfRooms;
            int remainder = numberOfTeams % numberOfRooms;

            for (int i = 0; i < numberOfRooms; i++)
            {
                for (int j = 0; j < teamsPerRoom; j++)
                {
                    Console.Write("*");
                }
                if (remainder > 0)
                {
                    Console.Write("*");
                    remainder--;
                }
                Console.WriteLine();
            }
        }
    }

}
