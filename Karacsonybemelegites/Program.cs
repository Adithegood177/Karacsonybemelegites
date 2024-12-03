namespace Karacsonybemelegites
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
            Console.WriteLine("Csá from mikula segito");
            Console.WriteLine("help mikula mennyi kiddo sigma");

			int jogyerekekSzama = 0;
			bool siker = false;

			while (!siker) 
			{
                Console.WriteLine("Add meg a jó gyerekek számát");
				string input = Console.ReadLine();

				try
				{
					jogyerekekSzama = Convert.ToInt32(input);

					if (jogyerekekSzama < 0)
					{
						throw new Exception("A jó gyerekek száma nem lehet negatív");
					}
					siker = true;

				}
				catch (OverflowException)
				{
                    //2,147,483,647 a maximális szám
                    Console.WriteLine("Túl léptük a keretet");
                }
				catch(FormatException)
				{
                    Console.WriteLine("Hiba: Csak számokat adhatsz meg! ");
                }
				catch (Exception ex)
				{ Console.WriteLine($"Hiba: {ex.Message}"); 

				}
                Console.WriteLine("Köszi");

            }
			*/


			Console.WriteLine("Adj nevet: ");
			string nev = Console.ReadLine();

            Console.WriteLine($"Hány ajándékot kapjon {nev}?");
			try { 
				int ajandekSzam = Convert.ToInt32(Console.ReadLine());
				if (ajandekSzam < 0)
					throw new Exception("Az ajándékok száma nem lehet negativ");
				Console.WriteLine($"{nev} {ajandekSzam} ajandekot fog kapni");
			} 
			catch (FormatException)
			{
                Console.WriteLine("Csak számot lehet megadni");
            }
			catch (Exception ex) 
			{ Console.WriteLine($"Hiba: {ex.Message}"); }

        }
	}
}
