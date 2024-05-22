namespace Assingment_3._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrixArray1 = { { 1, 2 }, { 3, 4 } };
            int[,] matrixArray2 = { { 5, 6 }, { 7,8 } };

            Console.WriteLine("The first matrix is: ");

            for (int i = 0; i < matrixArray1.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray1.GetLength(1); j++)
                {
                    Console.Write("|");                    
                    Console.Write(matrixArray1[i,j]);
                   
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("The second matrix is: ");
            for (int i = 0; i < matrixArray2.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray2.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(matrixArray2[i, j]);                   
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("The addition of the two matrices is:");
            for (int i = 0; i < matrixArray1.GetLength(0); i++)
            {
                for (int j = 0; j < matrixArray1.GetLength(1); j++)
                {
                    Console.Write("|");
                    Console.Write(matrixArray1[i, j] + matrixArray2[i, j]);
                }
                Console.Write("|");
                Console.WriteLine();
            }



        }
    }
}
