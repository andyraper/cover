using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coverObject : MonoBehaviour {

    GameObject cube;
    List<GameObject> children = new List<GameObject>();

	// Use this for initialization
	void Start () 
    {
        cube = gameObject;
	}
	
	// Update is called once per frame
	void Update () 
    {
		
	}

    void GetChildren()
    {
        foreach(Transform child in transform.parent)
        {
            children.Add(child.gameObject);
        }
    }
}
