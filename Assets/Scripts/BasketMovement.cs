using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour {
	// Use this for initialization
	public Transform leftPoint;
	public Transform rightPoint;
	float distance;
	public float padding;
	public float speed = 2.0f; 
	private Vector3 startPos;

	void Start () {
		startPos = transform.position;
		distance = (Mathf.Abs (rightPoint.position.x - leftPoint.position.x)-padding)/2;
	}

	void Update () {
		Vector3 tempDistance = startPos;
		tempDistance.x += distance * Mathf.Sin (Time.time*speed);
		transform.position = tempDistance;
	}
}
