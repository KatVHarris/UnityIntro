using UnityEngine;
using System.Collections;

public class ProjectileBehavior : MonoBehaviour {
	
	public GameObject explosionPrefab;
	private ExplosionScript explosionobject; 

	void OnCollisionEnter(Collision collision)
	{
		GameObject objectHit = collision.collider.gameObject;//is not getting parent object but the cylinder!
/*		if (objectHit.transform.parent.tag == "Enemy") {
			Destroy(this.gameObject);
		}*/
		if (objectHit.tag == "Enemy") {
						Destroy (this.gameObject); // first then add explosion
						objectHit.GetComponent<ExplosionScript>().BlowUp(objectHit, explosionPrefab);

				} else {
						if (objectHit.transform.parent != null && objectHit.transform.parent.tag == "Enemy") {
								Destroy (this.gameObject);
								objectHit.transform.parent.GetComponent<ExplosionScript>().BlowUp(objectHit, explosionPrefab);
			} else {
								Destroy (this.gameObject, 3);
						}
				}

	}
	
}
