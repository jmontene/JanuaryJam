using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour {

	public float speed = 3f;
	public float destroyTime = 4f;

	private Rigidbody rbody;

	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		rbody.velocity = transform.forward*speed;
	}

	void Update(){
		destroyTime -= Time.deltaTime;
		if(destroyTime <= 0f){
			Destroy(gameObject);
		}
	}
}
