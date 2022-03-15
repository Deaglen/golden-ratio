
using NUnit.Framework;
using WindowsFormsApp1;
namespace Test
{

    //  [TestFixture(1, 2, 0.01, 1, true, 123, 1)]
    //  [TestFixture(1, 3, 0.01, 1, true, 12, 12)]
    //  [TestFixture(-1, 2, 0.01, 1, true, 12, 2)]
    // [TestFixture(1.618)]
    public class Tests
    {
        private find_max_or_min_of_func testClass;
        /*
        public double a;
        public double b;
        public double eps;
        public int flag;
        public bool max;
        public double answerX;
        public double answerY;
        public Tests(double a, double b, double eps, int flag, bool max, double answerX, double answerY)
        {
            this.a = a;
            this.b = b;
            this.eps = eps;
            this.flag = flag;
            this.max = max;
            this.answerX = answerX;
            this.answerY = answerY;
        }
        */
        [SetUp]
        public void Setup() //не конструктор
        {
            testClass = new find_max_or_min_of_func();
        }

        [Test]
        public void Test1()
        {
            var result = testClass.do_calc(1, 2, 0.1, new GoldenRatio(), 1, true);
            Assert.True(result.Item1 != 123);
        }

        [Test]
        public void Test2()
        {
            var result = testClass.do_calc(1, 2, 0.1, new GoldenRatio(), 1, true);
            Assert.That(result.Item1 == 123);
        }

        [Test]
        public void Test3()
        {
            var result = testClass.do_calc(1, 2, 0.3, new GoldenRatio(), 1, true);
            Assert.That(result.Item1 == 123);
        }
        /*
        [Test]
        public void TestForGoldenRatio()
        {
            Assert.That(testClass.do_calc(a, b, eps, new GoldenRatio(), flag, max).Item1 == answerX);
        }

        [Test]
        public void TestForFibonacci()
        {
            Assert.That(testClass.do_calc(a, b, eps, new Fibonacci(), flag, max).Item1 == answerX);

        }
        */
        [TearDown]
        public void TearDown() // после завершения теста или ошибки теста
        {

        }
    }
}
