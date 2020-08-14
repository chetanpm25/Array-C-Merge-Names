using System;

public class MergeNames
{
    public static string[] UniqueNames(string[] names1, string[] names2)
	{
		string[] result = new string[names1.Length + names2.Length];
		int numUnique = 0;

		for(int i = 0; i < names1.Length; i++) 
		{
			string name = names1[i];
			bool duplicate = false;

			for(int j = 0; j < numUnique; j++) 
			{
				if(name == result[j]) 
				{
					duplicate = true;
					break;
				}
			}

			if(!duplicate)
				result[numUnique++] = name;
		}

		for(int i = 0; i < names2.Length; i++) 
		{
			string name = names2[i];
			bool duplicate = false;

			for(int j = 0; j < numUnique; j++) 
			{
				if(name == result[j]) 
				{
					duplicate = true;
					break;
				}
			}

			if(!duplicate)
				result[numUnique++] = name;
		}

		string[] trimmedResult = new string[numUnique];

		for(int i = 0; i < numUnique; i++)
			trimmedResult[i] = result[i];

		return trimmedResult;
	}
    
    public static void Main(string[] args)
    {
        string[] names1 = new string[] {"Ava", "Emma", "Olivia"};
        string[] names2 = new string[] {"Olivia", "Sophia", "Emma"};
        Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
    }
}