﻿namespace ConsoleApp.Callendar.D08
{
    internal class Part2 : Part
    {
        public override async Task<string> GetResultAsync()
        {
            var input = await ReadFileLinesAsync("Test");
            throw new NotFiniteNumberException();
        }
    }
}
