using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	private bool isJumpRequest;
	public float power = 2;
	private bool isDead;		//プレイヤーの生死

	// Use this for initialization
	void Start () {
	
		isDead = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(!isDead){
			if (Input.GetMouseButtonDown (0)) {
				isJumpRequest = true;
			}
		}
	}

	void FixedUpdate ()
	{
		if (isJumpRequest) {
			isJumpRequest = false;
			rigidbody2D.velocity = Vector3.up * power;
		}

		if( isDead ){
			transform.Rotate (0, 0, 10);
		}
	}

	private void OnCollisionEnter2D(Collision2D collision){
		isDead = true;
		rigidbody2D.velocity = Vector3.up * 3.0f;
	}

	public void Reset(){
		isDead = false;
		rigidbody2D.velocity = Vector3.zero;
		transform.position = new Vector3 (-0.4f, 0.8f, 0.0f);
		transform.rotation = Quaternion.identity;
	}
}
