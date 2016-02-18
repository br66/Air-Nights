using UnityEngine;
using System.Collections;

public class ObstacleRotate : MonoBehaviour 
{
	public	float			randomRotateMin = 0f;
	public	float			randomRotateMax = 0f;

	public	float			randomRotateResult = 0f;

	public	float			rotation = 0f;

	// Use this for initialization
	void Start () 
	{
		randomRotateResult = Random.Range (randomRotateMin, randomRotateMax);
		Destroy (gameObject, 20f);
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.Rotate(Vector3.forward* randomRotateResult * Time.deltaTime);
		//Vector3 rotate =
		transform.position = new Vector3 (transform.position.x, transform.position.y, -1f);

	}
}
