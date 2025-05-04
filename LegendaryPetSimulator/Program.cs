
using LegendaryPetSimulator;

var simulationCount = 100000;

var result = new List<int>();

for (var count = 0; count < simulationCount; count++)
{
    var inventory = new Inventory();
    var pickedCount = 0;

    while (!inventory.HasLegendary())
    {
        pickedCount += 10;
        for (var i = 0; i < 10; i++)
        {
            var picked = LuckyBox.Pick();
            inventory.Add(picked);
        }
        inventory.RarityUp();
    }

    result.Add(pickedCount);
}

result.Sort();

Console.WriteLine($"전설펫 최소 연차수: {result[0]}");
Console.WriteLine($"전설펫 최대 연차수: {result[result.Count - 1]}");

Console.WriteLine($"전설펫 평균 연차수: {result.Average()}");
Console.WriteLine($"전설펫 중간값 연차수: {result[(int)(result.Count / 2f)]}");
Console.WriteLine($"전설펫 최빈값 연차수: {result.GroupBy(v => v).OrderByDescending(g => g.Count()).First().Key}");

