using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Player : Character {

	// Use this for initialization
	protected void Awake() {
		base.Awake();
	}
	
	// Update is called once per frame
	protected override void Update () {
		float fDir = Input.GetAxis("Horizontal");
		float rDir = Input.GetAxis("Vertical");

		Move(fDir,rDir);

		if(Input.GetButtonDown("Fire1")){
			ShootBullet();
		}
	}
}
