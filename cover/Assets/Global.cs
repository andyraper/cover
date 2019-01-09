using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Global : MonoBehaviour 
{

    public List<GameObject> SafeCoverAreas = new List<GameObject>();

	// Use this for initialization
	void Start () 
    {
        PopulateSafeCoverAreaList();
	}
	
	// Update is called once per frame
	void Update () {
        PopulateSafeCoverAreaList();
	}

    void PopulateSafeCoverAreaList()
    {
        SafeCoverAreas.Clear();

        var coverAreas = GameObject.FindGameObjectsWithTag("CoverArea");

        foreach (var ca in coverAreas)
        {
            if (ca.GetComponent<CoverArea>().IsSafe)
                SafeCoverAreas.Add(ca);
        }
    }
}
