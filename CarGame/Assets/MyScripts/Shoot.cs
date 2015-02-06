using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject fireballPrefab; //bulletPrefab; 
	public int idk; 
	
	// Use this for initialization
	void Start () {
		Screen.lockCursor = true;
		Screen.showCursor = false;
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
