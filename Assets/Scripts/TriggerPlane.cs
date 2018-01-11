using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerPlane : MonoBehaviour {
	public BoxCollider2D basketCollider;
	public BoxCollider2D triggerCollider;
	// Use this for initialization
	public void resetPlane(){
		triggerCollider.enabled = true;
	}
	void OnTriggerEnter2D(Collider2D collider){
		//triggers while going up
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
