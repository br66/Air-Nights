﻿using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ScrollInfinite : MonoBehaviour 
{
	MeshRenderer mr;
	Material mat;
	Vector2 offset;
	public float backgroundSlowdown;

    private GameInfo game;
    private bool foundGameObject;

	// Use this for initialization
	void Start () 
	{
        foundGameObject = false;

		mr = GetComponent<MeshRenderer> ();
		mat = mr.material;
		offset = mat.mainTextureOffset;

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
		    offset.x += Time.deltaTime/backgroundSlowdown;

		mat.mainTextureOffset = offset;
	}
}
