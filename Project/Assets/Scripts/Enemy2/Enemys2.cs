using UnityEngine;
using System.Collections;

public class Enemys2 : MonoBehaviour {

    GameObject bullet;
    GameObject firePoint;

    void Awake()
    {
        firePoint = transform.Find("firePoint").gameObject;
        bullet = transform.Find("Bullet").gameObject;
    }


	// Use this for initialization
	void Start () {

        InvokeRepeating("CreateBullet", 3f, 4f);

	}
	
	// Update is called once per frame
	void Update () {
	
	}

    GameObject tempBullet;
    //创建子弹
    public void CreateBullet()
    {
        tempBullet = Instantiate(bullet) as GameObject;
        tempBullet.transform.position = firePoint.transform.position;
        tempBullet.transform.Rotate(0, 0, -90);
        tempBullet.SetActive(true);
    }

    void Destroy()
    {
        CancelInvoke();
    }
}
