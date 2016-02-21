using UnityEngine;
using System.Collections;

public class Generate : MonoBehaviour 
{
	public	GameObject[]	obj;
	public	float			spawnMin = 1f;
	public	float			spawnMax = 2f;

    public float randomYPositionMin = 0f;
    public float randomYPositionMax = 0f;

    private float randomY = 0f;
    
    private Vector3 randomPos;

    public GameInfo game;

    // Use this for initialization
    void Start () 
	{
		Spawn ();
	}
	
	// Update is called once per frame
	void Spawn () 
	{
        if (!game.paused)
        {
            randomY = Random.Range(randomYPositionMin, randomYPositionMax);

            randomPos = new Vector2(transform.position.x, transform.position.y + randomY);

            Instantiate(obj[Random.Range(0, obj.GetLength(0))], randomPos, Quaternion.identity);
        }
		Invoke ("Spawn", Random.Range (spawnMin, spawnMax));
	}
}
