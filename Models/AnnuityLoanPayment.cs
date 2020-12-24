using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCalculator.Models
{
    public class AnnuityLoanPayment
    {
        [Display(Name = "№")]
        public int Number { get; set; }

        [Display(Name = "Дата платежа")]
        [DataType(DataType.Date)]
        public DateTime PaymentDate { get; set; }

        [Display(Name = "Сумма платежа")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Amount { get; set; }

        [Display(Name = "Проценты")]
        [DisplayFormat(DataFormatString = "{0:P}")]
        public double Percent { get; set; }

        [Display(Name = "Основной долг")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double MainDebt { get; set; }

        [Display(Name = "Остаток долга")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Debt { get; set; }

        public AnnuityLoanPayment(int number, DateTime date, double amount, double percent, double mainDebt, double debt)
        {
            Number = number;
            PaymentDate = date;
            Amount = amount;
            MainDebt = mainDebt;
            Percent = percent;
            Debt = debt;
        }
    }
}
