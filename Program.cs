using CustomLinQAll;

var l = new List<int>();
Console.WriteLine("empty list custom All returns  {0}", l.CustomAll((el) => { return false; }));
Console.WriteLine("empty list All returns  {0}", l.All((el) => { return false; }));

int[] a = { };
Console.WriteLine("");
Console.WriteLine("empty array custom All returns  {0}", a.CustomAll((el) => { return false; }));
Console.WriteLine("empty array All returns  {0}", a.All((el) => { return false; }));
