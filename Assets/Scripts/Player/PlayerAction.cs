using UnityEngine;
using System.Collections;

public class PlayerAction : MonoBehaviour 
{
	private string ver = "Vertical";

	public float horizontalSpeed = 0f;
	public float verticalSpeed = 0f;

	public PlayerInformation playerInfo;
    public GameInfo game;

	// Use this for init
	void Start () 
	{
	
	}

	// Update is called once per frame
	void FixedUpdate () 
	{
        if (!game.paused)
        {
            //Debug.Log (Time.timeScale);
            transform.position += new Vector3(0f, verticalSpeed * Input.GetAxis(ver), 0f);
            //GetComponent<Rigidbody2D>().AddForce(transform.right * horizontalSpeed);
            GetComponent<Rigidbody2D>().velocity = transform.right * horizontalSpeed;
            if (transform.position.y > 10)
                transform.position = new Vector2(transform.position.x, 10.0f);
            if (transform.position.y < -19)
                transform.position = new Vector2(transform.position.x, -19.0f);

            //rigidbody2D.AddForce (transform.up * Input.GetAxis (ver) * verticalSpeed);
        }
        if (game.paused)
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
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

			playerInfo.time += 5f;
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
