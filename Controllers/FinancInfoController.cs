using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_projects.Models;
public class FinancInfoController : Controller
{

	public IActionResult Index()
	{
		return View();
	}
	public IActionResult FinancialReport()
	{
		List<FinancialReportViewModel> model = new List<FinancialReportViewModel>();
		model.Add(
			new FinancialReportViewModel()
			{
				Description = "مانده بدهکاری عضو از مال 1397",
				DocumentDate = "1399/04/29",
				Debtor = "2,800,000",
				Creditor = "0",
				Remaining = "2,800,000",
			});
		return View(model);
	}


}