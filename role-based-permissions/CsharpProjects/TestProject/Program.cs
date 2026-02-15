
Random random = new Random();
int level = random.Next(1, 56);
int role = random.Next(1, 3);
string permission = role == 1 ? "Admin" : "Manager";

Console.WriteLine($"Somebody with {permission} permissions and level {level} is trying to access the system.");

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}