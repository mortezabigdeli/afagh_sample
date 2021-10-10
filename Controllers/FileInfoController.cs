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
		return PartialView();
	}
	public String getDisabledCredentials()
	{
		var data=ReadJsonFile.read(AppContext.BaseDirectory+@"\DATA\DisabledCredential.json");
		return data;
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