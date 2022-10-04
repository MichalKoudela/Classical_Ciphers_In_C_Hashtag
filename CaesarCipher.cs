public class Program
{
	public static void Main()
	{
		Again:
		char[] abc = new char[26] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

		Console.WriteLine("Write a key");
		int key = Convert.ToInt32(Console.ReadLine());
        
		if (key >= 26) { Console.Clear(); goto Again; }
		//such number doesnt make sanse in this case

		Console.WriteLine("Write a plaintext you want to encrypt with ceaser, it must be in upper case!");
		string plaintext = Console.ReadLine();
		char[] cipher = new char[plaintext.Length];
		
		if (plaintext != null)
        {
			//Ciphiring process right here!
			for (int i = 0; i <= plaintext.Length - 1; i++)
			{
				for (int y = 0; y <= abc.Length - 1; y++)
				{
					if (plaintext[i] == abc[y])
					{
						int numberDifference = 26 - y;
						if (numberDifference <= key)
						{
							cipher[i] = abc[key - numberDifference];
							break;
						}
						else
						{

							cipher[i] = abc[y + key];
							break;
						}
					}
				}
			}
		}
		else
        {
			Console.Clear();
			goto Again;
        }
		Console.WriteLine("Cipher is: " + cipher);
		Console.ReadKey();
	}

}