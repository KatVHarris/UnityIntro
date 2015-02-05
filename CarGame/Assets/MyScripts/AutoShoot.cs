using UnityEngine;
using System.Collections;

public class AutoShoot : MonoBehaviour {
	public GameObject fireballPrefab; //bulletPrefab; 
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject clonedBullet;
			clonedBullet = Instantiate(fireballPrefab,//bulletPrefab,
			                           transform.position,
			                           transform.rotation) as GameObject;
			clonedBullet.rigidbody.AddForce(clonedBullet.transform.forward * 2000);
		}
	}
}
