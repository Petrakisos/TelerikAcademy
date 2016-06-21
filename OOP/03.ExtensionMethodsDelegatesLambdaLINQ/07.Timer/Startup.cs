namespace Timer
{
    class Startup
    {
        static void Main()
        {
            Timer timer = new Timer(1);
            timer.InvokeDelegate();
        }
    }
}
