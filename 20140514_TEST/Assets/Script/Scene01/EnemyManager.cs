using UnityEngine;
using System.Collections;

public class EnemyManager: MonoBehaviour {

	public GameObject enemyObject;	//敵オブジェクト
	public float yMax;				// 配置位置　高さの上限値
	public float interval;			// 敵の出現感覚
	public bool isRandomInterval;	// 敵の出現感覚をランダムに設定

	float nextSpawnTime = 0;
	int seed = System.Environment.TickCount;

	// Use this for initialization
	void Start () {
	
		if( yMax < 0 ){
			yMax *= -1;
		}

		if(interval < 0){
			interval = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
		if( nextSpawnTime < Time.timeSinceLevelLoad)
		{
			nextSpawnTime = Time.timeSinceLevelLoad + interval;


			System.Random rnd = new System.Random (seed++);
			System.Random rnd_2 = new System.Random (seed++);
			float y = (float)rnd.NextDouble() * yMax;

			if( rnd.Next(2) < 1 ){
				y *= -1;
			}


			GameObject obj = (GameObject)GameObject.Instantiate (enemyObject);
			obj.transform.position = new Vector3 (2.0f, y, 0.0f);
			obj.layer = 8;
		}
	}
}
