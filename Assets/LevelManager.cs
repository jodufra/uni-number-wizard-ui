using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour
{

	public void LoadLevel (string name)
	{
		Debug.Log ("Load level requested: " + name);
		Application.LoadLevel (name);
	}
	
	public void RequestQuit ()
	{
		Debug.Log ("Quit game requested");
		Application.Quit ();
	}
	
}
