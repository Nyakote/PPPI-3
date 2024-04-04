using System.Reflection.Metadata.Ecma335;

namespace Advanced_test
{
    public class Calculator_Advanced
    {
        public double Pow(int a, int b) { int x = 1; for (int i = 0; i < b;) { x *= a; } return a; }
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
        public double NSK(int a, int b)
        {
            return (a * b) / NDS(a, b);
        }
    }
}
