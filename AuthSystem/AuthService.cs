using System;
using System.Collections.Generic;

public class AuthService
{
    private List<User> users = new List<User>();

    public void SignUp(string username, string password)
    {
        if (users.Exists(u => u.Username == username))
        {
            Console.WriteLine("Username already exists!");
            return;
        }

        users.Add(new User { Username = username, Password = password });
        Console.WriteLine("Sign-up successful!");
    }

    public void SignIn(string username, string password)
    {
        User user = users.Find(u => u.Username == username && u.Password == password);
        
        if (user != null)
            Console.WriteLine("Sign-in successful!");
        else
            Console.WriteLine("Invalid username or password.");
    }
}
