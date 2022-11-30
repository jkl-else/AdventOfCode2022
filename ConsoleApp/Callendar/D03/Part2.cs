namespace ConsoleApp.Callendar.D03
{
    internal class Part2 : Part
    {
        public override async Task<string> GetResultAsync()
        {
            var input = await ReadFileAsync("Test");
            throw new NotFiniteNumberException();
        }
    }
}
