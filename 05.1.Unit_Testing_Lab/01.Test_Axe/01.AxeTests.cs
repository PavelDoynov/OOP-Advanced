namespace Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class AxeTests
    {
        private const int AXE_ATTACK = 10;

        [TestCase(AXE_ATTACK, 10)]
        [TestCase(AXE_ATTACK, 5)]
        [TestCase(AXE_ATTACK, 1)]
        public void TestAxeLosesDurabilityAfterAttack(int attack, int durability)
        {
            Axe currentAxe = new Axe(attack, durability);
            currentAxe.Attack(new Dummy(10, 10));

            Assert.That(currentAxe.DurabilityPoints, Is.EqualTo(durability - 1));
        }
    }
}
