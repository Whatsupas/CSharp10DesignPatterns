using Singleton;
using System;

// call the property getter twice
var instance1 = Logger.Instance;
var instance2 = Logger.Instance;

if (instance1 == instance2 && instance2 == Logger.Instance)
{
    Logger.Instance.Log("Instances are the same.");
}

instance1.Log($"Message from {nameof(instance1)}");
// or
instance1.Log($"Message from {nameof(instance2)}");
// or
Logger.Instance.Log($"Message from {nameof(Logger.Instance)}");


// imdb instance
var imdb = InMemoryDB.Instance;

Logger.Instance.Log();
Logger.Instance.Log("Testing imdb instance"); 
Logger.Instance.Log($"{imdb.GetRate()} {imdb.GetName()} {imdb.GetCounty()}");