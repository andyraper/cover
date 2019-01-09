using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoverArea : MonoBehaviour {

    public bool IsSafe { get; set; }
    public bool isOccupied { get; set; }

    Material m_Material;

    // Use this for initialization
    void Start()
    {
        //Fetch the Material from the Renderer of the GameObject
        m_Material = GetComponent<Renderer>().material;
        IsSafe = true;
    }

	
	// Update is called once per frame
	void Update () 
    {
        SetMaterial();
	}

    void SetMaterial()
    {
        var green = Color.green;
        var yellow = Color.yellow;
        var red = Color.red;

        if(IsSafe)
        {
            if(isOccupied)
            {
                yellow.a = 0.5f;
                m_Material.color = yellow;
                return;
            }

            green.a = 0.5f;
            m_Material.color = green;
            return;
        }

        red.a = 0.5f;
        m_Material.color = red;
    }
}
