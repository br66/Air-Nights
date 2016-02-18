using UnityEngine;
using System.Collections;

public class ScrollInfinite : MonoBehaviour 
{
	MeshRenderer mr; //OMG FISTTIME USING MESH RENDER
	Material mat; //or mr.materials[0]
	Vector2 offset;
	public float backgroundSlowdown;

	// Use this for initialization
	void Start () 
	{
		mr = GetComponent<MeshRenderer> ();
		mat = mr.material;
		offset = mat.mainTextureOffset;
	}
	
	// Update is called once per frame
	void Update () 
	{
		offset.x += Time.deltaTime/backgroundSlowdown;

		mat.mainTextureOffset = offset;
	}
}
