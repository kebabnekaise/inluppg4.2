using System;
using System.Runtime.InteropServices;

namespace inluppg4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int highestNum = 0;
            while (true)
            {
                Console.WriteLine("Skriv ett heltal. Skriv \"exit\" för att avsluta programmet");
                string input = Console.ReadLine();
                
                if (input != "exit")
                {
                    int num = int.Parse(input);
                    if (num > highestNum)
                    {
                        highestNum = num;
                    }
                }
                else
                {
                    Console.WriteLine("Högsta numret var " + highestNum);
                    return;
                }
            }
            
        }
    }
}