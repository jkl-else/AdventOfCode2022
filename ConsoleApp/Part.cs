namespace ConsoleApp
{
    internal abstract class Part
    {
        public abstract Task<string> GetResultAsync();
        /// <summary>
        /// Read lies from txt dokument
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        protected Task<string[]> ReadFileLinesAsync(string fileName) => File.ReadAllLinesAsync(GetPath(fileName));

        protected Task<string> ReadFileTextAsync(string fileName) => File.ReadAllTextAsync(GetPath(fileName));

        private string GetPath(string fileName)
        {
            var filePath = Path.Combine(String.Join("\\", GetType().Namespace!.Split('.').Skip(1)), $"{fileName}.txt");
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", filePath);
        }
    }
}
