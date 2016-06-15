namespace MobilePhone
{
    using System;
    using System.Text;

    internal class Battery
    {
        private BatteryType model;
        private int? idleHours;
        private int? talkHours;

        public Battery(BatteryType model)
        {
            this.Model = model;
            this.HoursIdle = null;
            this.HoursTalk = null;
        }

        public Battery(BatteryType model, int hoursIdle, int hoursTalk)
            : this(model)
        {
            this.idleHours = hoursIdle;
            this.talkHours = hoursTalk;
        }

        public BatteryType Model
        {
            get
            {
                return this.model;
            }

            set
            {
                this.model = value;
            }
        }

        public int? HoursIdle
        {
            get
            {
                return this.idleHours;
            }

            set
            {
                if (this.idleHours <= 0)
                {
                    throw new ArgumentException("Houre idle {0}", Constants.NegativeNumber);
                }
                else
                {
                    this.idleHours = value;
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.talkHours;
            }

            set
            {
                if (this.talkHours <= 0)
                {
                    throw new ArgumentException("Hours talk {0}", Constants.NegativeNumber);
                }
                else
                {
                    this.idleHours = value;
                }
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.Append($"Type - {this.model}; ");

            if (this.HoursTalk == null)
            {
                output.Append(string.Format("Hours Talk - {0}; ", Constants.NoInformation));
            }
            else
            {
                output.Append($" Hours Talk - {this.HoursTalk};");
            }

            if (this.HoursIdle == null)
            {
                output.Append(string.Format("Hours Idle - {0}", Constants.NoInformation));
            }
            else
            {
                output.Append($" Hours Idle - {this.idleHours}");
            }

            return output.ToString();
        }
    }
}