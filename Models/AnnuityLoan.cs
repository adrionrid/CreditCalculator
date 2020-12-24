using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CreditCalculator.Models
{
    [Display(Name = "Аннуитетный займ")]
    public class AnnuityLoan
    {
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Введите значение более 0.")]
        [Display(Name = "Сумма займа")]
        public double Amount { get; set; }

        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Введите значение более 0.")]
        [Display(Name = "Срок займа", Description = "(в месяцах)")]
        public int Term { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Введите значение от 0 до 100.")]
        [Display(Name = "Ставка", Description = "(в год)")]
        public double Rate { get; set; }

        public bool IsPaymentsCalculatable => Amount != default && Term != default && Rate != default;

        public List<AnnuityLoanPayment> Payments = new List<AnnuityLoanPayment>();

        [Display(Name = "Сумма переплаты")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double OverpaymentAmount => Payments != null && Payments.Count > 0 ? Payments[0].Amount * Term - Amount : 0;

        public void CreatePayments()
        {
            Payments = CreateAnnuityLoanPayments(this);
        }
        public static List<AnnuityLoanPayment> CreateAnnuityLoanPayments(AnnuityLoan loan)
        {
            return CreateAnnuityLoanPayments(loan.Amount, loan.Term, loan.Rate);
        }
        public static List<AnnuityLoanPayment> CreateAnnuityLoanPayments(double amount, int term, double rate)
        {
            var list = new List<AnnuityLoanPayment>();
            rate /= 100;
            rate /= 12;
            var paymentPerMonth = CalculateAnnuityPayment(rate, term, amount);
            var startDate = DateTime.UtcNow;
            var debt = amount;
            for (int i = 1; i <= term; i++)
            {
                var percentPayment = debt * rate;
                var pay = paymentPerMonth - percentPayment;
                var x = new AnnuityLoanPayment(i, startDate = startDate.AddMonths(1), paymentPerMonth, debt / amount, pay, debt = debt - pay);
                list.Add(x);
            }
            return list;
        }
        private static double CalculateAnnuityPayment(double rate, int term, double creditSum)
        {
            return CalculateAnnuityCoefficient(rate, term) * creditSum;
        }
        private static double CalculateAnnuityCoefficient(double rate, int term)
        {
            var x = Math.Pow(1 + rate, term);
            return rate + rate / (x - 1);
        }
    }
}
