namespace Topics
{
    class TryCollections
    {

        public static void QueueCrud()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("q");
            q.Enqueue("w");
            q.Enqueue("e");
System.Console.WriteLine(q.Peek())
            foreach(string t in q){
                System.Console.WriteLine(t);
            }
            q.
        }
        public static void DictionaryCrud()
        {
            Dictionary<string, string> kv = new Dictionary<string, string>();
            kv.Add(key: "k1", value: "v1");
            kv.Add(key: "k2", value: "v2");
            kv.Add(key: "k3", value: "v3");
            kv.Add("k4", "v4");
            foreach (KeyValuePair<string, string> e in kv)
            {
                System.Console.WriteLine($"{e.Key}:{e.Value}");
            }

            string k = "k4";
            System.Console.WriteLine($"{k} value: {kv[k]}");
            System
                .Console
                .WriteLine($"{kv.ContainsKey("k5")}, {kv.ContainsValue("v2")}");

            kv.Remove(k);
            // System.Console.WriteLine($"{k} value: {kv[k]}"); - throws exception
            foreach (KeyValuePair<string, string> e in kv)
            {
                System.Console.WriteLine($"{e.Key}:{e.Value}");
            }
        }

        public static void ListCrud()
        {
            List<string> ls = new List<string>();
            ls.Add("q");
            ls.Add("w");
            ls.Add("e");
            foreach (string s in ls)
            {
                System.Console.WriteLine (s);
            }
            ls.Insert(1, "r");
            for (int i = 0; i < ls.Count; i++)
            {
                System.Console.WriteLine(ls[i]);
            }
            ls.RemoveAt(2);
            ls.Sort();
            ls.Reverse();
            System.Console.WriteLine("list");
            foreach (string s in ls)
            {
                System.Console.WriteLine (s);
            }
        }
    }
}
