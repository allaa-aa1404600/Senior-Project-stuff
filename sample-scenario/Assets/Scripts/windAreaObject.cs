﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windAreaObject : MonoBehaviour {

//	public float lifeTime=10f;
//	public bool inWindZone=false;
//	public GameObject windZone;
//	Rigidbody rb;
//	// Update is called once per frame
//	private void Start(){
//		rb = GetComponent<Rigidbody> ();
//	}
//	void Update () {
//		if (lifeTime > 0) {
//			lifeTime -= Time.deltaTime;
//			if (lifeTime <= 0) {
//				Destruction ();
//			}
//		
//		}
//		if (this.transform.position.y <= -20) {
//			Destruction ();
//		}
//	}
//	private void FixedUpdate(){
//		if (inWindZone) {
//			rb.AddForce(windZone.GetComponent<WindArea>().direction * windZone.GetComponent<WindArea>().strength);//
//		}
//	}
//	void OnTriggerEnter(Collider coll){
//		if (coll.gameObject.tag == "windArea") {
//			windZone = coll.gameObject;
//			inWindZone = true;
//		}
//	}
//	void OnTriggerExit(Collider coll){
//		if (coll.gameObject.tag == "windArea") {
//			windZone = coll.gameObject;
//			inWindZone = false;
//		}
//	}
//
//	void onCollisionEnter(Collision coll)
//	{
//		if (coll.gameObject.name == "destroyer") {
//			Destruction ();
//		}
//	}
//	void Destruction(){
//		Destroy (this.gameObject);
//	}
}
