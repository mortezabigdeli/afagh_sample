public static class ReadJsonFile 
{
	public static string read(string path)
	{
	return  System.IO.File.ReadAllText(path);
	}

}