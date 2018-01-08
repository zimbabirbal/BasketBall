using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggController : MonoBehaviour {
	Transform mTransform;
	Rigidbody2D mRigidBody;
	public float jumpheight;
	// Use this for initialization
	void Awake () {
		mTransform = GetComponent<Transform> ();
		mRigidBody = GetComponent<Rigidbody2D> ();
		
	}
	public void  jump(){
		mRigidBody.AddForce (new Vector2 (0, jumpheight));
		//mTransform.position +=new Vector3 (0, jumpheight, 0);
	}


}
