namespace Tests
{
    using NUnit.Framework;

    [TestFixture]
    public class DummyTests
    {
        private const int HEALTH_FOR_DEAD_DUMMY = 0;
        private const int HEALTH_FOR_ALIVE_DUMMY = 11;
        private const int DUMMY_EXPERIENCE = 10;

        private Dummy GetDummy(int health, int experience)
        {
            return new Dummy(health, experience);
        }

        [TestCase(0)]
        [TestCase(3)]
        [TestCase(10)]
        [TestCase(7)]
        public void TestDummyLossesHealthIfIsAttacked(int attackPoints)
        {
            Dummy dummyTest = GetDummy(HEALTH_FOR_ALIVE_DUMMY, DUMMY_EXPERIENCE);
            dummyTest.TakeAttack(attackPoints);

            Assert.That(dummyTest.Health, Is.EqualTo(HEALTH_FOR_ALIVE_DUMMY - attackPoints));
        }


        [TestCase(11)]
        [TestCase(1)]
        [TestCase(0)]
        public void TestDummyThrowsExceptionIfIsDeadAndAttacked(int attackPoints)
        {
            Dummy dummyTest = GetDummy(HEALTH_FOR_DEAD_DUMMY, DUMMY_EXPERIENCE);

            Assert.That(() => dummyTest.TakeAttack(attackPoints), Throws.InvalidOperationException);
        }


        [TestCase(11)]
        [TestCase(1)]
        [TestCase(0)]
        public void TestDeadDummyCanGiveXP(int experience)
        {
            Dummy dummyTest = GetDummy(HEALTH_FOR_DEAD_DUMMY, experience);

            Assert.That(dummyTest.GiveExperience(), Is.EqualTo(experience));
        }


        [Test]
        public void TestAliveDummyCannotGiveXP()
        {
            Dummy dummyTest = GetDummy(HEALTH_FOR_ALIVE_DUMMY, DUMMY_EXPERIENCE);

            Assert.That(() => dummyTest.GiveExperience(), Throws.InvalidOperationException);
        }
    }
}
