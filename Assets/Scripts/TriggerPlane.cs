using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlane : MonoBehaviour {
	public BoxCollider2D basketCollider;
	public BoxCollider2D triggerCollider;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D collider){
		//while going up
		//disable basket that was holding it
		//check if basket has collider on
		//if yes then ball is going up
		if (basketCollider.isActiveAndEnabled) {
			//inital holder of ball
			basketCollider.enabled = false;
			triggerCollider.enabled = false;
		} else {
		//destination of ball
			basketCollider.enabled=true;
		}
	}
}
