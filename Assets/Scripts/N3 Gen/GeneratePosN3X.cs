using UnityEngine;
using System.Collections;

public class GeneratePosN3X : MonoBehaviour 
{
	public	GameObject[]	obj;
	public	float			spawnMin = 1f;
	public	float			spawnMax = 2f;
	
	public	float			randomXPositionMin = 0f;
	public	float			randomXPositionMax = 0f;
	
	private	float			randomX = 0f;
	
	private	Vector3			randomPos;
	
	public	PlayerInformation playerInfo;
	public	int	nightsForm;

	// Use this for initialization
	void Start ()
	{
		Spawn ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		nightsForm = playerInfo.nightsForm;
	}

	void Spawn () 
	{
		nightsForm = playerInfo.nightsForm;

		randomX = Random.Range (randomXPositionMin, randomXPositionMax);
		randomPos = new Vector3 (transform.position.x + randomX, transform.position.y, -1f);
		
		nightsForm = playerInfo.nightsForm;
		
		if (nightsForm == 3)
		{
			Instantiate(obj[Random.Range(0, obj.GetLength(0))], randomPos, Quaternion.identity);
		}
		
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));

		nightsForm = playerInfo.nightsForm;
		
	}
}
