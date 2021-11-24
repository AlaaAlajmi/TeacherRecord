using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Create File");
			FileCreation();
			// System Options
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("*******************************************************");
			Console.WriteLine("	Welcome to Rainbow School System");
			Console.WriteLine("*******************************************************\n");
			Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("*******************************************************");
			Console.WriteLine("Please Enter your Option:");
			Console.WriteLine("1. Insert");
			Console.WriteLine("2. Retrieve");
			Console.WriteLine("3. Update");
			Console.WriteLine("4. Clear File");
			Console.WriteLine("*******************************************************");


			
		}
		// File Creation Method
		public static void FileCreation(){
		// Creating a file
		string dir = Directory.GetCurrentDirectory();
		string filename = dir + "TeacherData.txt";
			//Console.WriteLine("The current directory is {0}", filename);

			// Check if file exists
			if (File.Exists(filename))
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("*******************************************************");
				Console.WriteLine("			File Exists");
				Console.WriteLine("******************************************************* \n");
			}
			else
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("*******************************************************");
				Console.WriteLine("			File Doesn't Exist");
				Console.WriteLine("******************************************************* \n");
				File.CreateText(filename);
			}
			List<string> lines = File.ReadAllLines(filename).ToList();
		}

	}
}
