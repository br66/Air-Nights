using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ObstacleRotate : MonoBehaviour 
{
	public	float			randomRotateMin = 0f;
	public	float			randomRotateMax = 0f;

	public	float			randomRotateResult = 0f;

	public	float			rotation = 0f;

    private int existenceTime = 20;

    private GameInfo game;
    private bool foundGameObject;

	// Use this for initialization
	void Start () 
	{
        foundGameObject = false;

        randomRotateResult = Random.Range (randomRotateMin, randomRotateMax);

        Invoke("Destroy", existenceTime);
        //Destroy (gameObject, 20f);

        FindGameInfoScript();
    }

    // needed to find the object in the heirachy called 'game' which gives the player the ability to pause the game
    void FindGameInfoScript()
    {
        if (SceneManager.GetActiveScene().isLoaded) // if the current scene has finished loading
        {
            if (GameObject.Find("Game") == null)
                Debug.Log(this.gameObject.name + " could not find the 'game' object in the heirarchy.");
            else
            {
                game = GameObject.Find("Game").GetComponent<GameInfo>();
                //Debug.Log(this.gameObject.name + " found the 'game' object.");
                foundGameObject = true;
            }
        }
    }

    // Update is called once per frame
    void Update () 
	{
        if (!game.paused)
        {
            transform.Rotate(Vector3.forward * randomRotateResult * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, -1f);
        }
        else
            CancelInvoke("Destroy");

        if (game.paused)
            WaitingForUnpaused();

    }

    void Destroy()
    {
        if (!game.paused)
            Destroy(gameObject, existenceTime);
    }

    void WaitingForUnpaused()
    {
        if (!game.paused)
        {
            Invoke("Destroy", existenceTime);
            //Debug.Log("game is unpaused");
        }
    }
}
