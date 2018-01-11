using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeChild : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D collision){
		collision.gameObject.transform.SetParent (gameObject.transform);
		//GameManager.Instance.updateEggIndexOfBasket ();
		//GameManager.Instance.updateBasketPosition ();
	}
}
