using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	public GameObject effect;//特效
	public dead d;
	public GameObject enemy;
	void Start () {
		//d = enemy.GetComponent<dead>();
        Destroy(gameObject, 3);
    }	
	void Update () {
    }

	void OnCollisionEnter (Collision collision) {//碰撞發生時呼叫
		//碰撞後產生爆炸
			
		//if(collision.gameObject.tag == "enemy" || collision.gameObject.tag == "enemy2" || collision.gameObject.tag == "enemy3")
        //{//當撞到的collider具有enemy tag時
			Instantiate (effect, transform.position, transform.rotation);
			Destroy(gameObject);//刪除砲彈
		//}	
	}
}
