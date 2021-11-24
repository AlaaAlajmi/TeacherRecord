using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp2
{
	class Program
	{
		static string filename;
		static List<string> lines;
		static void Main(string[] args)
		{
			// Calling the File Creation Method
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

			//InsertUser();
			RetrieveUser();

		}
		// File Creation Method
		public static void FileCreation()
		{
			// Creating a file
			string dir = Directory.GetCurrentDirectory();
			 filename = dir + "TeacherData.txt";
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
			lines = File.ReadAllLines(filename).ToList();
		}
		public static void InsertUser()
		{
			Console.WriteLine("Enter How many user you want:");
			int InputCont = Convert.ToInt32(Console.ReadLine());
			for (int i = 0; i < InputCont; i++)
			{
				Console.WriteLine("Enter ID :");
				int UserID = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter Name :");
				string UserName = Console.ReadLine();
				Console.WriteLine("Enter Class :");
				string UserClass = Console.ReadLine();
				Console.WriteLine("Enter Section :");
				string UserSection = Console.ReadLine();
				string x = UserID.ToString() + ',' + UserName + ',' + UserClass + ',' + UserSection;
				lines.Add(x);
				File.WriteAllLines(filename, lines);
			}
		}
		public static void RetrieveUser(){
		Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine(" \n*******************************************************");
				Console.WriteLine("Enter ID to Retrieve:");
				string SearchID = Console.ReadLine();
		Console.WriteLine("*******************************************************");
			foreach (var line in lines)
			{
				string[] result = line.Split(',');
				if (result[0] == SearchID)
				{

					Console.WriteLine("ID:" + result[0] + "\t Name:" + result[1] + "\tClass: " + result[2] + "\t Section:" + result[3]);
					Console.WriteLine("******************************************************* \n");
				}
			}
}
	}
}
