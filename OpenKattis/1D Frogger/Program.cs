using System;

namespace myNamespace
{
    class myProgram
    {
        static void Main()
        {
            string line = Console.ReadLine();
            string[] values = line.Split(" ");

            int numberOfBoardSquares = int.Parse(values[0]);
            int currentIndex = int.Parse(values[1]) - 1;
            string magicNumberString = values[2];

            int numberOfHops = 0;

            line = Console.ReadLine();
            values = line.Split(" ");

            string result = String.Empty;

            bool gameRunning = true;

            do
            {
                if (values[currentIndex] == magicNumberString)
                {
                    gameRunning = false;
                    result = "magic";
                    continue;
                }

                if (values[currentIndex] == "visited")
                {
                    gameRunning = false;
                    result = "cycle";
                    continue;
                }

                int hop = int.Parse(values[currentIndex]);
                values[currentIndex] = "visited";

                currentIndex = currentIndex + hop;
                numberOfHops++;





                if (currentIndex < 0)
                {
                    result = "left";
                    gameRunning = false;
                    continue;
                }

                if(currentIndex >= values.Length)
                {
                    result = "right";
                    gameRunning =false;
                    continue;
                }
            } while(gameRunning);

            Console.WriteLine(result);
            Console.WriteLine(numberOfHops);
            
        }
    }

}
