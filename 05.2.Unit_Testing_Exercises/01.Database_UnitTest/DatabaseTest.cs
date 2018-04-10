namespace _01.Database_UnitTest
{
    using System;
    using NUnit.Framework;
    using Moq;
    using System.Reflection;
    using System.Linq;
    using Database;

    [TestFixture]

    public class DatabaseTest
    {
        [TestCase(new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [TestCase(new int[] { })]
        public void TestValidConstructor(int[] values)
        {
            Database dbTest = new Database(values);
            FieldInfo field = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                              .First(fi => fi.FieldType == typeof(int[]));

            int[] getValues = ((int[])field.GetValue(dbTest))
                .Take(values.Length).ToArray();

            Assert.That(getValues, Is.EquivalentTo(values));
        }


        [Test]
        public void TestInvalidConstructor()
        {
            int[] values = new int[17];
            Assert.That(() => new Database(values), Throws.InvalidOperationException);
        }


        [TestCase(int.MinValue)]
        [TestCase(int.MaxValue)]
        [TestCase(-20)]
        [TestCase(0)]
        [TestCase(500)]
        public void TestAddMethodValid(int value)
        {
            Database dbTest = new Database();

            dbTest.Add(value);
            FieldInfo field = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                              .First(fi => fi.FieldType == typeof(int[]));
            FieldInfo index = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                              .First(fi => fi.FieldType == typeof(int));


            int getValue = ((int[])field.GetValue(dbTest)).First();
            Assert.That(getValue, Is.EqualTo(value));

            int count = (int)index.GetValue(dbTest);
            Assert.That(count, Is.EqualTo(1));
           
        }


        [Test]
        public void TestAddMethodInvalid()
        {
            Database dbTest = new Database();
            FieldInfo index = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                              .First(fi => fi.FieldType == typeof(int));
            index.SetValue(dbTest, 16);

            Assert.That(() => dbTest.Add(1), Throws.InvalidOperationException);
        }


        [TestCase(16)]
        [TestCase(5)]
        [TestCase(1)]
        public void TestRemoveMethodValid(int value)
        {
            int[] arrTest = new int[value];
            Database dbTest = new Database(arrTest);

            dbTest.Remove();

            FieldInfo index = typeof(Database).GetFields(BindingFlags.NonPublic | BindingFlags.Instance)
                                              .First(f => f.FieldType == typeof(int));

            int indexValue = (int)index.GetValue(dbTest);

            Assert.That(indexValue, Is.EqualTo(value - 1));
        }


        [Test]
        public void TestRemoveMethodInvalid()
        {
            Database dbTest = new Database();

            Assert.That(() => dbTest.Remove(), Throws.InvalidOperationException);
        }


        [TestCase(new int[] { 1, 2, 3, 4 })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        [TestCase(new int[] { })]
        public void TestFetchMethodValid(int[] values)
        {
            Database dbTest = new Database(values);

            Assert.That(dbTest.Fetch, Is.EquivalentTo(values));
        }
    }
}