namespace Karacsonybemelegites
{
	internal class Program
	{
		static void Main(string[] args)
		{
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
				catch(FormatException)
				{
                    Console.WriteLine("Hiba: Csak számokat adhatsz meg! ");
                }
				catch (Exception ex)
				{ Console.WriteLine($"Hiba: {ex.Message}"); 

				}
                Console.WriteLine("Köszi");

            }
        }
	}
}
