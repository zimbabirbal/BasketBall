using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketController : MonoBehaviour {

	Transform startingPoint;
	Transform mTransform;
	public GameObject basket;
	List<GameObject> basketList = new List<GameObject> ();
	public int initialBaskets;
	public int basketRowGap;
	void Awake(){
		mTransform = GetComponent<Transform> ();
		for (int i = 0; i < initialBaskets; i++) {
			GameObject temp = Instantiate (basket);
			temp.SetActive (false);
			temp.transform.SetParent (this.transform);
			basketList.Add (temp);
				}
		startingPoint = mTransform;
		Debug.Log ("finish");
	}
	// Use this for initialization
	void Start () {
		keepBaskets ();
	}
	void keepBaskets(){
		for (int i = 0; i < initialBaskets; i++) {
			basketList [i].transform.position = new Vector3 (0, basketRowGap *(1+ i), 0);
			basketList [i].SetActive (true);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
