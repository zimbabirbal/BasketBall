using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
	EggController mEggController;
	// Use this for initialization
	void Start () {
		mEggController = FindObjectOfType<EggController> ();
	}
	public void jump(){
		mEggController.jump ();
	}

}
