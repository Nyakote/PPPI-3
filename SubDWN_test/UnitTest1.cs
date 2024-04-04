using Calcultor_domain;
namespace SubDWN_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator_Main();
            if (calc.SubDWN(2, 2) != 0) { throw new Exception(); }
        }
    }
}