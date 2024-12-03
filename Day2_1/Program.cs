var textFile = "C:\\Users\\a00579912\\Documents\\AdventOfCode2024\\Day1\\Day2_1\\input.txt";

List<string> rows = new List<string>();


// Read the file
using (StreamReader file = new StreamReader(textFile))
{
    string ln;

    while ((ln = file.ReadLine()) != null)
    {
        rows.Add(ln);
    }
    file.Close();
}

int countSafeRows = 0;
foreach (var row in rows)
{
    List<int> rowInNumbers = row?.Split(" ")?.Select(Int32.Parse)?.ToList();
    if (IsValidReport(rowInNumbers)) countSafeRows++;
}

Console.WriteLine("Amount of safe rows: {0}", countSafeRows);
Console.ReadLine();

bool IsValidReport(List<int> row)
{
    // We don't care about the numbers, just wether going up or down, not both
    var isIncreasing = IsIncreasing(row);
    var isDecreasing = IsDecreasing(row);

    if (!isIncreasing && !isDecreasing) return false;

    for (var i = 0; i < row.Count - 1; i++)
    {
        var difference = Math.Abs(row[i + 1] - row[i]);
        if (difference < 1 || difference > 3)
        {
            return false;
        }
    }

    return true;
}
bool IsIncreasing(List<int> numbers)
{
    for (var i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] < numbers[i - 1]) return false;
    }

    return true;
}

bool IsDecreasing(List<int> numbers)
{
    for (var i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] > numbers[i - 1]) return false;
    }

    return true;
}
