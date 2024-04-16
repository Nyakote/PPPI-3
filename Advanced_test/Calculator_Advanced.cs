using System.Reflection.Metadata.Ecma335;

namespace Advanced_test
{
    public class Calculator_Advanced
    {
        public double Pow(int a, int b) { for (int i = 0; i < b;) { a *= i; } return a; }
        public double NDS(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

    }
}
