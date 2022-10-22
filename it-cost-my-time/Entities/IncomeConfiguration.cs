namespace it_cost_my_time.Entities
{
    public class IncomeConfiguration
    {
        public decimal Income { get; set; } = 30000;
        public int WorkingDays = 5;
        public int WorkingHours = 8;
        public int PayMonths = 13;

        public decimal SavingRate = 50;
        public decimal Amount = 100;
        public bool IncomeTypeSelect { get; set; } = true;

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

    }
}
