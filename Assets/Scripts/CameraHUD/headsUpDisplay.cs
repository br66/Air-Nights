using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class headsUpDisplay : MonoBehaviour 
{
	public	Text	health;
	public	Text	score;
	public	Text	time;
	public	Text	nightsForm;

	public	PlayerInformation playerInfo;
	// Use this for initialization
	void Start () 
	{
		health.text = "h " + playerInfo.health;
		score.text = "s " + playerInfo.score;
		time.text = "t " + playerInfo.time; 
		nightsForm.text = "nf " + playerInfo.nightsForm;
	}
	
	// Update is called once per frame
	void Update () 
	{
		health.text = "HEALTH || " + playerInfo.health;
		score.text = "SCORE || " + playerInfo.score;
		time.text = "TIME || " + playerInfo.time; 
		nightsForm.text = "NIGHT || " + playerInfo.nightsForm;
	}
}
