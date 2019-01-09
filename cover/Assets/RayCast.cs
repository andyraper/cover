using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void Update()
    {
        RaycastHit hitPoint;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hitPoint, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100f, Color.yellow);
            if (hitPoint.collider.tag == "CoverArea")
            {
                Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitPoint.distance, Color.yellow);
                hitPoint.transform.GetComponent<CoverArea>().IsSafe = false;
                Debug.Log("Hit");
            }
        }
    }
}
