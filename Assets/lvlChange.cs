using UnityEngine;
using System.Collections;

public class lvlChange : MonoBehaviour 
{
	public PlayerInformation playerInfo;

	public int nightsForm;

	//obstacle spawners
	public GameObject obstacleSp1;
	//public GameObject obstacleSp2;
	//public GameObject obstacleSp3;
	//public GameObject obstacleSp4;

	//enemy spawners
	public GameObject enemySp1;
	public GameObject enemySp2;
	//public GameObject enemySp3;
	//public GameObject enemySp4;

	//public GeneratePos gpos;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		nightsForm = playerInfo.nightsForm;

		//if (nightsForm == 1)
		//{
			//obstacleSp1.SetActive(true);
			//enemySp1.SetActive(true);
			//enemySp2.SetActive(false);
		//}

		//if (nightsForm == 2)
		//{
			//enemySp2.SetActive(true);
			//obstacleSp1.SetActive(false);
			//enemySp1.SetActive(false);

		//}
	}
}
