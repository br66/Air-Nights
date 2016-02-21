using UnityEngine;
using System.Collections;

public class lvlChange : MonoBehaviour 
{
	public PlayerInformation playerInfo;

	private int nightsForm;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		nightsForm = playerInfo.nightsForm;
	}
}
