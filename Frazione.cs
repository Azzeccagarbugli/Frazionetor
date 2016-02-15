using System;

namespace Frazionetor
{
	public class Frazione
	{
		private long numeratore = 1;
		private long denominatore = 1;

		public Frazione (long n, long d)
		{
			numeratore = n;
			denominatore = d;
		}

		public void Semplifica ()
		{
			long i;
			if (numeratore > denominatore) 
			{
				i = numeratore;
			} 
			else 
			{
				i = denominatore;
			}


			while(i>0)
			{
				if (numeratore % i == 0 && denominatore % i == 0) 
				{
					numeratore = numeratore / i;
					denominatore = denominatore / i;

					if (numeratore != numeratore / i && denominatore != denominatore / i)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine ("\nLa frazione semplificata è: {0}/{1}\n", numeratore, denominatore);
					} 
					else 
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine ("\nLa frazione non può essere semplificata\n");
					}
					break;
				} 
				i--;
			}

		}
	}
}

