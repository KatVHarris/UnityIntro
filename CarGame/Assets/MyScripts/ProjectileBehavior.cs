using UnityEngine;
using System.Collections;

public class ProjectileBehavior : MonoBehaviour {
	

	void OnCollisionEnter(Collision collision)
	{
		GameObject objectHit = collision.collider.gameObject;//is not getting parent object but the cylinder!

		if (objectHit.tag == "Enemy") {
					//Destroy (objectHit);
					Destroy(this.gameObject);
				}

		Destroy (this.gameObject, 3);

	}
}
