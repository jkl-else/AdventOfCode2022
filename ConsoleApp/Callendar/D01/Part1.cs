﻿namespace ConsoleApp.Callendar.D01
{
    internal class Part1 : Part
    {
        public override async Task<string> GetResultAsync()
        {
            var input = await ReadFileAsync("Test");
            throw new NotFiniteNumberException();
        }
    }
}
