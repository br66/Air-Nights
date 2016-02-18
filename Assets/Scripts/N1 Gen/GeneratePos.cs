using UnityEngine;
using System.Collections;

public class GeneratePos : MonoBehaviour 
{
	public	GameObject[]	obj;
	public	float			spawnMin = 1f;
	public	float			spawnMax = 2f;

	public	float			randomYPositionMin = 0f;
	public	float			randomYPositionMax = 0f;

	private	float			randomY = 0f;

	private	Vector3			randomPos;

	public	PlayerInformation playerInfo;
	public	int	nightsForm;
	
	// Use this for initialization
	void Start () 
	{
		Spawn ();
	}
	

	void Update()
	{
		nightsForm = playerInfo.nightsForm;
	}

	// Update is called once per frame
	void Spawn () 
	{
		nightsForm = playerInfo.nightsForm;
		randomY = Random.Range (randomYPositionMin, randomYPositionMax);
		randomPos = new Vector3 (transform.position.x, transform.position.y + randomY, -1f);

		nightsForm = playerInfo.nightsForm;

		if (nightsForm == 1)
		{
			Instantiate(obj[Random.Range(0, obj.GetLength(0))], randomPos, Quaternion.identity);
		}

		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
		nightsForm = playerInfo.nightsForm;

	}

}
