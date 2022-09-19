using Xunit;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        {
            Assert.Equal(11, sum(6, 6));
        }

    }
    [Fact]
    public void Test2()
    {
        {
            Assert.Equal(12, sum(5, 6));
        }

    }

    int sum(int a, int b){
        return a+b;
    }
}