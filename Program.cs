
namespace matrix
{
	internal class Program
	{
		static void Main(string[] args)
		{

			int[,] matrix = new int[,] { { 1, 2, 3,4 }, { 4, 5, 6,4 }, { 7, 8, 9,4 } };
            int[,] secondmatrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6}, { 7, 8, 9} };

            //Transp(matrix);

            //Summ(matrix);

            Multiply(matrix, secondmatrix);

			//int numb = 2;
			//MultiplyOnNumb(matrix, numb);
			//SaveInToFile(matrix);
            //ReadFromFile();
		}
		public static void Transp(int[,] matrix)
		{
            Console.WriteLine("Transpose");

            Console.WriteLine("Old Matrix:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}

			int[,] temp = new int[3, 3];
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					temp[i, j] = matrix[j, i];
				}
			}
			Console.WriteLine();
			Console.WriteLine("Matrix After Transp:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(temp[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

		public static void Summ(int[,] matrix)
		{
            Console.WriteLine("Summ");

            int[,] secondMatrix = new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
			int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];


			Console.WriteLine("First Matrix:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					temp[i, j] = matrix[i, j] + secondMatrix[i, j];
				}
			}


			Console.WriteLine();
			Console.WriteLine("Second Matrix:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(secondMatrix[i, j] + " ");
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine("Matrix After Summ:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(temp[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}

        public static void Multiply(int[,] matrix, int[,] secondMatrix)
        {

            int[,] Mass = new int[secondMatrix.GetLength(0), secondMatrix.GetLength(1)];//[1, 7]; // массив для записи результата проецирования
            int sum = 0;

            Console.WriteLine("Multiply");


            for (int i = 0; i < matrix.GetLength(0); i++)  // умножение
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    for (int r = 0; r < secondMatrix.GetLength(0); r++)
                    {
                        sum = sum + matrix[i, r] * secondMatrix[r, j];
                    }
                    Mass[i, j] = sum;
                    sum = 0;
                }
            }


            for (int i = 0; i < Mass.GetLength(0); i++)
            {
                for (int j = 0; j < Mass.GetLength(1); j++)
                {
                    Console.Write(Mass[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }


        public static void MultiplyOnNumb(int[,] matrix, int number)
		{
            Console.WriteLine("Multiplyonnumb");

            int[,] secondMatrix = new int[,] { { 9, 8, 7 }, { 6, 5, 4 }, { 3, 2, 1 } };
			int[,] temp = new int[matrix.GetLength(0), matrix.GetLength(1)];

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					temp[i, j] = matrix[i, j] * number;
				}
			}



			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(temp[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
		public static void SaveInToFile(int[,] matrix)
		{
			string outputpath = "output.txt";

			using (var writer = new StreamWriter(outputpath))
			{
				for (int i = 0; i < matrix.GetLength(0); i++)
				{
					for (int j = 0; j < matrix.GetLength(1); j++)
					{
						writer.Write(matrix[i, j].ToString() + " ");
					}
					writer.WriteLine();
				}
			}
		}

		public static void ReadFromFile()
		{
            Console.WriteLine("ReadFromFile");

            string outputpath = "output.txt";

			string[,] matrix = new string[3, 3];

			for (int i = 0; i < 3; i++)
			{
				string[] firstLine = File.ReadAllLines(outputpath);
				for (int j = 0; j < 1; j++)
				{
					matrix[i,j] = firstLine[i];
				}
			}

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}


	}
}