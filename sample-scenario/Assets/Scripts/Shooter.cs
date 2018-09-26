using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public Rigidbody bullet;
	public float power = 1500f;
	public float moveSpeed = 2.0f;

	void Start () 
	{
//	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float h = Input.GetAxis ("Mouse X") * Time.deltaTime * moveSpeed;
		float v = Input.GetAxis ("Mouse Y") * Time.deltaTime * moveSpeed;
		transform.Translate (h, v, 0);

		if(Input.GetButtonDown("Fire2"))
		{
			Rigidbody instant = Instantiate (bullet, transform.position, transform.rotation) as Rigidbody;
			Vector3 fwd = transform.TransformDirection (Vector3.forward);
			instant.AddForce (fwd * power);

	}
}

}
