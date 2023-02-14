// **** start main ****

int userchoice = GetUserChoice();
Gettriangleheight();
Drawtriangle(userchoice);

// **** end main ****


static int GetUserChoice() {
    DisplayMenu();
    string userChoice=Console.ReadLine();
    if(IsValidChoice(userChoice)){
        int.Parse(userChoice);
    }
    else return 0;
    return int.Parse(Console.ReadLine());
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

static void Gettriangleheight(){
    Random rand = new Random();
    int height = rand.Next(3,9);
    System.Console.WriteLine($"Your Triangle's Height is {height}!");
    
}

static void Drawtriangle(int userchoice, int height) {
    if (userchoice == 1) Drawnewtriangle(height);
    else
    if (userchoice == 2) Drawoldtriangle(height);
    else
    if (userchoice == 3) Wavebye(height);
}

Drawnewtriangle(height) {
    for(int i = 0; i = height; i++) {
        System.Console.WriteLine("* \n");
        for(int j = 1; j = i; j++) {
            System.Console.WriteLine("* \n");
        }
    }
}

Drawoldtriangle(height) {

}

Wavebye(height) {

}

