using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    /// <summary>
    /// Singleton
    /// </summary>
    public class Logger
    {
        //private static Logger? _instance;

        private static readonly Lazy<Logger> _lazyLogger 
            = new Lazy<Logger>(() => new Logger());

        /// <summary>
        /// Instance
        /// </summary>
        public static Logger Instance
        {
            get { return _lazyLogger.Value;  }
            //get
            //{
            //    if (_instance == null)
            //    {
            //        _instance = new Logger();
            //    }
            //    return _instance;
            //}
        }

        protected Logger()
        {
        }

        /// <summary>
        /// SingletonOperation
        /// </summary> 
        public void Log(string message)
        {
            if (message.Equals("\n"))
            {
                Console.WriteLine(message);
            }
            else
            { 
                Console.WriteLine($"Message to log: {message}");
            }
        }
    }
}

// IMDB Singelton  

public sealed class InMemoryDB
{
    private List<decimal>? _rates;
    private List<string>? _names;
    private List<string>? _counties;

    private static readonly Lazy<InMemoryDB> _imdb
        = new Lazy<InMemoryDB>(FactoryInMemoryDB().Result);

    /// <summary>
    /// Instance
    /// </summary>
    public static InMemoryDB Instance
    {
        get { return _imdb.Value; }
    }

    private InMemoryDB()
    {
    }
    async private static Task<InMemoryDB> FactoryInMemoryDB()
    {
        var ratesTask = Task.FromResult(new List<decimal> { 777, 14, 2 }); // Replace Task.FromResult with the real async call 
        var namesTask = Task.FromResult(new List<string> { "nameDemo", "AA", "BB" });
        var countiesTask = Task.FromResult(new List<string> { "countyDemo", "CC", "DD" });
        await Task.WhenAll(ratesTask, namesTask, countiesTask);

        var imdb = new InMemoryDB();
        imdb._rates = ratesTask.Result;
        imdb._names = namesTask.Result;
        imdb._counties = countiesTask.Result;

        return imdb;
    }

    /// <summary>
    /// SingletonOperation
    /// </summary> 
    public decimal? GetRate()
    {
        return _rates?.FirstOrDefault();
    }
    public string? GetName()
    {
        return _names?.FirstOrDefault();
    }
    public string? GetCounty()
    {
        return _counties?.FirstOrDefault();
    }
}

