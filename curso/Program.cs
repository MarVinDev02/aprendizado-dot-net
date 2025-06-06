using System.Collections;

var array = new ArrayList();
array.Add(14);
array.Add("Marcus");
array.Add(true);

foreach (var item in array)
{
    Console.WriteLine(item);
}

Console.ReadKey();