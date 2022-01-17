using NUnit.Framework;
using Program_1;

namespace Program_1Tests
{
    [TestFixture]
    [Author("Ivliev Maxim, developer. mxmIvlv@yandex.ru")]
    public class MyClassTests
    {
        private MyClass _myClass;

        [SetUp]
        public void SetUp()
        {
            _myClass = new MyClass();
        }


        [Test]
        public void Sum_5plus5_10returned()
        {
            //Arrange
            int a = 5;
            int b = 5;
            int expected = 10;

            //Act
            int actual = _myClass.Sum(a, b);

            //Assert
            Assert.AreEqual(expected, actual, "Test Sum failed");
        }

        [TestCase(5, 10, 5)]
        public void Subtraction_10minus5_5returned(int a, int b, int c)
        {
            Assert.AreEqual(a, _myClass.Subtraction(b, c), "Test Subtraction failed");
        }

        [TestCase(50, 2, ExpectedResult = 25)]
        public int Division_50div2_25returned(int a, int b)
        {
            return _myClass.Division(a, b);
        }

        [TestCaseSource(nameof(SourseTest))]
        public void Multiplication_50mult2_100returned(int a, int b, int c)
        {
            Assert.AreEqual(c, _myClass.Multiplication(a, b), "Test Multiplication failed");
        }

        static object[] SourseTest =
        {
            new object[] { 50, 2, 100 }
        };
    }
}