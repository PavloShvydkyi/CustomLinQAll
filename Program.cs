using CustomLinQAll;

var l = new List<int>();
Console.WriteLine("empty list returns {0}", l.CastomAll((el) => { return false; }));
int[] a = { };
Console.WriteLine("empty array returnt {0}", a.CastomAll((el) => { return false; }));
