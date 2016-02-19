using UnityEngine;
using System.Collections;

public class PlayerInformation : MonoBehaviour 
{
	public float score;
	public float time;
	public int nightsForm;
	public int health;

	public	float lastTime;
	public	float timeLimit;
	public	float addScore;
	public float currencyLimit;

	//public SpriteRenderer filter;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine ("timerDecrease");
		StartCoroutine ("scoreIncrease");
	}
	
	// Update is called once per fram
	void Update () 
	{
		//score++;

		if (nightsForm == 1)
		{
			timeLimit = 15;
			//time = timeLimit - 15;
			currencyLimit = 10;
		}

		if( nightsForm == 2)
		{
			timeLimit = 20;
			//time = timeLimit - 15;
			currencyLimit = 15;
		}

		if(nightsForm == 3)
		{
			timeLimit = 25;
			//time = timeLimit - 15;
			currencyLimit = 20;
		}

		if(nightsForm == 4)
		{
			timeLimit = 30;
			//time = timeLimit - 15
			currencyLimit = 25;
		}

		if (time > timeLimit)
		{
			time = timeLimit;
		}

		if (time <= 0)
		{
			if (nightsForm > 1)
			{
				nightsForm--;
				time = currencyLimit - 5;
			}
		}

		if(health <= 0)
		{
			//if (nightsForm > 1)
			//{
			//	time = timeLimit; //reset time
			//	health = 100; //reset health
			//	nightsForm--; //lower for
			//}
			//else
			//{
				health = 0;
				//Debug.Log("GAME OVER");
				Application.LoadLevel("death_test");
			//}
		}

		if(time <= 0)
		{
			if (nightsForm > 1)
			{
				nightsForm--;
			}
			if (nightsForm == 1)
			{
				Debug.Log("GAME OVER");
				Application.LoadLevel("death_test");
			}
		}

		if (Input.GetKeyDown(KeyCode.RightShift))
		{
			if (time > currencyLimit)
			{
				if (nightsForm != 4)
				{
					time -= currencyLimit;
					nightsForm++;
					//Debug.Log(nightsForm);
				}
			}
		}
	}

	IEnumerator timerDecrease ()
	{
		time--;
		yield return new WaitForSeconds (1f);
		StartCoroutine ("timerDecrease");
	}

	IEnumerator scoreIncrease()
	{
		score += 100;
		yield return new WaitForSeconds (5f);
		StartCoroutine ("scoreIncrease");
	}
}
