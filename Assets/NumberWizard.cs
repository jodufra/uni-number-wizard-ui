using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour
{

	int min, max, guess;
	
	public int maxGuessesAllowed = 5;
	public Text text;

	// Use this for initialization
	void Start ()
	{
		min = 1;
		max = 1000;
		UpdateGuess ();
	}
	
	void UpdateGuess ()
	{
		guess = Random.Range (min, max + 1);
		text.text = guess.ToString ();
	}
	
	void NextGuess ()
	{
		UpdateGuess ();
		
		maxGuessesAllowed--;
		if (maxGuessesAllowed == 0) {
			UserWins ();
		}
	}
		
	public void GuessHigher ()
	{
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower ()
	{
		max = guess;
		NextGuess ();
	}
	
	public void UserWins ()
	{
		Application.LoadLevel ("Win");
	}
	
	public void UserLoses ()
	{
		Application.LoadLevel ("Lose");		
	}
	
}
