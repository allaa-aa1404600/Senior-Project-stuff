using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceToFire : MonoBehaviour {

    public Transform other;
    public Text distanceText;

	// Use this for initialization
	void Start () {
        
    	}
	
	// Update is called once per frame
	void Update () {

        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            //print("Distance to other: " + dist);
            distanceText.text = "Distance from the fire: " + dist.ToString("#.##")+"m";
        }
		
	}
}