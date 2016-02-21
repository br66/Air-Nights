using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MoveLeft : MonoBehaviour
{
    private Transform obstacle;
    public float resistance;

    private GameInfo game;
    private bool foundGameObject;

    // Use this for initialization
    void Start ()
    {
        foundGameObject = false;

        obstacle = GetComponent<Transform>();

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
            obstacle.position += Vector3.right * resistance;
        }
    }
}
