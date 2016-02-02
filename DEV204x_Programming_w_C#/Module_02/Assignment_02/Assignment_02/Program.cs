using System;

namespace Assignment_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string toPrint = "";
            bool flip = true;

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (flip)
                    {
                        toPrint += "X";
                    }
                    else
                    {
                        toPrint += "O";
                    }
                    flip = !flip;
                }
                Console.WriteLine(toPrint);
                toPrint = "";
                flip = !flip;
            }
        }
    }
}
