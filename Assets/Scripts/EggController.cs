using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour {
	Transform mTransform;
	Rigidbody2D mRigidBody;
	public float jumpForce;
	public Vector3 eggPosOnBasket;
	// Use this for initialization
	void Awake () {
		mTransform = GetComponent<Transform> ();
		mRigidBody = GetComponent<Rigidbody2D> ();
		
	}
	public void  jump(){
		mRigidBody.AddForce (new Vector2 (0, jumpForce));
	}
	void Update () {
		//checking the mouse click or touch
		if (Input.GetMouseButtonDown (0)) {
			jump ();
		}
	}
	void OnBecameInvisible(){
		
		GameManager.Instance.resetEgg (gameObject);
	}


}
