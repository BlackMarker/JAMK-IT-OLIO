using System;
/// <summary>
/// A simple example of Blackjack card game
/// </summary>
namespace JAMK.IT
{
	class BlackJack
	{
		static void Main() {

			while (true) {
				//Arvotaan talon numero
				Random Arvonta = new Random();
				int myNumber = Arvonta.Next(10, 21);
				//alustetaan pelaajan numero
				int theirNumber;
				System.Console.WriteLine("*** BlackJack! ***");
				//Kysytään ja tallennetaan käyttäjältä luku muuttujaan "teksti"
				System.Console.Write("Can you beat my number? Enter any number between 1-21: ");
				string teksti = Console.ReadLine();
				//jos teksti == x --> Suljetaan Ohjelma
				if (teksti == "exit" || teksti == "x") {
					Console.WriteLine("Suljit ohjelman");
					Console.WriteLine();
					break;
				}
				else {
					//Jos ei suljeta ohjelmaa, tarkistetaan voidaanko muuttujaa kääntää int muotoon.
					bool voiko = Int32.TryParse(teksti, out theirNumber);
					if (voiko) {
						theirNumber = System.Convert.ToInt32(teksti);
						if (theirNumber > 0 || theirNumber < 22) {
							if (theirNumber >= myNumber && theirNumber <= 21) {
								System.Console.WriteLine("You win.");
							}
							else {
								System.Console.WriteLine("You lose.");
							}
						}
					}
					else {
						Console.WriteLine("Epakelpo arvo\n");
					}
					

					
					//if (theirNumber   {
					//	Console.WriteLine("The given number is out of limits, try again.");
					//}

				}
			}
		}
	}
}