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
        protected Task<string[]> ReadFileAsync(string fileName)
        {
            var filePath = Path.Combine(String.Join("\\", GetType().Namespace!.Split('.').Skip(1)), $"{fileName}.txt");
            var rootPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\..\\", filePath);
            return File.ReadAllLinesAsync(rootPath);
        }
    }
}
