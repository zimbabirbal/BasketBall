using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using System;
[RequireComponent(typeof(BasketManager))]
public class GameManager : MonoBehaviour {
	public int turnsForPlayer;
	private static GameManager instance=null;
	BasketManager basketManager;
	public static GameManager Instance{
		get{
			if (instance == null) {
				instance = GameObject.FindGameObjectWithTag ("GameController").AddComponent<GameManager> ();
			}
				return instance;
		}

	}
	void Awake(){
		if ((instance) && instance.GetInstanceID () != GetInstanceID ()) {
			DestroyImmediate (instance);
		}
		else{
		instance = this;
		DontDestroyOnLoad(gameObject);
		}
	}
	// Use this for initialization
	void Start () {
		basketManager = gameObject.GetComponent<BasketManager> ();

	}
	public void updateEggIndexOfBasket(){
		basketManager.updateBasketNoForEgg ();
	}
	public void updateBasketPosition(){
		basketManager.updateBasketPosition ();
	}

	public void resetEgg(GameObject eggObject){
		if (basketManager == null) {
			Debug.Log ("null");
		}
		basketManager.resetEgg (eggObject);
	}

}
