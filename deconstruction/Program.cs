//GET PLAYER NAME & REMEMBER
Console.WriteLine("What is your name?");
string playerName = Console.ReadLine();
int swordCost = 20;

//TELL PLAYER ABOUT BRONZE SWORD
Console.WriteLine($"You can purchase our bronze sword for {swordCost} gold.");

//ASK PLAYER FOR SUM OF HELD GOLD
Console.WriteLine("How much gold do you have with you?");
Console.WriteLine("Enter number:");
int playerGold = int.Parse(Console.ReadLine());

//BUY ITEM IF ABLE, DEDUCT COST FROM GOLD
if (playerGold >= swordCost)
{
    playerGold -= swordCost;
    Console.WriteLine($"Remaining gold: {playerGold}");
}

else
{
    Console.WriteLine("You have an insufficient amount of gold!");
}