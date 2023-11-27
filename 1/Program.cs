string inputFromFile = File.ReadAllText("input.txt");
string input = inputFromFile.TrimEnd('\n');

List<string> inputSplit = input.Split("\n\n").ToList();
int[] totals = new int[inputSplit.Count];

foreach (string group in inputSplit)
{
    foreach (string number in group.Split('\n'))
    {
        totals[inputSplit.IndexOf(group)] += Int32.Parse(number);
    }
}

IEnumerable<int> totalsFiltered = totals.OrderByDescending(x => x).Take(3);

Console.WriteLine(totalsFiltered.First());
Console.WriteLine(totalsFiltered.Sum());
