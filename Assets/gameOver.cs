using UnityEngine;
using System.Collections;

public class gameOver : MonoBehaviour 
{

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey(KeyCode.Escape))
		{
            PlayerPrefs.DeleteAll();
			Application.Quit();
		}

		if (Input.GetKey(KeyCode.R))
		{
            PlayerPrefs.DeleteAll();
			Application.LoadLevel("test");
		}
	}
}
