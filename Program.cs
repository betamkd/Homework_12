using Homework_12;
using System.Security.Cryptography.X509Certificates;

//	******************************C# Interfaces ******************************
//	Exercises
//	* *****************************

public interface IShape
{
	void CalculateArea();
}

public interface ILogger
{
	void LogMessage(string message);

}

public interface IPlayable
{
	void Play();
	void Stop();
}


public class Program
{
	public static void Main(string[] args)
	{
		
		Circle circle = new Circle();
		Rectangle rectangle = new Rectangle();

		circle.CalculateArea();
		rectangle.CalculateArea();
		Console.WriteLine("*****************************************\n");


		FileLogger file = new FileLogger();
		ConsoleLogger console = new ConsoleLogger();

		string message = "is succesfull.";
		file.LogMessage(message);
		console.LogMessage(message);
		Console.WriteLine("*****************************************\n");

		VideoPlayer video = new VideoPlayer();
		AudioPlayer audio = new AudioPlayer();

		video.Play();
		audio.Play();
		video.Stop();
		audio.Stop();
		Console.WriteLine("*****************************************\n");

		//		******************************C# Strings ******************************
		//		Exercises
		//		*****************************

		// - Exercise 1:
		string string1 = "Hello";
		string string2 = " ";
		string string3 = "World";
		string string4 = "Universe";

		string expression = string.Concat(string1, string2, string3, string2, string1, string2, string4);
		Console.WriteLine(expression);
		Console.WriteLine("*****************************************\n");

		// - Exercise 2:
		string exampleString = "Hello World, Hello Universe";
		char oldChar = 'o';
		char newChar = '-';

		string result = exampleString.Replace(oldChar, newChar);
		Console.WriteLine(result);
		Console.WriteLine("*****************************************\n");

		// - Exercise 3:
		string lastString = "";
		int lastChar = exampleString.LastIndexOf(lastString);
		string exampleStringFinal = exampleString.Substring(0, lastChar - 1);
		Console.WriteLine(exampleStringFinal);
		Console.WriteLine("*****************************************\n");



		//string exampleStringResult = exampleString.Substring(0, lastChar);
		//Console.WriteLine(exampleStringResult);


	}

}


