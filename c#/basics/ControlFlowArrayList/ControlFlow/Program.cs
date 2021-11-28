namespace ControlFlow
{
    class Program
    {
        public static void Main(string[] args)
        {

            // Random class
            var r = new Random();
            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            for (int i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char) ((int)'a'+r.Next(0, 26));
            }
            string password = new string(buffer);
            Console.WriteLine("password: " +password);
            Console.WriteLine("password: ", password);

            // for loop
            for (var i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
                if (i == 4)
                {
                    break;
                }
            }

            // foreach
            string name = "harry sandu";
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            int[] nums = new int[2] {0,1};
            foreach(var i in nums)
            {
                Console.WriteLine(i);
            }

            // while
            while (true)
            {
                Console.Write("name:");
                var ip = Console.ReadLine();
                if (!string.IsNullOrEmpty(ip))
                {
                    Console.WriteLine("echo:"+ip);
                    continue;
                }
                break;
            }

            // do while
            Console.WriteLine("---- do while ----");
            do
            {
                Console.Write("name:");
                var ip = Console.ReadLine();
                if (!string.IsNullOrEmpty(ip))
                {
                    Console.WriteLine("echo:" + ip);
                    continue;
                }
                break;
            } while (true);

            // if, else if, else
            Console.WriteLine("control flow");
            Console.WriteLine("first no:");
            var no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("second no:");
            var no2 = Convert.ToInt32(Console.ReadLine());
            if (no1 > no2)
            {
                Console.WriteLine($"{no1} is greater");
            }
            else if (no1 < no2)
            {
                Console.WriteLine($"{no2} is greater");
            }else
            {
                Console.WriteLine($"{no1} and {no2} are equal");
            }

            // switch
            Console.WriteLine("enter season code: 0.Autumn, 1.Spring, 2.Summer, 3.Rainy, 4.Winter");
            var code = (Season)Convert.ToInt32(Console.ReadLine());
            switch (code)
            {
                case Season.Autumn:
                case Season.Spring:
                    {
                        Console.WriteLine("autum and spring season");
                        break;
                    }
                case Season.Summer:
                    {
                        Console.WriteLine("summer season");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("donot know this season");
                        break;
                    }
            }

            


        }
    }
}