namespace Extended_Database
{
    public class Person
    {
        private string name;
        private long id;

        public Person(long id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public long ID
        {
            get { return this.id; }
            private set { this.id = value; }
        }
    }
}
