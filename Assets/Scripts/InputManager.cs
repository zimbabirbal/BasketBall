using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
	GameManager mGameManager;
	void Start(){
		mGameManager = GetComponent<GameManager> ();
		Debug.Log ("true");
	}
	// Update is called once per frame
	void Update () {
		//checking the mouse click or touch
		if (Input.GetMouseButtonDown (0)) {
			mGameManager.jump ();
		}
	}
}
