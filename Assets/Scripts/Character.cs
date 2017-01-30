using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Character : MonoBehaviour {

	public float speed = 0.2f;
	public Transform bulletSpawnPoint;
	public Bullet bulletPrefab;

	protected Rigidbody rbody;
	//1 is forward, -1 is backwards
	protected int forward = 1;

	// Use this for initialization
	protected virtual void Awake() {
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	protected virtual void Update () {
	}

	protected void Move(float fDir, float rDir){
		if(fDir != 0f && Mathf.Sign(fDir) != Mathf.Sign(forward)){
			Flip();
		}
		rbody.velocity = new Vector3(fDir*speed,0f,rDir*speed);
	}

	protected void Flip(){
		transform.forward = -transform.forward;
		forward *= -1;
	}

	protected void ShootBullet(){
		Bullet bull = Instantiate<Bullet>(bulletPrefab,bulletSpawnPoint.position,Quaternion.identity);
		bull.transform.forward = transform.forward;
	}
}
