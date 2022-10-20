namespace LogicalProgramming
{
    public static class FibbonacciSeries
    {
        public static void CheckSeries()
        {
            Console.WriteLine("FibbonacciSeries");


            int a = 0;
            int b = 1;
            int c;

            Console.WriteLine(a);
            Console.WriteLine(b);

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                a = b;
                b = c;

                Console.WriteLine(c);

            }
        }
    }
}
