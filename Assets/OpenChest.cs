using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour {

	public Transform target;
	public float speed = 10;
	public float lifetime;

	void Update ()
	{
		transform.RotateAround (target.position, target.up, speed * Time.deltaTime);
	}


	void Start ()
	{
		Destroy (gameObject, lifetime);
	}
}
