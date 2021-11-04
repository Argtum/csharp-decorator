using decorator.Beverage;
using decorator.Beverage.Tea;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [Test]
        public void TeaTest()
        {
            Beverage tea = new Tea("Чай");
            Assert.AreEqual(tea.GetDescription(), "Чай");
            Beverage fruitTea = new Tea("Фруктовый чай");
            Assert.AreNotEqual(fruitTea.GetDescription(), "Чай");
        }
    }
}