namespace ArraysList
{
    class Program
    {
        public static void Main(string[] args)
        {
            // 1-dim array
            Console.WriteLine("array list");
            var ar = new int[] {1,2,3,4, 3, 2, 1};
            var program = new Program();
            program.print(ar);
            Console.WriteLine();

            var ar1 = new int[2] {1,2};
            program.print(ar1);
            Console.WriteLine();

            int[] ar2 = new int[2];
            program.print(ar2);

            Console.WriteLine($"index of 5: {Array.IndexOf(ar, 5)}");
            Console.WriteLine($"index of 4: {Array.IndexOf(ar, 4)}");
            Array.Clear(ar, 0, 2);
            Console.WriteLine("after clear");
            program.print(ar);
            Array.Sort(ar);
            Console.WriteLine("after sort");
            program.print(ar);
            Array.Reverse(ar);
            Console.WriteLine("after reverse");
            program.print(ar);

            var ar3 = new int[2];
            Array.Copy(ar, ar3, 2);
            Console.WriteLine("after copy");
            program.print(ar3);

            Console.WriteLine("---- 2d array ----");
            var twoDimAr = new int[2, 2];
            program.print2D(twoDimAr);
            int[,] twoDimAr2 = new int[2,4] { { 1, 2, 3, 4 }, { 1, 2, 3, 4 } };
            program.print2D(twoDimAr2);
            int[,] twoDimAr3 = new int[,] { { 1, 2}, { 3,4 } };
            program.print2D(twoDimAr3);
            program.print2DVariant(twoDimAr3);
            Console.WriteLine();

            Console.WriteLine("---- jaggered array ----");
            int[][] jarr1 = new int[2][];
            jarr1[0] = new int[] { 1, 2, 3, 4 };
            jarr1[1] = new int[] {1, 2, 3,4,5 };
            program.printJaggeredArray(jarr1);
            program.printJaggeredArrayVariant(jarr1);

            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9 },
                new int[] { 0, 2, 4, 6 },
                new int[] { 11, 22 }
            };
            program.printJaggeredArray(jaggedArray2);
        }

        public void print(int[] ar)
        {
            foreach (var item in ar)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public void print2D(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
            {
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    Console.Write($"{ar[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void print2DVariant(int[,] ar)
        {
            foreach (var item in ar)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

        public void printJaggeredArray(int [][] ar)
        {
            foreach(var item in ar)
            {
                foreach(int j in item)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void printJaggeredArrayVariant(int[][] ar)
        {
            for (int i = 0; i < ar.Length; i++)
            {
                for (int j = 0; j < ar[i].Length; j++)
                {
                    Console.Write($"{ar[i][j]} ");
                }
            }
            Console.WriteLine();
        }

    }
}