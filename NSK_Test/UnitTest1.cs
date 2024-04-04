using Advanced_test;
namespace NSK_Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var calc = new Calculator_Advanced();
            if(calc.NSK(2,2)!=2) { throw new Exception(); }
        }
    }
}