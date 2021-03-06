using UnityEngine;
using System.Collections;

public class final_BOSS : MonoBehaviour {
    public Rigidbody projcetile;
    public bool needfire;
    private GameObject player;
    private UnityEngine.AI.NavMeshAgent nav;
    private float patrolTimer;
    private int wayPointIndex;

    float speed = 35;
    int counter = 0;
    // Use this for initialization
    void Start () {
        Debug.Log("AI Start");
        //nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        //needfire = false;
    }

 
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject == player)
        {
            Vector3 direction = (other.transform.position - transform.position);
            Quaternion rotation = Quaternion.LookRotation(direction * -1f);
            transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime);
            transform.Translate(0f, 0f, -0.05f);
            if (counter >= 30)
            {
                Rigidbody shoot =
                    (Rigidbody)Instantiate(projcetile, transform.position + new Vector3(0f, 3f, 0f), transform.rotation);
                //給砲彈方向力，將他從y軸推出去
                shoot.velocity = transform.TransformDirection(new Vector3(0f, 0f, -1f * speed));
                //讓坦克的碰撞框忽略砲彈的碰撞框
                Physics.IgnoreCollision(transform.root.GetComponent<Collider>(), shoot.GetComponent<Collider>());
                counter = 0;
                Debug.Log("Shoot!");
            }
            else
                counter++;
        }
    }
}
