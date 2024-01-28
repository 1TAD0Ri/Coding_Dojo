//Coin Flip








string flipResult = CoinFlip();
Console.WriteLine("The coin landed on: " + flipResult);


static string CoinFlip()
{
    // Generate a random number (0 or 1) to represent heads or tails
    Random random = new Random();
    int result = random.Next(2);

    // Map the random number to "heads" or "tails"
    if (result == 0)
    {
        return "heads";
    }
    else
    {
        return "tails";
    }
}

// ------------------------------



int dicerolll = DiceRoll();
Console.WriteLine(dicerolll);


static int DiceRoll()
{
    // Generate a random number (0 or 1) to represent heads or tails
    Random random = new Random();
    int result = random.Next(6);


    // Map the random number to "heads" or "tails"


    return result + 1;

}

// ------------------------------

static void StatRoll()
{
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine(RollDice());
    }
}

static int RollDice()
{
    Random random = new Random();
    return random.Next(1, 7);
}

StatRoll();


// ------------------------------

static void RollUnit()
{
    int targetNumber = 3;
    string rollResult = RollUntil(targetNumber);
    Console.WriteLine(rollResult);
}
static string RollUntil(int targetNumber)
{
    Random random = new Random();
    int count = 0;
    int result;

    do
    {
        result = random.Next(1, 7);
        count++;
    } while (result != targetNumber);

    return $"Rolled a {targetNumber} after {count} tries";
}

RollUnit();


//     while (result != targetNumber)
//     {
//         result = random.Next(1, 7);
//         count++;
//     }

//     return $"Rolled a {targetNumber} after {count} tries";
// }


















































































































