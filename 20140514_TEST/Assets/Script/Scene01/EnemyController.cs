using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour {

	public float enemySpeed;

	// Use this for initialization
	void Start () {
	
		if (enemySpeed <= 0) {
			enemySpeed = 0.05f;
		} else {
			enemySpeed *= 0.01f;
		}
	}
	
	// Update is called once per frame
	/*void Update () {

		if( transform.position.x < -2.0f ){
			Destroy (gameObject);
		}
	
		Vector3 vec = new Vector3 (transform.position.x - enemySpeed, transform.position.y, transform.position.z);
		//Vector3 vec = new Vector3 (0f,0f,0f);
		transform.position = vec;
	}*/

	void FixedUpdate () {

		if( transform.position.x < -2.0f ){
			Destroy (gameObject);
		}

		Vector3 vec = new Vector3 (transform.position.x - enemySpeed, transform.position.y, transform.position.z);
		//Vector3 vec = new Vector3 (0f,0f,0f);
		transform.position = vec;
	}
}
