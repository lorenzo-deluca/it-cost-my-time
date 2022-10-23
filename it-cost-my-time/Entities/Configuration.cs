namespace it_cost_my_time.Entities
{
    public class Configuration
    {
        public decimal YearlyIncome { get; set; } = 30000;
      
        public int WorkingDays { get; set; } = 5;
        public int WorkingHours { get; set; } = 8;
        
        public decimal SavingRate { get; set; } = 50;
        public string Currency { get; set; } = "€";

        //        public bool IncomeType { get; set; } = true;
        private bool _incomeType = true;
        public bool IncomeType
        {
            get
            {
                return this._incomeType;
            }

            set
            {
                if (_incomeType != value)
                {
                    if (value)
                        YearlyIncome = decimal.Round(MonthlyIncome * PayMonths, 2, MidpointRounding.AwayFromZero);
                    else
                        MonthlyIncome = decimal.Round(YearlyIncome / PayMonths, 2, MidpointRounding.AwayFromZero);
                }

                _incomeType = value;
            } 
        }

        //   public decimal MonthlyIncome { get; set; } = 0;
        private decimal _monthlyIncome = 0;
        public decimal MonthlyIncome
        {
            get
            {
                return this._monthlyIncome;
            }

            set
            {
                if (!_incomeType)
                {
                    YearlyIncome = decimal.Round(value * PayMonths, 2, MidpointRounding.AwayFromZero);
                }

                _monthlyIncome = value;
            }
        }

        // public int PayMonths { get; set; } = 13;
        private int _payMonths { get; set; } = 13;
        public int PayMonths
        {
            get
            {
                return this._payMonths;
            }

            set
            {
                if (!_incomeType)
                {
                    YearlyIncome = decimal.Round(MonthlyIncome * value, 2, MidpointRounding.AwayFromZero);
                }

                _payMonths = value;
            }
        }


        public void ReadConfiguration(Configuration configuration)
        {
            YearlyIncome = configuration.YearlyIncome;
            MonthlyIncome = configuration.MonthlyIncome;
            IncomeType = configuration.IncomeType;
            WorkingDays = configuration.WorkingDays;
            WorkingHours = configuration.WorkingHours;
            PayMonths = configuration.PayMonths;
            SavingRate = configuration.SavingRate;
            Currency = configuration.Currency;
        }
    }
}
