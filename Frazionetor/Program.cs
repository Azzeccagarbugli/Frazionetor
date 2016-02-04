﻿using System;

namespace Frazionetor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Title = "FRAZIONETOR 0.1";

			//Console.SetWindowSize(45, 14);

			Frazione Fraz;

			do {
				Console.ForegroundColor = ConsoleColor.Cyan;
				Console.WriteLine ("\n _____ ____      _     ________ ___  _   _ _____ _____ ___  ____     ___   _ \n|  ___|  _ \\    / \\   |__  /_ _/ _ \\| \\ | | ____|_   _/ _ \\|  _ \\   / _ \\ / |\n| |_  | |_) |  / _ \\    / / | | | | |  \\| |  _|   | || | | | |_) | | | | || |\n|  _| |  _ <  / ___ \\  / /_ | | |_| | |\\  | |___  | || |_| |  _ <  | |_| || |\n|_|   |_| \\_\\/_/   \\_\\/____|___\\___/|_| \\_|_____| |_| \\___/|_| \\_\\  \\___(_)_|\n                                                                             \n\n");
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine ("Inserisci il numeratore: ");
				long n = int.Parse (Console.ReadLine ());
				Console.WriteLine ("Inserisci il denominatore: ");
				long d = int.Parse (Console.ReadLine ());
				Fraz = new Frazione (n, d);
				Fraz.Semplifica ();
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine("Premi ENTER per un'altra semplificazione...\n");
				Console.ReadKey();
				Console.ForegroundColor = ConsoleColor.White;
				Console.Clear();
			} 
			while(true);

		}
	}
}