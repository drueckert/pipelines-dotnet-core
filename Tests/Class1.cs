using Xunit;

namespace tests
{
    public class Test1
    {
        [Fact]
        public void PassingTest()
        {
        //Given
            Assert.Equal(4, Add(2,2));
        //When
        
        //Then
        } 

        [Fact]
        public void FailingTest()
        {
        //Given
            Assert.Equal(5, Add(2,2));
        //When
        
        //Then
        }

        int Add(int x, int y)
        {
            return x+y;
        }
    }
}
