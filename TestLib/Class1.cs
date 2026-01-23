using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestLib;

public class Class1
{
    public static async Task TestFunction()
    {
        var list = new List<string>()
        {
            "one",
            "2",
        };

        await foreach (var item in list.ToAsyncEnumerable())
        {
            Console.WriteLine(item);
        }
    }
}
