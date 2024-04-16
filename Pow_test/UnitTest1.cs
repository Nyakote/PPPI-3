using Advanced_test;
namespace Pow_test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator_Advanced();
            if (calc.Pow(2,2)!=4) { throw new Exception(); }
            //adding something to commit



        }
    }
}