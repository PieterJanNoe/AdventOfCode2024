var textFile = "C:\\Users\\a00579912\\Documents\\AdventOfCode2024\\Day1\\Day1\\input.txt";

List<int> firstRow = new List<int>();
List<int> secondRow = new List<int>();

using (StreamReader file = new StreamReader(textFile))
{
    string ln;

    while ((ln = file.ReadLine()) != null)
    {
        var parts = ln.Split("   ");
        firstRow.Add(int.Parse(parts[0]));
        secondRow.Add(int.Parse(parts[1]));
    }
    file.Close();
}

firstRow.Sort();
secondRow.Sort();

var totalDifference = 0;
for (int i = 0; i <= firstRow.Count-1; i++)
{
    totalDifference += Math.Abs(firstRow[i] - secondRow[i]);
}

Console.WriteLine("Difference: {0}",totalDifference);
Console.ReadLine();