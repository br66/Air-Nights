using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour
{
    public bool paused;
    public GameObject particles;

	// Use this for initialization
	void Start ()
    {
        paused = false;
	}
	
	// Update is called once per frame
	void Update () 
	{
        particles.SetActive(!paused);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            paused = !paused;
        }
    }
}
