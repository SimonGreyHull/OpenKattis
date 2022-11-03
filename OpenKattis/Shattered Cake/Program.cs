using System;

namespace myNamespace
{
    class myProgram
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());

            int numberOfPieces = int.Parse(Console.ReadLine());

            int totalArea = 0;

            for(int i = 0; i < numberOfPieces; i++)
            {
                string str = Console.ReadLine();
                string[] dimensionStrings = str.Split(" ");

                int pieceWidth = int.Parse(dimensionStrings[0]);
                int pieceHeight = int.Parse(dimensionStrings[1]);

                totalArea = totalArea + pieceWidth * pieceHeight;
            }

            int length = totalArea / width;

            Console.WriteLine(length);
        }
    }

}
