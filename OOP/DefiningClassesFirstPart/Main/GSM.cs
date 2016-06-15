namespace MobilePhone
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class GSM
    {
        public static readonly GSM IPhone4S = new GSM(
            "iPhone 4S",
            "Apple",
            5000,
            "Silver",
            new Battery(BatteryType.LiPo, 200, 100),
            new Display(6.6, 19000000));

        private string model;
        private string manufacturer;
        private decimal? price;
        private string color;
        private Battery battery;
        private Display display;
        private List<Call> callHistory = new List<Call>();

        public GSM(string model, string manufacture)
        {
            this.Model = model;
            this.Manufacture = manufacture;
            this.Price = null;
            this.Color = null;
            this.Battery = null;
            this.Display = null;
        }

        public GSM(string model, string manufacture, decimal? price)
            : this(model, manufacture)
        {
            this.Price = price;
        }

        public GSM(string model, string manufacture, decimal? price, string owner)
           : this(model, manufacture, price)
        {
            this.Color = owner;
        }

        public GSM(string model, string manufacture, decimal? price, string owner, Battery baterry)
            : this(model, manufacture, price, owner)
        {
            this.Battery = baterry;
        }

        public GSM(string model, string manufacture, decimal? price, string owner, Battery baterry, Display display)
           : this(model, manufacture, price, owner, baterry)
        {
            this.Display = display;
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    this.model = value;
                }
                else
                {
                    throw new ArgumentNullException("Model {0}", Constants.NullValue);
                }
            }
        }

        public string Manufacture
        {
            get
            {
                return this.manufacturer;
            }

            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    this.manufacturer = value;
                }
                else
                {
                    throw new ArgumentNullException("GSM manugacturer {0}", Constants.NullValue);
                }
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }

            set
            {
                this.color = value;
            }
        }

        public decimal? Price
        {
            get
            {
                return this.price;
            }

            set
            {
                if (this.Price < 0)
                {
                    throw new ArgumentException("Price {0}", Constants.NegativeNumber);
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }

            set
            {
                this.display = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }

            set
            {
                this.battery = value;
            }
        }

        public List<Call> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public decimal CalculateTotalCallPrice(decimal pricePerMinute)
        {
            var totalSeconds = 0;

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                totalSeconds += this.callHistory[i].DurationInSeconds;
            }

            decimal price = totalSeconds * (pricePerMinute / Constants.minuteLenghtInSecs);

            return price;
        }

        public string CallHistoryInfo()
        {
            var callHistoryInfo = new StringBuilder();

            if (this.callHistory.Count == 0)
            {
                return "Call history is empty!";
            }

            callHistoryInfo.Append("Date\t\tTime\t\tDailed number\tDuration seconds\n");

            for (int i = 0; i < this.callHistory.Count; i++)
            {
                callHistoryInfo.Append(this.callHistory[i].ToString());
                callHistoryInfo.Append("\n");
            }

            return callHistoryInfo.ToString();
        }

        public void DisplayInfo()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.Append(string.Format("Model:\t\t {0}", this.model))
                .Append("\n")
                .Append(string.Format("Manufacture:\t {0}", this.manufacturer))
                .Append("\n");

            string value;

            if (this.price >= 0)
            {
                value = string.Format("{0:f2} BGN", this.price);
            }
            else
            {
                value = Constants.NoInformation;
            }

            output.Append(string.Format("Price:\t\t {0}", value))
                .Append("\n");

            if (!string.IsNullOrEmpty(this.color))
            {
                value = this.color;
            }
            else
            {
                value = Constants.NoInformation;
            }

            output.Append(string.Format("Owner:\t\t {0}", value))
               .Append("\n");

            if (this.battery != null)
            {
                value = this.battery.ToString();
            }
            else
            {
                value = Constants.NoInformation;
            }

            output.Append(string.Format("Battery:\t {0}", value))
            .Append("\n");

            if (this.display != null)
            {
                value = this.display.ToString();
            }
            else
            {
                value = Constants.NoInformation;
            }

            output.Append(string.Format("Display:\t {0}", value))
            .Append("\n");

            return output.ToString();
        }

        public void AddCall(Call currentCall)
        {
            this.callHistory.Add(currentCall);
        }

        public void DeleteCall(Call currentCall)
        {
            this.callHistory.Remove(currentCall);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }
    }
}
