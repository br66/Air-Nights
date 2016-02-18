using UnityEngine;
using System.Collections;

public class GenerateN2 : MonoBehaviour 
{
	public	GameObject[]	obj;
	public	float			spawnMin = 1f;
	public	float			spawnMax = 2f;

	// Use this for initialization
	void Start () 
	{
		Spawn ();
	}
	
	// Update is called once per frame
	void Spawn () 
	{
		Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
