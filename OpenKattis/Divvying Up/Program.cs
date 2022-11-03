using System;

namespace myNamespace
{
    class myProgram
    {
        static void Main()
        {
            string str = Console.ReadLine();
            str = Console.ReadLine();

            string[] values = str.Split(" ");

            int totalWinnings = 0;
            int numberOfComptetions = values.Length;
        
            for(int i = 0; i < numberOfComptetions; i++)
            {
                totalWinnings = totalWinnings + int.Parse(values[i]);
            }

            if(totalWinnings % 3 == 0)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }    
        }
    }
}
