using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour 
{

	// Use this for initializ
	void Start () 
	{
	
	}
	
	// Update is called once per fram
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Respawn")
		{
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "Obstacle")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Checkpoint")
		{
			Destroy(other.gameObject);
		}
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Respawn")
		{
			Destroy (other.gameObject);
		}
		if (other.gameObject.tag == "Obstacle")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
		if (other.gameObject.tag == "Checkpoint")
		{
			Destroy(other.gameObject);
		}
	}
}
