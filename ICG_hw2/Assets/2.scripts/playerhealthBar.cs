using UnityEngine;
using System.Collections;

public class playerhealthBar : MonoBehaviour {
    public float maxHealth = 200;
    public playerdead d;
    public GameObject tank;
    // Use this for initialization
    void Start () {
        tank = GameObject.Find("tank");
        d = tank.GetComponent<playerdead>();
        Debug.Log("player");
	}
	
	// Update is called once per frame
	void Update () {
        transform.localPosition = new Vector3(-98 + 96 * d.health / maxHealth, 2f, 0f);
    }
}
