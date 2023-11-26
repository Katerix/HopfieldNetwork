using HopfieldNetwork.Data;

namespace HopfieldNetwork.Services
{
    public static class OutputService
    {
        public static void DisplayLetter(Letter letter)
        {
            var matrix = letter.Representation;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var value = matrix[i, j];

                    if (value == 1)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.Write("\n");
            }
        }
    }
}