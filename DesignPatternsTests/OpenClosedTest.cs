using DesignPatterns.OpenClosedPrinciple;

namespace DesignPatternsTests
{
    public class OpenClosedTest
    {
        private IEnumerable<Product> _products;

        [SetUp]
        public void InitialiseProducts()
        {
            _products = new List<Product> {
            new Product("Apple", Color.Red, Size.Medium),
            new Product("Orange", Color.Magenta, Size.Small),
            new Product("Blueberry", Color.Blue, Size.Medium)
        };
        }

        [Test(Description = "Violating Open/Closed Principle")]
        public void Test_Violating_FilterProductsByColor_ShouldSucceed()
        {
            var sut = new OpenClosedViolated(_products, new ProductFilter());
            var result = sut.FilterProductsByColor(Color.Red);
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result.SingleOrDefault().Color, Is.EqualTo(Color.Red));
        }

        [Test(Description = "Violating Open/Closed Principle")]
        public void Test_Violating_FilterProcutsBySize_ShouldSucceed()
        {
            var sut = new OpenClosedViolated(_products, new ProductFilter());
            var result = sut.FilterProductsBySize(Size.Small);
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test(Description = "Respecting Open/Closed Principle")]
        public void Test_Respecting_FilterProductsByColor_ShouldSucceed()
        {
            var sut = new OpenClosedRespected();
            var result = sut.Filter(_products, new ColorSpecification(Color.Red));
            Assert.That(result.Count(), Is.EqualTo(1));
            Assert.That(result.SingleOrDefault().Color, Is.EqualTo(Color.Red));
        }

        [Test(Description = "Respecting Open/Closed Principle")]
        public void Test_Respecting_FilterProcutsBySize_ShouldSucceed()
        {
            var sut = new OpenClosedRespected();
            var result = sut.Filter(_products, new SizeSpecification(Size.Medium));
            Assert.That(result.Count(), Is.EqualTo(2));
        }
    }
}
