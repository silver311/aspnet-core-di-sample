using DISample.Abstractions;

namespace DISample.Services
{
    public class SampleService : ISampleService
    {
        private readonly ISampleLog _sampleLog;

        public SampleService(ISampleLog sampleLog)
        {
            _sampleLog = sampleLog;
        }

        public void Start()
        {
            _sampleLog.Log("SampleService started");
        }
    }
}
