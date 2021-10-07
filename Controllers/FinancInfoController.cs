using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using my_projects.Models;
using System.Text.Json;
public class FinancInfoController : Controller
{

	public IActionResult Index()
	{
		return View();
	}
	public IActionResult FinancialReport()
	{
		// System.Threading.Thread.Sleep(3000);
		var data=ReadJsonFile.read(AppContext.BaseDirectory+@"\DATA\financialReport.json");
		var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
       var  model = JsonSerializer.Deserialize<List<FinancialReportViewModel>>(data, options);
		return PartialView(model);
	}
		public IActionResult StepPayments()
	{
		// System.Threading.Thread.Sleep(3000);
		var data=ReadJsonFile.read(AppContext.BaseDirectory+@"\DATA\StepPayments.json");
		var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        var model = JsonSerializer.Deserialize<List<StepPaymentsViewModel>>(data, options);	
		return PartialView(model);
	}


}