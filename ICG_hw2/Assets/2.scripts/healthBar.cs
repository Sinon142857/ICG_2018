using UnityEngine;
using System.Collections;

public class healthBar : MonoBehaviour {
    public float maxHealth;
    public dead d;
    public GameObject enemy;
    //public playerdead pd;
	// Use this for initialization
	void Start () {
        //enemy = GameObject.Find("enemy");
        //Debug.Log("www");
        d = enemy.GetComponent<dead>();
    }
	
    void Awake()
    {
        
    }
	// Update is called once per frame
	void Update () {
        //Debug.Log("www" + maxHealth);
        //Debug.Log(d.health);
        transform.localPosition = new Vector3(-98 + 96 * d.health / maxHealth, 2f, 0f);
	}
}
