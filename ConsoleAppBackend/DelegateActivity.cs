namespace ConsoleAppBackend
{
    delegate int MathOperation(int a, int b);


    class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Substract(int a, int b)
        {
            return (a - b);
        }

        static int MultiCastAdd(int a, int b)
        {
            int result = a + b;
            Console.WriteLine(result);
            return result;
        }

        static int MultiCastSubstract(int a, int b)
        {
            int result = a - b;
            Console.WriteLine(result);
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Simple Delegates: ");
            MathOperation operation = new MathOperation(Add);
            int addResult = operation(10, 3);
            Console.WriteLine(addResult);

            operation = new MathOperation(Substract);
            int substractResult = operation(10, 3);
            Console.WriteLine(substractResult);
            Console.WriteLine();

            Console.WriteLine("Multicast Delegates:");

            MathOperation mathOperation = null;

            mathOperation += MultiCastAdd;
            mathOperation += MultiCastSubstract;

            int bothResult = mathOperation(10, 3);
            Console.WriteLine(bothResult);
        }
    }

}