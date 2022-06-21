
namespace Calculator
{
    class Program
    {
        public double Remainder(double x, double y)
        {
            return  x % y;
        }
        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }
        public double Percentage(double x, double y)
        {
            return (x / y) * 100;
        }
        public double Multiply(double x, double y)
        {
            return  x * y;
        }
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("Please select the action:\n1.Remainder \n2.Power \n3.Percentage \n4.Multiply");
            int action = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number:");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double y = Convert.ToDouble(Console.ReadLine());
            Program obj = new Program();
            double result = 0;
            switch (action)
            {
                case 1:
                    result = obj.Remainder(x, y);
                    Console.WriteLine("The result is " + result);
                    break;

                case 2:
                    result = obj.Power(x, y);
                    Console.WriteLine("The result is " + result);
                    break;

                case 3:
                    result = obj.Percentage(x, y);
                    Console.WriteLine("The result is " + result);
                    break;

                case 4:
                    result = obj.Multiply(x, y);
                    Console.WriteLine("The result is " + result);
                    break;
            }
            goto start;
        }
    }
}
