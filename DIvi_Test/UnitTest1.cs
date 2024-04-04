using Calcultor_domain;
namespace DIvi_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator_Main();
            if(calc.Divi(2,2)!=1) { throw new Exception();  }

        }
    }
}