using Co

namespace hw9

{
    
    delegate void Calculator(int num1, int num2);
    

    delegate void CheckNumber(int num);

    delegate void Check(List<T> abc);
    class Program
    {
        
        static int number = 0;

        public static void AddNumber(int a, int b)
        {
            number = a + b;
            Console.WriteLine("AddNum value: {0}", number);
        }

        public static void CheckPrimeNumber(int num)
        {
            bool isPrime = true;
            if (num < 2)
            {
                isPrime = false;
            }

            for (int i = 2; i < num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write($"{num} la so nguyen to.");
            }
            else
            {
                Console.Write($"{num} khong phai so nguyen to.");
            }
        }
        public static void Main(string[] args)
        {

            Calculator ab = delegate (int x, int y)
            {
                Console.WriteLine("Delegate: x={0},y={1}", x, y);
            };

            ab(20, 10);

            CheckNumber cn = delegate (int n)
            {
                Console.WriteLine("Prime Number ?: n={0}}", n);
            };

            /*cn(2);*/
            cn = new CheckNumber(CheckPrimeNumber);
            cn(8);


        }
    }
}