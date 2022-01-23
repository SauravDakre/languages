using System.Diagnostics;

namespace Topics
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("collections example");
            tryCollections();

            Console.WriteLine("async await example");
            await tryAsync();
            Console.WriteLine("await complete");

            Console.WriteLine("namespace example");

            System.Console.WriteLine("events example:");
            tryEvent();

            System.Console.WriteLine("delegates example");
            tryDelegates();

            n1.c1.info();
            n2.c2.info();
            nn1.nn2.c1.info();

            TryException.tryExc();
            TryException.tryCatchFinally();
        }

        private static Action testActionDelegate;

        private static Action<int, float> testSecondActionDelegate;

        private static Func<int, float, float> testFuncDelegate;

        public static void tryDelegates()
        {
            TestDelegate testDelegate = TryDelegates.TestDelegateFunction;
            testDelegate();

            // combine delegates ( multicast delegates )
            testDelegate += TryDelegates.TestSecondDelegateFunction;
            System.Console.WriteLine("====");
            testDelegate();
            System.Console.WriteLine("====");

            // remove a delegate from multicast delegates
            testDelegate -= TryDelegates.TestDelegateFunction;
            testDelegate();
            System.Console.WriteLine("====");

            TestBoolDelegate testBoolDelegate =
                TryDelegates.GreaterThanEqualTo5;
            System.Console.WriteLine(testBoolDelegate(9));

            // lambda function
            testBoolDelegate = (int t) => t <= 5;
            System
                .Console
                .WriteLine("less than equal to 5: " + testBoolDelegate(9));

            // annoymous function
            testBoolDelegate =
                delegate (int t)
                {
                    return t == 5;
                };
            System.Console.WriteLine(" equal to 5: " + testBoolDelegate(5));

            testActionDelegate = () =>
                System.Console.WriteLine("test action delegate");
            testActionDelegate();

            testSecondActionDelegate = (int x, float y) =>
                System
                    .Console
                    .WriteLine("----testSecondActionDelegate: " + (x + y));
            testSecondActionDelegate(5, 2.0f);

            testFuncDelegate = (int x, float y) => (x + y);
            System
                .Console
                .WriteLine("testFuncDelegate:=" + testFuncDelegate(2, 5.0f));

            System
                .Console
                .WriteLine("useDelgateFunction " +
                useDelgateFunction(5, testBoolDelegate));
        }

        // passing function as parameter
        public static bool
        useDelgateFunction(int x, TestBoolDelegate testBoolDelegate)
        {
            return testBoolDelegate(x);
        }

        public static void tryEvent()
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();

            ShapeContainer sc = new ShapeContainer();
            sc.AddShape (c);
            sc.AddShape (r);

            c.updateCircle(5);
            r.updateRectangle(5, 5);
        }

        public static async Task tryAsync()
        {
            await TryAsync.GetNumAsync();
            await TryAsync.JustAsnyc();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            await TryAsync.DoWork("z", 3000);
            await TryAsync.DoWork("x", 3000);
            await TryAsync.DoWork("y", 3000);
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine($"time elapsed:{ts.Seconds}");

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Task z = TryAsync.DoWork("z", 3000);
            Task y = TryAsync.DoWork("y", 3000);
            Task x = TryAsync.DoWork("x", 3000);
            await z;
            await y;
            await x;
            sw.Stop();
            ts = sw.Elapsed;
            Console.WriteLine($"time elapsed:{ts.Seconds}");
        }

        public static void tryCollections(){
            TryCollections.DictionaryCrud();
            TryCollections.ListCrud();
        }
    }
}
