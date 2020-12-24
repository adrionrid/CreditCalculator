using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CreditCalculator.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CreditCalculator.Controllers
{
    public class AnnuityLoanController : Controller
    {
        public IActionResult Index(AnnuityLoan annuityLoan)
        {
            //if (annuityLoan.IsPaymentsCalculatable)
                annuityLoan.CreatePayments();

            return View(annuityLoan);
        }
    }
}
