using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour 
{
	public Transform player;

	public float margin = 0f;
	public float smoothness = 0f;
	public Vector2 minimumXY;
	public Vector2 maximumXY;

	// Use this for initialization
	void Start () 
	{
	
	}

	bool CheckYMargin()
	{
		return Mathf.Abs(transform.position.y - player.position.y) > margin;
	}

	void FixedUpdate () 
	{
		TrackPlayer();

		transform.position = new Vector3 (player.position.x + 17, transform.position.y, -10);
	}

	void TrackPlayer ()
	{
		float targetY = transform.position.y;
		
		// If the player has moved beyond the y margin...
		if(CheckYMargin())
			// ... the target y coordinate should be a Lerp between the camera's current y position and the player's current y position.
			targetY = Mathf.Lerp(transform.position.y, player.position.y, smoothness * Time.deltaTime);
		targetY = Mathf.Clamp(targetY, minimumXY.y, maximumXY.y);
		
		// Set the camera's position to the target position with the same z component.
		transform.position = new Vector3(transform.position.x, targetY, transform.position.z);
	}
}
