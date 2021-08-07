using System;

namespace WebsiteDescription
{
	public class Program
	{
		public static void Main(string[] args)
		{
			TrainingRecource[] tr =
			{
				new NetworkResource(new Guid(), "C# Url"),
				new TextRecource(new Guid(), "C# Text"),
				new VideoResource(new Guid(), "C# Video"),
			};

			TrainingSession ts = new TrainingSession(new Guid(), "Session #1");
			ts.TrainingRecources = tr;

			TrainingSession ts2 = (TrainingSession) ts.Clone();

			ts2.TrainingRecources[0].TrainingDescription = "C# Url v2.0";

			Console.WriteLine(ts.TrainingRecources[0].TrainingDescription);
		}
	}
}