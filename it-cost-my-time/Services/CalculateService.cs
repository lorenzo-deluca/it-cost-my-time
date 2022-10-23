using it_cost_my_time.Entities;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace it_cost_my_time.Services
{
    public class CalculateService
    {
        private readonly Configuration IncomeConfiguration;

        public CalculateService(Configuration incomeConfiguration)
        {
            IncomeConfiguration = incomeConfiguration;
        }

        /*
        public decimal YearlyIncome
        {
            get
            {
                if (IncomeConfiguration.IncomeTypeSelect)
                {
                    return IncomeConfiguration.YearlyIncome;
                }
                else
                {
                    return (IncomeConfiguration.YearlyIncome * IncomeConfiguration.PayMonths);
                }
            }
        }
        */

        public decimal YearlySavings
        {
            get
            {
                return (decimal)(IncomeConfiguration.YearlyIncome / 100) * IncomeConfiguration.SavingRate;
            }
        }

        public decimal TotalWorkingDays
        {
            get
            {
                return (IncomeConfiguration.WorkingDays * 4 * 12);
            }
        }

        public decimal TotalWorkingHours
        {
            get
            {
                return (TotalWorkingDays * IncomeConfiguration.WorkingHours);
            }
        }

        public decimal MonthlySavings
        {
            get
            {
                return (YearlySavings / 12);
            }
        }

        /*
        public decimal MonthlyIncome
        {
            get
            {
                return (YearlyIncome / 12);
            }
        }
        */
        public decimal DailySaving
        {
            get
            {
                return YearlySavings / TotalWorkingDays;
            }
        }

        public decimal DailyIncome
        {
            get
            {
                return IncomeConfiguration.YearlyIncome / TotalWorkingDays;
            }
        }

        public decimal HourlySaving
        {
            get
            {
                return YearlySavings / TotalWorkingHours;
            }
        }

        public decimal HourlyIncome
        {
            get
            {
                return IncomeConfiguration.YearlyIncome / TotalWorkingHours;
            }
        }

        public (decimal hours, decimal days)CalculateItemTimeCost(decimal amount) {

            var hours = amount / (YearlySavings / TotalWorkingHours);
            var days = amount / (YearlySavings / TotalWorkingDays);

            return (hours, days);
        }
    }
}
