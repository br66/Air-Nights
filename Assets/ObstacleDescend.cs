using UnityEngine;
using System.Collections;

public class ObstacleDescend : MonoBehaviour 
{
	private Transform obstacle;

	public float gravity;
	public float resistance;

	// Use this for initialization
	void Start () 
	{
		obstacle = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		obstacle.position += Vector3.down * gravity;
		obstacle.position += Vector3.right * resistance;
	}
}
