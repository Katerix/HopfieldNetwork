using HopfieldNetwork.Data;
using HopfieldNetwork.Services;

public class Program
{
    public const double K = 0.9;

    public static void Main(string[] args)
    {
        var weights = Training(); var iterator = 1;

        foreach (var letter in TestData.Letters)
        {
            Console.WriteLine($"TEST CASE {iterator}: \n");
            Console.WriteLine("Input: ");
            OutputService.DisplayLetter(letter);
            Console.WriteLine();

            var result = Recognize(letter.Representation, weights);

            if (result.Item2 == -1)
            {
                Console.WriteLine("Letter was not recognized :(");
            }
            else
            {
                Console.WriteLine("Recognized letter: ");
                OutputService.DisplayLetter(ExistingLetters.Letters.ElementAt(result.Item2));
                Console.WriteLine($"\n  Similarity: {result.Item1 * 100}%");
            }

            Console.WriteLine();

            iterator++;
        }
    }

    public static int[,] Training()
    {
        int[,] weights = new int[10,10];

        foreach (var letter in ExistingLetters.Letters)
        {
            var preparedMatrix = Multiply(Transpose(letter.Representation), letter.Representation);

            if (weights.Length == 0)
            {
                weights = preparedMatrix;
            }
            else 
            {
                weights = Add(weights, preparedMatrix);
            }
        }

        for (int i = 0; i < weights.GetLength(0); i++)
        {
            for (int j = 0; j < weights.GetLength(1); j++)
            {
                weights[i, j] = weights[i, j] / weights.GetLength(1);
            }
        }

        return weights;
    }

    public static (double, int) Recognize(int[,] inputLetter, int[,] weights)
    {
        int iterations = 100;
        var result = Transpose(inputLetter);

        for (int i = 0; i < iterations; i++)
        {
            result = Multiply(weights, result);

            for (int j = 0; j < ExistingLetters.Letters.Count(); j++)
            {
                var similarity = CompareMatrices(inputLetter, ExistingLetters.Letters.ElementAt(j).Representation);

                if (similarity > K)
                {
                    return (similarity, j);
                }     
            }
        }

        return (0, -1);
    }

    static double CompareMatrices(int[,] inputLetter, int[,] existingLetter)
    {
        double similarity = 0;

        for (int i = 0; i < inputLetter.GetLength(0); i++)
        {
            for (int j = 0; j < inputLetter.GetLength(1); j++)
            {
                if (inputLetter[i, j] == existingLetter[i, j]) similarity++;
            }
        }

        return similarity / inputLetter.Length;
    }

    static int[,] Transpose(int[,] matrix)
    {
        int[,] result = new int[10, 10];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                result[j, i] = matrix[i, j];
            }
        }

        return result;
    }

    static int[,] Multiply(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[10, 10];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0;

                for (int k = 0; k < matrix1.GetLength(1); k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }

                result[i, j] = sum;
            }
        }

        return result;
    }

    static int[,] Add(int[,] matrix1, int[,] matrix2)
    {
        int[,] result = new int[10, 10];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j]; 
            }
        }

        return result;
    }
}