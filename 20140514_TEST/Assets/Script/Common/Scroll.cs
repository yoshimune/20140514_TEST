using UnityEngine;
using System.Collections;

public class Scroll: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 vec = new Vector3(transform.position.x +0.1f, transform.position.y, transform.position.z);
		transform.position = vec;

		if(transform.position.x > 10.0f){
			vec = new Vector3 (-10.0f, transform.position.y, transform.position.z);
			transform.position = vec;
		}
	}
}
