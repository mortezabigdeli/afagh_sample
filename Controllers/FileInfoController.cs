using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using my_projects.Models;
using System.Text.Json;
public class FileInfoController : Controller
{
	public IActionResult Index()
	{
		return View();
	}
	public IActionResult DisabledCredentials()
	{
		var data=ReadJsonFile.read(AppContext.BaseDirectory+@"\DATA\DisabledCredential.json");
		var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
       var  model = JsonSerializer.Deserialize<List<DisabledCredentialsViewMode>>(data, options);
		return PartialView(model);
	}
		public IActionResult ProfileInfo()
	{
		var data=ReadJsonFile.read(AppContext.BaseDirectory+@"\DATA\Profile.json");
		var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);
        var  model = JsonSerializer.Deserialize<ProfileVewModel>(data, options);
	   Console.Write(model);
		return PartialView(model);
	}
}