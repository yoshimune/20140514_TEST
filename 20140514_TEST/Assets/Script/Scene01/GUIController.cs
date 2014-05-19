using UnityEngine;
using System.Collections;

public class GUIController : MonoBehaviour {

	private bool isPause;

	// Use this for initialization
	void Start () {
	
		isPause = false;
	}
	
	public void Pause(){
		if (isPause) {
			isPause = false;
			Time.timeScale = 1; //再生
		} else {
			isPause = true;
			Time.timeScale = 0; //一時停止
		}
	}
}
