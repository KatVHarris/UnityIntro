using UnityEngine;
using System.Collections;

public class Homming : MonoBehaviour {
	public Transform target; 
	public Transform turret; 
	public float damp = 1.0f; 
	// Update is called once per frame

	void Start(){
		if (this.transform.parent != null) {
			turret = this.transform.parent.transform; 
		}
	}
	void Update () {

				//this.transform.LookAt (target); 

				
	}

	void OnTriggerStay (Collider collider) {
		if (collider.transform == target.transform) {

			Vector3 relativePos = target.position - transform.position;
			Quaternion rotate = Quaternion.LookRotation (relativePos);
			turret.rotation = Quaternion.Slerp(turret.rotation , rotate, Time.deltaTime * damp);

		}
	}
}
