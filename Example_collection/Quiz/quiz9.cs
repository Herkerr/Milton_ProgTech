// 1, Olvassunk kódot!
// 2, Ismerjük fel milyen tervezési mintát láthatunk a kódban?

using System;

public interface IUserLogin
{
    void LoginAdminUser(AdminUser user);
    void LoginRegularUser(RegularUser user);
}

public abstract class User
{
    public abstract void Accept(IUserLogin login);
}

public class AdminUser : User
{
    public override void Accept(IUserLogin login)
    {
        login.VisitAdminUser(this);
    }
}

public class RegularUser : User
{
    public override void Accept(IUserLogin login)
    {
        login.VisitRegularUser(this);
    }
}

public class UserTypeAction : IUserLogin
{
    public void VisitAdminUser(AdminUser user)
    {
        Console.WriteLine("Admin user action: Grant access to admin features");
    }

    public void VisitRegularUser(RegularUser user)
    {
        Console.WriteLine("Regular user action: Display regular user features");
    }
}

class Program
{
    static void Main(string[] args)
    {
        User adminUser = new AdminUser();
        User regularUser = new RegularUser();

        UserTypeAction userTypeAction = new UserTypeAction();
        adminUser.Accept(userTypeAction);
        regularUser.Accept(userTypeAction);
    }
}