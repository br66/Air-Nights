using UnityEngine;
using System.Collections;

public class ColorChanger : MonoBehaviour 
{
	public PlayerInformation playerInfo;
	public int nightsForm;
	public SpriteRenderer filter;

	public Color color1;
	public Color color2;
	public Color color3;
	public Color color4;

	// Use this for initialization
	void Start () 
	{
		//nightsForm = playerInfo.nightsForm;
	}
	
	// Update is called once per frame
	void Update () 
	{
		nightsForm = playerInfo.nightsForm;

		if (nightsForm == 1)
		{
			filter.color = color1;
		}
		
		if( nightsForm == 2)
		{
			filter.color = color2;
		}
		
		if(nightsForm == 3)
		{
			filter.color = color3;
		}
		
		if(nightsForm == 4)
		{
			filter.color = color4;
		}
	}
}
