using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

// To get around Unity randomly deleting objects while in-game paused.
// Orig. RemoveSelf script seems to be the culprit.
public class RemoveSelfII : MonoBehaviour
{
    public int timeBeforeDestroyingSelf;

    private GameInfo game;
    private bool foundGameObject;

    // Use this for initialization
    void Start ()
    {
        foundGameObject = false;

        timeBeforeDestroyingSelf = 10;

        if (gameObject.name == "N3 Rain")
            timeBeforeDestroyingSelf = 15;

        FindGameInfoScript();

        StartCoroutine("countdownToDestroy");
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
	    if (timeBeforeDestroyingSelf == 0)
        {
            Destroy(gameObject);
        }

        if (this.transform.childCount == 0)
        {
            if (!game.paused)
                Destroy(this.gameObject);
        }
    }

    IEnumerator countdownToDestroy()
    {
        if (game.paused)
        {
            timeBeforeDestroyingSelf = 10;

            if (gameObject.name == "N3 Rain(Clone)")
                timeBeforeDestroyingSelf = 15;
        }


        if (!game.paused)
            timeBeforeDestroyingSelf--;
        yield return new WaitForSeconds(1.0f);

        StartCoroutine("countdownToDestroy");
    }
}
