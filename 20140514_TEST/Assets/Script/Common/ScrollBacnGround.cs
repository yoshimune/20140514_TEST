using UnityEngine;
using System.Collections;

public class ScrollBacnGround : MonoBehaviour {

	public float speed = 1;
	float current;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
		void Update () {
				current += Time.deltaTime * speed;
				renderer.material.SetTextureOffset("_MainTex", new Vector2(current, 0));
		}
}
