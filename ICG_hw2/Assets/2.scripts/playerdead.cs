using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playerdead : MonoBehaviour {
    public float health;
    public int enemyNumber;
    public GameObject effect, effect2;
    public Button b, c;
    public Text t;
    tankMove move;
    dead d;
    
    // Use this for initialization
    void Start () {
        b = GameObject.Find("Button").GetComponent<UnityEngine.UI.Button>();
        b.gameObject.SetActive(false);
        c = GameObject.Find("Button1").GetComponent<UnityEngine.UI.Button>();
        c.gameObject.SetActive(false);
        move = GetComponent<tankMove>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (enemyNumber == 0 && health > 0) {
            b.gameObject.SetActive(true);
            c.gameObject.SetActive(true);
            t.enabled = true;
        }
  
	}
    void OnCollisionEnter(Collision collision)
    {//碰撞發生時呼叫
     //碰撞後產生爆炸

        if (collision.gameObject.tag == "enemy")
        {//當撞到的collider具有enemy tag時
            health = health - 10;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                c.gameObject.SetActive(true);
                //Destroy(gameObject);
            }
        }

        // if (collision.gameObject.tag == "enemy2")
        // {//當撞到的collider具有enemy tag時
        //     Destroy(collision.gameObject);
        //     Instantiate(effect2, transform.position, transform.rotation);
        //     d = collision.gameObject.GetComponent<dead>();
        //     d.health = 0;
        //     d.player.enemyNumber--;
        //     health = health - 80;
        //     if (health <= 0)
        //     {
        //         Instantiate(effect, transform.position, transform.rotation);
        //         //Destroy(gameObject);
        //     }
        // }

        if (collision.gameObject.tag == "enemy3")
        {//當撞到的collider具有enemy tag時
            health = health - 20;
            if (health <= 0)
            {
                Instantiate(effect, transform.position, transform.rotation);
                c.gameObject.SetActive(true);
                //Destroy(gameObject);
            }
        }
    }
    public void loadScene3()
    {//換下一關
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("3");
    }
    public void loadScene2()
    {//換下一關
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("2");
    }
    public void PlayAgain()
    {//換下一關
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("1");
    }
    public void endGame()
    {//換下一關
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        //Debug.Log("end");
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying=false;
        #else
            Application.Quit();
        #endif
    }
}
