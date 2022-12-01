namespace ConsoleApp.Callendar.D01
{
    internal class Part2 : Part
    {
        public override async Task<string> GetResultAsync()
        {
            var input = await ReadFileAsync("Input");
            var kalories = new Dictionary<int, int> { [0] = 0 };
            int index = 0;
            foreach (var kal in input)
            {
                if (kal.Length == 0)
                {
                    index++;
                    kalories.Add(index, 0);
                    continue;
                }

                kalories[index] += int.Parse(kal);
            }

            return kalories
                .Values
                .OrderDescending()
                .Take(3)
                .Sum()
                .ToString();
        }
    }
}
