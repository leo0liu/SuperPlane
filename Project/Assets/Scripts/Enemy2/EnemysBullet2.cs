using UnityEngine;
using System.Collections;

public class EnemysBullet2 : MonoBehaviour {

    float speed = 600f;


    // Use this for initialization
    void Start () {
        Destroy(gameObject, 9f);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }

    public void OnCollisionEnter(Collision collision)
    {
        Debug.Log("BBB");
        if (collision.transform.tag == "Enemy") {

            Debug.Log("aaa");
            //执行扣血方法
            collision.gameObject.GetComponent<Enemys>().Damage();

            Destroy(gameObject);
        }
    }
}
