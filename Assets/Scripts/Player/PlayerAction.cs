using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour 
{
	private string ver = "Vertical";

	public float horizontalSpeed = 0f;
	public float verticalSpeed = 0f;

	public PlayerInformation playerInfo;

	public bool Pause = false;

	// Use this for init
	void Start () 
	{
	
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		//Debug.Log (Time.timeScale);
		transform.position += new Vector3 (0f, verticalSpeed * Input.GetAxis (ver), 0f);
		GetComponent<Rigidbody2D>().AddForce (transform.right * horizontalSpeed);

		//rigidbody2D.AddForce (transform.up * Input.GetAxis (ver) * verticalSpeed);
		
		
		if (Input.GetKey(KeyCode.Space))
		{
			Pause = !Pause;
			Time.timeScale = Pause ? 0 : 1; //ternary operators?
		}

		/*if (Input.GetKeyDown("p"))
		{
			if (Time.timeScale != 0)
			{
				Time.timeScale = 0;
			}
			else if (Time.timeScale == 0)
			{
				Time.timeScale = 1;
			}
		}*/
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if (col.gameObject.tag == "Obstacle")
		{
			Destroy(col.gameObject);
			playerInfo.health -= 5;
		}

		if (col.gameObject.tag == "Enemy")
		{
			Destroy(col.gameObject);
			playerInfo.health -= 10;
		}

		if (col.gameObject.tag == "Checkpoint")
		{
			Destroy(col.gameObject);

			playerInfo.lastTime = playerInfo.time;
			playerInfo.addScore = playerInfo.timeLimit - playerInfo.lastTime;

			playerInfo.score += playerInfo.addScore;

			playerInfo.time += 10f;
		}
	}

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag == "Obstacle")
		{
			Destroy(col.gameObject);
			playerInfo.health -= 5;
		}
	}
}
