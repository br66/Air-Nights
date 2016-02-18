using UnityEngine;
using System.Collections;

public class RemoveSelf : MonoBehaviour 
{
	private int existenceTime = 5;

	// Use this for initialization
	void Start () 
	{
		Destroy (gameObject, existenceTime);
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}
