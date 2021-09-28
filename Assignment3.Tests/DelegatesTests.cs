using System;
using Xunit;
using System.Linq;
using System.IO;

namespace Assignment3.Tests
{
    public class DelegatesTests
    {
        // 1
        private Action<string> reverseOrder;
        
        [Fact]
        public void Print_Reverse_Order()
        {
            // Arrange
            var writer = new StringWriter();
            Console.SetOut(writer);
            
            var input = "Foobar";
            var expected = "rabooF";
            
            reverseOrder = s => Console.WriteLine(s.Reverse().ToArray());
            
            // Act
            reverseOrder(input);
            var actual = writer.GetStringBuilder().ToString().Trim();
			
            // Assert
            Assert.Equal(expected, actual);
        }

        // 2
        private Func<float, float, float> getProduct;
        
        [Fact]
        public void Return_Product_Of_Two_Input()
        {
            // Arrange
            getProduct = (i, j) => i * j;

            float a = 1.5f, b = 2.2f;
            float expected = a * b;
            
            // Act
            float actual = getProduct(a,b);
            
            // Assert
            Assert.Equal(expected, actual);
        }
        
        
        private Func<int, string, bool> isEqual;
        [Fact]
        public void Given_Whole_Num_And_String_Return_If_They_Are_Same_Num()
        {
            // Arrange
            isEqual = (i, s) => i == int.Parse(s); 

            int i = 42;
            string s = "0042";
            
            // Act
            bool actual = isEqual(i, s);
            bool expected = true;
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
