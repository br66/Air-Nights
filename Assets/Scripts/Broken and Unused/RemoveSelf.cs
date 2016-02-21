using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RemoveSelf : MonoBehaviour 
{
	private int existenceTime = 5;

    private GameInfo game;
    private bool foundGameObject;

    // Use this for initialization
    void Start () 
	{
        foundGameObject = false;

        Invoke("Destroy", existenceTime);

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
        if (game.paused)
            CancelInvoke("Destroy");

        if (game.paused)
            WaitingForUnpaused();

        if (this.transform.childCount == 0)
        {
            if (!game.paused)
                Destroy(this.gameObject);
        }
    }

    void Destroy()
    {  
        if (!game.paused)
            Destroy(this.gameObject, existenceTime);
    }

    void WaitingForUnpaused()
    {
        if (!game.paused)
            Invoke("Destroy", existenceTime);
    }
}
