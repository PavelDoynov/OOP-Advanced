using System;
using System.Linq;

namespace Extended_Database
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Database db = new Database();

            string cmd;
            while ((cmd = Console.ReadLine()) != "End")
            {
                if (cmd == "Fetch")
                {
                    var arr = db.Fetch();

                    Console.WriteLine("Count: {0}", arr.Length);
                    foreach (var item in arr)
                    {
                        Console.WriteLine($"{item.ID} {item.Name}");
                    }
                }
                else if (cmd == "Remove")
                {
                    db.Remove();
                }
                else if (cmd.Split(' ').Take(1).First() == "Add")
                {
                    try
                    {
                        long id = cmd.Split(' ').Skip(1).Take(1).Select(int.Parse).First();
                        string name = cmd.Split(' ').Skip(2).Take(1).First();

                        db.Add(new Person(id, name));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (cmd.Split(' ').Take(1).First() == "FindByName")
                {
                    string username = cmd.Split(' ').Skip(1).Take(1).First();
                    Person currentPerson = db.FindByUsername(username);
                    Console.WriteLine($"You found {currentPerson.Name} with id: {currentPerson.ID}");
                }
                else if (cmd.Split(' ').Take(1).First() == "FindByID")
                {
                    long usernameId = cmd.Split(' ').Skip(1).Take(1).Select(long.Parse).First();
                    Person currentPerson = db.FindById(usernameId);
                    Console.WriteLine($"You found {currentPerson.Name} with id: {currentPerson.ID}");
                }
            }
        }
    }
}
