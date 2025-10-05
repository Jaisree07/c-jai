using System;
using System.Collections.Generic;
using System.Linq;
class User
{
    public int Id { get; set; }
    public string Name { get; set; }
}
class UserRepository
{
    private List<User> users = new List<User>();
    public void Add(User user) => users.Add(user);
    public void Remove(User user) => users.Remove(user);
    public User GetById(int id) => users.FirstOrDefault(u => u.Id == id);
    public List<User> GetAll() => users;
}
//Unit of Work - maintains multipl repository
class UnitOfWork
{
    public UserRepository Users { get; } = new UserRepository();
    public void Commit()
    {
        Console.WriteLine("All changes saved to database!");
    }
}
class Program
{
    static void Main()
    {
        UnitOfWork uow = new UnitOfWork();
        uow.Users.Add(new User { Id = 1, Name = "Jai" });
        uow.Users.Add(new User { Id = 2, Name = "sree" });
        uow.Commit(); // Save changes
        // Show all users
        foreach (var user in uow.Users.GetAll())
        Console.WriteLine($"Id:{user.Id},Name:{user.Name}");
        // Remove a user
        var removeUser = uow.Users.GetById(1);
        uow.Users.Remove(removeUser);
        uow.Commit();
        Console.WriteLine("After removal:");
        foreach (var user in uow.Users.GetAll())
        Console.WriteLine($"Id:{user.Id},Name:{user.Name}");
    }
}
