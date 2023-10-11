Console.WriteLine("Hello friend, give me your password and I will tell you if it's any good!");
string password = Console.ReadLine();

if (LengthChecker(password) && UpperCaseChecker(password) && LowerCaseChecker(password) && NumberChecker(password))
{
    Console.WriteLine("Yey, your password is legit!");
}
else
{
    Console.WriteLine("try again :D");
    password = Console.ReadLine();
}


static Boolean LengthChecker(string a)
{
    if (a.Length < 8)
    {
        Console.WriteLine("Not funny, has to be more than 8 characters silly");
            return false;
    }
    else
        Console.WriteLine("Nice! You did type enough characters");
        return true;
}

//works until here
static Boolean UpperCaseChecker(string a)
{
  
    for (int i = 0; i < a.Length; i++)
    {
        if (char.IsUpper(a[i]))
        {
            Console.WriteLine("Yey you have capital letters");
            return true;
        }
        else
            Console.WriteLine("NO capital letters? NOt funny my guy");
        return false;
    }
    return true;
}

static Boolean LowerCaseChecker(string a)
{

    for (int i = 0; i < a.Length; i++)
    {
        if (char.IsLower(a[i]))
        {
            Console.WriteLine("Yey you have lowercase letters");
            return true;
        }
        else
            Console.WriteLine("NO lowercase letters? NOt funny my guy");
            return false;
    }
    return true;
}

static Boolean NumberChecker(string a)
{

    for (int i = 0; i < a.Length; i++)
    {
        if (char.IsNumber(a[i]))
        {
            Console.WriteLine("Yey you have numbers");
            return true;
        }
        else
            Console.WriteLine("NO numbers? NOt funny my guy");
        return false;
    }
    return true;
}

