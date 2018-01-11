using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour {
	public GameObject[] basketPrefabs;
	public int basketNoForEgg;
	public int eachBasketGap;
	Vector3 nextPosition;
	// Use this for initialization
	void Start () {
		basketNoForEgg = 0;
		nextPosition = basketPrefabs [basketPrefabs.Length - 1].transform.position + new Vector3 (0, eachBasketGap, 0);
	}
	public void updateBasketPosition(){
		int basketToMove = basketNoForEgg - 1;
		if (basketToMove < 0) {
			return;
		}
		basketPrefabs [basketToMove].transform.position = nextPosition;
		nextPosition = nextPosition + new Vector3 (0, eachBasketGap, 0);
	}
	public void updateBasketNoForEgg(){
		basketNoForEgg++;
		if(basketNoForEgg>=basketPrefabs.Length){
			//means we are at last array
			//need to go to first
			basketNoForEgg = 0;
		}
	}
	public void resetEgg(GameObject eggPrefab){
		TriggerPlane temp = basketPrefabs [basketNoForEgg].GetComponent<TriggerPlane> ();
		temp.resetPlane ();
		Vector3 pos = basketPrefabs [basketNoForEgg].transform.position;
		eggPrefab.transform.position = new Vector3 (pos.x, pos.y + 3, pos.z);
	}
}
