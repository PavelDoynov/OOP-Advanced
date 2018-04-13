namespace Extended_Database_UnitTest
{
    using System;
    using Extended_Database;
    using System.Reflection;
    using System.Linq;
    using NUnit.Framework;

    [TestFixture]
    public class Test
    {

        private Person GetPerson(long id, string name)
        {
            return new Person(id, name);
        }


        [TestCase(1, "First")]
        public void TestAddMethodValid(long id, string name)
        {
            Database dbTest = new Database();
            dbTest.Add(GetPerson(id, name));

            FieldInfo field = typeof(Database).GetFields(BindingFlags.Instance
                                                     | BindingFlags.NonPublic)
                                              .First(f => f.FieldType == typeof(int));

            int dbCount = (int)field.GetValue(dbTest);

            Assert.That(dbCount, Is.EqualTo(1));

        }


        [TestCase(1, "Second")]
        [TestCase(2, "First")]
        public void TestAddMethodInvalid(long id, string name)
        {
            Database dbTest = new Database(GetPerson(1, "First"));

            Assert.That(() => dbTest.Add(GetPerson(id, name)), Throws.InvalidOperationException);
        }


        [TestCase(1, "First", 2, "Second")]
        public void TestRemoveMethodValid(long id1, string name1, long id2, string name2)
        {
            Person[] peoples = new Person[] { GetPerson(id1, name1), GetPerson(id2, name2) };
            Database dbTest = new Database(peoples);

            dbTest.Remove();
            var list = dbTest.Fetch();

            Assert.That(list.Length, Is.EqualTo(1));
        }


        [TestCase("")]
        [TestCase("first")]
        [TestCase("Second")]
        public void TestFindByNameMethodInvalid(string name)
        {
            Database dbTest = new Database(GetPerson(1, "First"));

            if (string.IsNullOrWhiteSpace(name))
            {
                Assert.That(() => dbTest.FindByUsername(name), Throws.ArgumentNullException);
            }
            else
            {
                Assert.That(() => dbTest.FindByUsername(name), Throws.InvalidOperationException);
            }
        }


        [TestCase(-20)]
        [TestCase(21)]
        public void TestFindById (long id)
        {
            Database dbTest = new Database(GetPerson(1, "First"));

            if (id < 0)
            {
                Assert.Throws<ArgumentOutOfRangeException>(() => dbTest.FindById(id));
            }
            else
            {
                Assert.That(() => dbTest.FindById(id), Throws.InvalidOperationException);
            }
        }
    }
}
