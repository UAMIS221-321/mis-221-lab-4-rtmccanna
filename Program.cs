// **** start main ****

int userchoice = GetUserChoice();
if (userchoice == 1) Drawnewtriangle(userchoice);
if (userchoice == 2) Drawoldtriangle(userchoice);

// **** end main ****


static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)){
        int.Parse(userChoice);
    }
    else return 0;
    return int.Parse(userChoice);
}

static void DisplayMenu() {
    System.Console.WriteLine("Enter 1 to draw new pyramid\nEnter 2 to draw old pyramid\nEnter 3 to Exit");
}

static bool IsValidChoice(string userInput) {
    if(userInput=="1" || userInput=="2" || userInput=="3") {
        return true;
    }
    return false;
}

static void Drawnewtriangle(int userchoice) {
    Random rand = new Random();
    int height = rand.Next(3,9);
    System.Console.WriteLine($"Your Triangle's Height is {height}!");
    for (int i = 0; i < height; i++){
        if (i <= height) System.Console.WriteLine("* ");
        for (int j = -1; j < i; j++){
            if (j >= height) System.Console.WriteLine("Enjoy your triangle!");
            else
            if (j < height)System.Console.Write("* ");
        }
    }
}

static void Drawoldtriangle(int userchoice) {
    Random rand = new Random();
    int height = rand.Next(3,9);
    System.Console.WriteLine($"Your Triangle's Height is {height}!");
    
}