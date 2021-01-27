using System;
using System.Collections.Generic;

public class Program 
{
	public static bool IsValidSubsequence(List<int> array, List<int> sequence) 
  	{
		// Write your code here.
		int index = 0;
		int arraySize = 0;
		List<bool> allFound = new List<bool>();
		List<int> foundAtIndex = new List<int>();
		
		
		for (int i = 0; i < sequence.Count; i++)
		{
				for (int j = i; j < array.Count; j++)
				{
						if ((i == j || j > i) && sequence[i] == array[j] && !foundAtIndex.Contains(j))
						{
								allFound.Add(true);
								foundAtIndex.Add(j);
								break;
						}
				}
		}		
		return allFound.Count == sequence.Count;
	}
}
