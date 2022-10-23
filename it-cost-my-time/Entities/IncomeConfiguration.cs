using Blazored.LocalStorage;

namespace it_cost_my_time.Entities
{
    public class IncomeConfiguration
    {
        public decimal Income { get; set; } = 30000;
        public int WorkingDays { get; set; } = 5;
        public int WorkingHours { get; set; } = 8;
        public int PayMonths { get; set; } = 13;
        public decimal SavingRate { get; set; } = 50;

        private bool _incomeType;

        public bool IncomeTypeSelect
        {
            get
            {
                return this._incomeType;
            }

            set
            {
                if (_incomeType != value)
                    Income = decimal.Round(value ? Income * PayMonths : Income / PayMonths, 2, MidpointRounding.AwayFromZero);

                _incomeType = value;
            } 
        }

        public string IncomeType
        {
            get
            {
                return (IncomeTypeSelect ?
                    "Yearly Income (after tax)"
                :
                    "Monthly Income (after tax)");
            }

            set
            {
                value = null;
            }
        }

        public void ReadConfiguration(IncomeConfiguration configuration)
        {
            this.Income = configuration.Income;
            this._incomeType = configuration.IncomeTypeSelect;
            this.WorkingDays = configuration.WorkingDays;
            this.WorkingHours = configuration.WorkingHours;
            this.PayMonths = configuration.PayMonths;
            this.SavingRate = configuration.SavingRate; 
        }
    }
}
