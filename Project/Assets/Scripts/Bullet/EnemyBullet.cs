using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour
{

    float speed = 400f;
    GameObject player;
    Vector3 playerPosition;
    Vector3 direction;
    Animator lineBullet;

    void Awake ()
    {
        player = GameObject.Find("player");
        if(player != null) {
            playerPosition = player.transform.position;
        } else {
            playerPosition = Vector3.up;
        }


    }

    void Start ()
    {

        Destroy(gameObject, 9f);

        if(playerPosition != null) {
            direction = player.transform.position - transform.parent.position;
        }


    }

    void Update ()
    {

        if (transform.tag == "NormalBullet") {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (transform.tag == "SpecialBullet") {
            if(player != null) {

                transform.position += direction * Time.deltaTime * 0.5f;

            } else {
                
                transform.Translate(Vector3.up * Time.deltaTime * speed);
            }
        }

    }


    void Destroy ()
    {
        
    }

    public void OnTriggerEnter (Collider collider)
    {
        if(collider.tag == "Player") {

            Destroy(gameObject);
        }
    }
}
