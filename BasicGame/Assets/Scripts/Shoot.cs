using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

	public GameObject fireballPrefab; //bulletPrefab; 
	public int idk;
    public float speed = 200f; 
	
	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.None;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			GameObject clonedBullet;
			clonedBullet = Instantiate(fireballPrefab,//bulletPrefab,
			                           transform.position,
			                           transform.rotation) as GameObject;
			clonedBullet.GetComponent<Rigidbody>().AddForce(clonedBullet.transform.forward * speed);
		}
	}
}
