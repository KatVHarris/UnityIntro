using UnityEngine;
using System.Collections;

public class TestMovement : MonoBehaviour {

	public float speed = 3.0f; 
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Input.GetAxis ("Horizontal") * speed * Time.deltaTime, 0, 0);
	}
}
