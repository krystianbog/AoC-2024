namespace AoC_2024.Days;

internal static class D1
{
    internal static void Execute()
    {
        Console.WriteLine("D1 init");

        string _inputFilePath = Path.Combine(AppContext.BaseDirectory, @"Inputs\InputD1.txt");
        const string _inputLineSeparator = "\n";

        var input = File.ReadAllText(_inputFilePath);
        var inputList = input.Split(_inputLineSeparator).Where(x => !string.IsNullOrEmpty(x)).ToList();
        
        List<int> leftList = new();
        List<int> rightList = new();
        
        foreach (var inputLine in inputList)
        {
            var inputValues = inputLine.Split("   ");

            leftList.Add(int.Parse(inputValues[0]));
            rightList.Add(int.Parse(inputValues[1]));
        }

        leftList.Sort();
        rightList.Sort();

        List<int> values = new();

        for (int i = 0; i < leftList.Count; i++)
        {
            values.Add(Math.Abs(leftList[i] - rightList[i]));
        }

        var res = values.Sum();

        Console.WriteLine($"D1 PT1: {res}");
    }
}
