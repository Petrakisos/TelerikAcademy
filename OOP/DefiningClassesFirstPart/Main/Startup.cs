namespace MobilePhone
{
    using System;

    public class Startup
    {
        static void Main()
        {
            GSMTest test = new GSMTest();

            test.DisplayGsmInformation();

            Call call = new Call(new DateTime(2016, 07, 12, 21, 41, 10), "0888 888 888", 921);

            Console.WriteLine(call.ToString());

            CallHistoryTest callTest = new CallHistoryTest();

            callTest.Functions();
        }
    }
}
