namespace MobilePhone
{
    using System;
    using System.Linq;

    public class CallHistoryTest
    {
        private GSM someGSM = new GSM("mi5", "Xiaomi");
        private const decimal PricePerMinute = 0.90m;

        public void Functions()
        {
            someGSM.AddCall(new Call(new DateTime(2016, 02, 14, 01, 10, 01), "0888 78 87 98", 282));
            someGSM.AddCall(new Call(new DateTime(2016, 02, 14, 03, 30, 23), "0887 57 20 12", 951));
            someGSM.AddCall(new Call(new DateTime(2016, 02, 14, 05, 34, 15), "0883 52 88 10", 456));
            someGSM.AddCall(new Call(new DateTime(2016, 02, 15, 12, 11, 05), "0886 52 03 78", 654));
            someGSM.AddCall(new Call(new DateTime(2016, 02, 16, 17, 16, 10), "0882 80 74 21", 311));

            Console.WriteLine(someGSM.CallHistoryInfo());
            Console.WriteLine("Total call price: {0:F2} BGN", someGSM.CalculateTotalCallPrice(PricePerMinute));

            Call longestCall = someGSM.CallHistory.OrderByDescending(x => x.DurationInSeconds).First();

            someGSM.DeleteCall(longestCall);

            Console.WriteLine(
                "Total call price after removing longest call is {0:F2} BGN",
                someGSM.CalculateTotalCallPrice(PricePerMinute));

            someGSM.ClearHistory();

            Console.WriteLine(someGSM.CallHistoryInfo());
        }
    }
}
