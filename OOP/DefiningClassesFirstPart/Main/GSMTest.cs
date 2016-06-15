namespace MobilePhone
{
    public class GSMTest
    {
        private GSM[] GSMArray =
                 {
                new GSM("Iphone 4S", "Apple", 8000, "Silver", new Battery(BatteryType.NiCd, 72, 48), new Display(5.5, 16000000)),
                new GSM("G4", "LG", 10000, "Black", new Battery(BatteryType.LiIon, 48, 24), new Display(5.7, 19000000)),
                new GSM("G5", "LG", 20000, "Gold", new Battery(BatteryType.LiPo, 60, 36), new Display(6.3, 18000000))
            };

        public void DisplayGsmInformation()
        {
            foreach (var gsm in GSMArray)
            {
                gsm.DisplayInfo();
            }

            GSM.IPhone4S.DisplayInfo();
        }
    }
}
