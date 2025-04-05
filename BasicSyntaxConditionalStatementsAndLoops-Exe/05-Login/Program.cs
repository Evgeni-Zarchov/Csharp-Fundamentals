string username = Console.ReadLine();
string password = "";
int attempts = 0;

for (int i = username.Length - 1; i >= 0; i--)
{
    password += username[i];
}

while (true)
{
    string currentPassword = Console.ReadLine();


    if (currentPassword != password)
    {
        attempts++;

        if (attempts > 3)
        {
            Console.WriteLine($"User {username} blocked!");
            break;
        }
        else
        {
            Console.WriteLine("Incorrect password. Try again.");
            continue;
        }


    }
    else
    {
        Console.WriteLine($"User {username} logged in.");
        break;
    }

}


