var inputFromFile = File.ReadAllText("input.txt");
var input = inputFromFile.TrimEnd('\n');

var inputSplit = input.Split('\n');
string[] winPairings  = new [] { "C X", "A Y", "B Z" };
string[] drawPairings = new [] { "A X", "B Y", "C Z" };
string[] lossPairings = new [] { "B X", "C Y", "A Z" };

int score = 0;

void Part1()
{
    foreach (var pairing in inputSplit)
    {
        if(winPairings.Contains(pairing)) score += (6 + Array.IndexOf(winPairings, pairing) + 1);
        if(drawPairings.Contains(pairing)) score += (3 + Array.IndexOf(drawPairings, pairing) + 1);
        if(lossPairings.Contains(pairing)) score += (Array.IndexOf(lossPairings, pairing) + 1);
    }
}

void Part2()
{
    foreach(var pairing in inputSplit)
    {
        switch(pairing[2])
        {
            case 'X': //Lose
                score += (Array.IndexOf(lossPairings, lossPairings.Single(x => x[0] == pairing[0])) + 1);
                break;
            case 'Y': //Draw
                score += (3 + Array.IndexOf(drawPairings, drawPairings.Single(x => x[0] == pairing[0])) + 1);
                break;
            case 'Z': //Win
                score += (6 + Array.IndexOf(winPairings, winPairings.Single(x => x[0] == pairing[0])) + 1);
                break;
        }
    }
}

Part1();
Console.WriteLine(score);
score = 0;
Part2();
Console.WriteLine(score);
