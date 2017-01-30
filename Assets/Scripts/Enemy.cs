using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Enemy : Character {

	public LayerMask mask;
	public float range = 100f;

	protected Player player;

	// Use this for initialization
	void Awake() {
		base.Awake();
		player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Physics.Raycast(transform.position,transform.forward,range,mask)){
			ShootBullet();
		}else if(transform.position.z < player.transform.position.z){
			Move(0,1);
		}else{
			Move(0,-1);
		}
	}
}
