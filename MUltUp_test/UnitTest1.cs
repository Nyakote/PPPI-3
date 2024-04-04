using Calcultor_domain;
namespace MUltUp_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator_Main();
            if (calc.MultUP(2, 2) != 4) { throw new Exception(); }
        }
    }
}