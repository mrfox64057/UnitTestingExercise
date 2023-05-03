using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        [InlineData(1, 1, 1, 3)] //Add test data <-------
        [InlineData(4, 4, 4, 12)] //Add test data <-------
        [InlineData(44, 44, 44, 132)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:

            //Arrange
            // create a Calculator object
            var calculater = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
                var actual = calculater.Add(num1, num2, num3);

            //Assert
                Assert.Equal(expected, actual);             
        }

        [Theory]
        [InlineData(8, 4, 4)]//Add test data <-------
        [InlineData(4, 2, 2)]//Add test data <-------
        [InlineData(14, 7, 7)]//Add test data <-------
        [InlineData(44, 40, 4)]//Add test data <-------
        public void SubtractTest(int num1, int num2, int expected)
        {
            //Start Step 5 here:

            //Arrange
            var calculater = new Calculator();

            //Act
            var actual = calculater.Sub(num1, num2 );
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(6, 3, 18)]//Add test data <-------
        [InlineData(7, 5, 35)]//Add test data <-------
        [InlineData(9, 6, 54)]//Add test data <-------
        [InlineData(5, 5, 25)]//Add test data <-------

        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            var calculater = new Calculator();
            //Act
            var actual = calculater.Multi(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(56, 8, 7)]//Add test data <-------
        [InlineData(88, 8, 11)]//Add test data <-------
        [InlineData(44, 4, 11)]//Add test data <-------
        [InlineData(14, 2, 7)]//Add test data <-------
        public void DivideTest(int num1, int num2, int expected)
        {
            //Arrange
            var calculater = new Calculator();
            //Act
            var actual = calculater.Divi(num1, num2);
            //Assert
            Assert.Equal(expected, actual);
        }

    }
}
