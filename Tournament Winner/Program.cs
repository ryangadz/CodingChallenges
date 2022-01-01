using System.Collections.Generic;
using System;
using System.Collections;

public class Program {

	public string TournamentWinner(List<List<string> > competitions, List<int> results) {
		// Write your code here.
		int count = competitions.Count;
		Dictionary<string, int> winners = new Dictionary<string, int>(); 
		string winner = ""; 
	//	winners.Add("foo", 1); 

		//	Console.WriteLine(winners["foo"]);
		for (int i = 0; i < count; i++)
		{
			List<string> comp = competitions[i]; 
			string roundWinner; 
			if (results[i] == 1)
				roundWinner = comp[0]; 
			else roundWinner = comp[1]; 
			if (i == 0 ) winner = roundWinner;
			Console.WriteLine(roundWinner);
			if (!winners.ContainsKey(roundWinner))
				winners[roundWinner] = 0; 
			else winners[roundWinner] = winners[roundWinner] + 1; 
		}
		
		int topScore = 0; 

		foreach(KeyValuePair<string,int> w in winners)
		{			 
			if (w.Value > topScore)
			{
				topScore = w.Value; 
				winner = w.Key; 
			}

		}
		return winner;
	}

}
