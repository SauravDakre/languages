namespace Topics
{
    class TryException
    {
        public static void tryCatchFinally()
        {
            try
            {
                var x = 1;
                var y = 2;
                throw new Exception();
            }catch(DivideByZeroException e)
            {
                Console.WriteLine("divide by zero exception"+e);
            }
            catch(CustomException e)
            {
                Console.WriteLine("custom exception "+e);
            }catch(Exception e)
            {
                Console.WriteLine("generic exception "+e);
                throw e;
            }
            finally{
                Console.WriteLine("caught finally");
            }
        }
        public static void tryExc()
        {
            try
            {
                throw new CustomException("test exception");
            }catch(CustomException e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"message: {e.Message}");
                Console.WriteLine($"stacktrace: {e.StackTrace}");
            }
        }
    }
    class CustomException: Exception
    {
        public CustomException(string message):base(message){}
    }
}
