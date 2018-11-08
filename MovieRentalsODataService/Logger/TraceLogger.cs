using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace MovieRentalsODataService.Logger
{
    public class TraceLogger : ILogger
    {
        private readonly string categoryName;

        public TraceLogger(string categoryName) => this.categoryName = categoryName;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception, string> formatter)
        {
            if (this.categoryName == "Microsoft.EntityFrameworkCore.Query" && formatter(state, exception).StartsWith("Compiling query model"))
            {
                Debug.WriteLine(formatter(state, exception));
            }
        }

        public IDisposable BeginScope<TState>(TState state) => null;
    }
}
