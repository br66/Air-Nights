using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class showScore : MonoBehaviour
{
    public Text score;

    // Use this for initialization
    void Start ()
    {
        if (PlayerPrefs.HasKey("Your Score "))
            score.text = " " + PlayerPrefs.GetFloat("Your Score ");
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
}
