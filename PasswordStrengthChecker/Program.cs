
string password;
Boolean something;
do
{
    {
        something = true;
        Console.WriteLine("Hello friend, give me a password and I will tell you if it's any good!");
        password = Console.ReadLine();

        if (!LengthChecker(password))
        {
            something = false;
            Console.WriteLine("Not long enough, has to be 8 character silly");
        }
        if (!UpperCaseChecker(password))
        {
            something = false;
            Console.WriteLine("No capital letters? Not funny");
        }
        if (!LowerCaseChecker(password))
        {
            something = false;
            Console.WriteLine("No lowercase letters? Not funny");
        }
        if (!NumberChecker(password))
        {
            something = false;
            Console.WriteLine("No numbers? Not funny");
        }
        if (!SpecialChecker(password))
        {
            something = false;
            Console.WriteLine("Repeating special characters or no special characters? Didn't laugh");
        }
        Console.WriteLine();

    }

}
while (!something);
Console.WriteLine("Good job, you finally got it :D!");


static Boolean LengthChecker(string a)
{
    if (a.Length < 8)
    {
            return false;
    }
    else
        Console.WriteLine();
    return true;

}

//works until here
static Boolean UpperCaseChecker(string a)
{
  
    foreach (char letter in a)
    {
        if (char.IsUpper(letter))
        {
            return true;
        }
    }
    
    Console.WriteLine();
    return false;
    
}

static Boolean LowerCaseChecker(string a)
{

    foreach (char letter in a)
    {
        if (char.IsLower(letter))
        {
            return true;
        }
    }
    Console.WriteLine();
    return false;
}

static Boolean NumberChecker(string a)
{

    foreach (char number in a)
    {
        if (char.IsDigit(number))
        {
            return true;
        }
    }
    Console.WriteLine();

    return false;
}

static Boolean SpecialChecker(string a)
{
    char previous = 'a';
    Boolean specialIs = false;
    foreach (char special in a)
    {
        if (!Char.IsLetterOrDigit(special))
        {
            specialIs = true;
            if (previous == special)
            {
                return false;
            }
        }
        previous = special;
    }
        return specialIs;
}
    }
    return true;
}

