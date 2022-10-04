using System;
					
public class Program
{
	
	static char[] Algebra = new char[27] {' ','A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'};

	public static void Main()
	{
		//input
		System.Console.WriteLine("Write a Plainetext");
string PlainText = Console.ReadLine();
System.Console.WriteLine("Write a key word");
string Key = Console.ReadLine();
char [] cipher = new char[PlainText.Length];
int i = 0;
int iForKey = 0;
		//Cipher
while (PlainText != null && Key != null)
{
	if (iForKey>Key.Length-1)
	{
		iForKey=0;
	}
	if (i == cipher.Length)
	{
		break;
	}
	else
	{
	//Defining a letter
   int sum = GetIndexOfLatter(PlainText[i]) +  GetIndexOfLatter(Key[iForKey]);
		if(sum> 27)
		{
			sum -= 27;
		}
		else
		{sum-=1;}
   cipher[i] = Algebra[sum];
   }
   
iForKey++;
 i++;
}
		Console.WriteLine(cipher);

	}
	//Finding an index
	static int GetIndexOfLatter(char Letter)
{
    for(int i=0;i <26;i++)
    {
        if (Letter == Algebra[i])
        {
            return i;
        }
    }
    return 0;
}
}
