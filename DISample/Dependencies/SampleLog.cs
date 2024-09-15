using DISample.Abstractions;

namespace DISample.Dependencies
{
    public class SampleLog : ISampleLog
    {
        public void Log(string message)
        {
            Console.WriteLine($"[SAMPLE-LOG] Log message: {message}");
        }
    }
}
