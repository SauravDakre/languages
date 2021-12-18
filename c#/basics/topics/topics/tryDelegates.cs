namespace Topics
{
    public delegate void TestDelegate();

    public delegate bool TestBoolDelegate(int i);

    class TryDelegates {


        public static void TestDelegateFunction(){
            System.Console.WriteLine("test delegate function");
        }

        public static void TestSecondDelegateFunction(){
            System.Console.WriteLine("test second delegate function");
        }

        public static bool GreaterThanEqualTo5(int i){
            return i >= 5;
        }
    }


}
