Console.WriteLine("===Welcome To Vault-X====");
Console.WriteLine();

Console.WriteLine("Please enter your name: ");
string name = Console.ReadLine();
Console.WriteLine();

Console.WriteLine("Create a master password");
string masterPassword = Console.ReadLine();

    Console.WriteLine();
Console.WriteLine("Wellcome, " + name + "! Your vault is now ready.");
Console.WriteLine("Remember your master password to access your saved data.");
    Console.WriteLine();

//now we asking the user to re enter the master password to access the vault
int attempts = 0;
bool isAuthenticated = false;

while (attempts < 3)
{
    Console.Write(" Re-enter your master password to continue: ");
    string enteredPassword = Console.ReadLine();

    if (enteredPassword == masterPassword)
    {
        isAuthenticated = true;
        Console.WriteLine(" Access granted!\n");
        break;
    }
    else
    {
        attempts++;
        Console.WriteLine($" Wrong password. Attempts left: {3 - attempts}\n");
    }
}

if (!isAuthenticated)
{
    Console.WriteLine(" Too many failed attempts. Try again later.");
    Environment.Exit(0);
}

//Now we creating a Vault Menu
Console.WriteLine("Welcome to VAULT-X 🔐");
    Console.WriteLine("Vault Menu : ");
    Console.WriteLine("1. Add new Credentials");
    Console.WriteLine("2. View stored Credentials");
Console.WriteLine("3. Exit");
Console.Write("Your choice: ");

//Now we working with every option on the menu
int choice = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

string website = "";
string userName = "";
string password = "";
bool credentialsEntered = false;

if (choice == 1)
{
    Console.WriteLine("Please enter Website/app name: ");
    website = Console.ReadLine();

    Console.WriteLine("Please enter username/email: ");
    userName = Console.ReadLine();

    Console.WriteLine("Please enter password");
    password = Console.ReadLine();

    Console.WriteLine();
    Console.WriteLine("Credentials added successfully!");
    credentialsEntered = true;
}
else if (choice == 2)
{

    if (credentialsEntered) { 
        Console.WriteLine("🔐 Stored Credentials:");
    Console.WriteLine("Website: " + website);
    Console.WriteLine("Username: " + userName);
    Console.WriteLine("Password: " + password); // You can mask it if you want
}
else
{
    Console.WriteLine("⚠️ No credentials stored yet. Please add some first.");
}
}

else if (choice == 3)
    {
        Console.WriteLine("Exiting the Vault. Thank you for using Vault-X!");
    }
    else
    {
        Console.WriteLine("Invalid choice! Please try again.");
    }