using UnityEngine;
using System.Collections;

public class dead : MonoBehaviour {
    public float health;
    public GameObject effect;
    public playerdead player;
    // Use this for initialization
    void Start () {
	   //Debug.Log("Hi!");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnCollisionEnter(Collision collision)
    {//碰撞發生時呼叫
     //碰撞後產生爆炸
        //Debug.Log("Hit!");
        if (collision.gameObject.tag == "bullet")
        {//當撞到的collider具有enemy tag時
            //Debug.Log(health);
            health = health - 10;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                player.enemyNumber--;
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.tag == "bullet2")
        {//當撞到的collider具有enemy tag時
            health = health - 20;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                player.enemyNumber--;
                Destroy(gameObject);
            }
        }
    }
}
