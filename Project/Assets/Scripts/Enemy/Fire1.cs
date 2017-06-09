using UnityEngine;
using System.Collections;

public class Fire1 : MonoBehaviour
{

    

    public void Start()
    {
        InvokeRepeating("Point", 2, 2);
    }

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 500);

    }

    void Point()
    {
        transform.localPosition = new Vector3();
        transform.Translate(Vector3.up * Time.deltaTime * 500);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
