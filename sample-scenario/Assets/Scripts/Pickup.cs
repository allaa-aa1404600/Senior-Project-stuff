using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class Pickup : MonoBehaviour 
{
	public GameObject onhand;
	private Rigidbody rb;
	public GameObject bloom;
//	private int count;
//	public Text CountText;
	// Use this for initialization
	void Start ()
	{
//		rb = GetComponents<Rigidbody> ();
		rb= GetComponent<Rigidbody>();
//		count = 0;
//		SetCountText ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnMouseDown()
	{
		bloom.SetActive (false);
		rb.useGravity = false;
		rb.transform.position = onhand.transform.position;
		rb.transform.parent = GameObject.Find ("FirstPersonController").transform;
		rb.transform.parent = GameObject.Find ("FirstPersonCharacter").transform;
	}
	void OnMouseUpAsButton()
	{
		
//		rb.transform.position = onhand.transform.position;
		rb.transform.parent = null;
		rb.useGravity = true;
		bloom.SetActive (true);
//		count = count + 1;
//		SetCountText ();

	}
//	void SetCountText ()
//	{
//		CountText.text = "Count: " + count.ToString ();
//		if (count >= 5)
//		{
////			winText.text = "You Win!";
//		}
//	}
}
