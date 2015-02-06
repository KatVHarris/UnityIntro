using UnityEngine;
using System.Collections;

public class Homming : MonoBehaviour {
	public Transform target; 
	public Transform turret; 
	public float damp = 0.50f; 
	GameObject targetObject; 
	// Update is called once per frame

	void Start(){
		if (this.transform.parent != null) {
			turret = this.transform.parent.transform; 
		}
		targetObject = GameObject.Find ("Player");
		target = targetObject.transform;
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
