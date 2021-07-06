using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using my_projects.Models;

public class FileInfoController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
	public IActionResult DisabledCredentials()
	{
		List<DisabledCredentialsViewMode> model = new List<DisabledCredentialsViewMode>();
		model.Add(
			new DisabledCredentialsViewMode()
			{
				StartDate = "1399/01/30",
				EndDate = "1400/01/300",
				OrganizationalField = "تاسیسات مکانیکی",
				TypeOfCompetence = "طراحی",
				ShareAndWork = "سهم",
				DateOfRegistration = "1399/02/01",
				Description = "باید عضو اصلی دفتر شود",
			});
		return View(model);
	}
}