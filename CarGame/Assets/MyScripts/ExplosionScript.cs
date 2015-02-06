using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour {
	//public GameObject bigExplosion; 

	public void BlowUp(GameObject objectHit, GameObject bigExplosion){
		Transform objLocation = objectHit.transform;
		GameObject explosion;
		explosion = Instantiate(bigExplosion, objLocation.position, objLocation.rotation) as GameObject;
		objectHit.GetComponent<Rigidbody>().AddForce(Vector3.up * 1000);
		//Destroy(this.gameObject);
	}
}
