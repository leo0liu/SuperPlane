using UnityEngine;
using System.Collections;

//玩家子弹类
public class PlayerBullet : MonoBehaviour {

    float speed = 1000f;
    float ex_speed = 1000f;
    GameObject VortexEffect;
    GameObject VortexEffect2;
    GameObject player;

    void Awake()
    {
        VortexEffect = Resources.Load("VortexEffect") as GameObject;
        VortexEffect2 = Resources.Load("VortexEffect2") as GameObject;
        player = GameObject.Find("GameObject/player") as GameObject;

    }

    public bool isEx = false;
	void Start () {
        //4s后销毁自己
        Destroy(gameObject, 5f);

	}
	
	
	void Update () {
        if (isEx)
        {
            Normal_bullet();
        }
        else {
            EX_bullet();
        }
	}

    void Normal_bullet() {
        transform.Translate(Vector3.up * Time.deltaTime * speed);
    }
    void EX_bullet()
    {
        transform.Translate(Vector3.up * Time.deltaTime * ex_speed);
    }

    GameObject effect;  //特效预制体
    GameObject instEffect; //临时实例化物体的引用

    //碰撞器响应的方法
    public void OnCollisionEnter(Collision collision)
    {
        //玩家的子弹击中敌机
        if(collision.collider.tag == "Enemy") {         
            //执行扣血方法
            collision.gameObject.GetComponent<Enemys>().Damage();

            Destroy(gameObject);
        }

    }

    public void OnTriggerEnter(Collider collider)
    {

        if(collider.tag == "Enemy") {
            if(collider.name != "Stegosaurus(Clone)") {

                Destroy(collider.transform.GetComponent<Animation>());
                Destroy(collider.transform.GetComponent<EnemyMgr>());
                collider.transform.GetComponent<Animator>().SetBool("IsShrink", true);

                //生成Vortex
                Instantiate(VortexEffect, collider.transform.position, Quaternion.identity);

                //生成Vortex2和敌机
                CreateVortex();
                CreateEnemy(collider);
                

            }
           Destroy(gameObject);
        }
       
    }

    //生成Vortex
    public void CreateVortex()
    {
        GameObject topPoint = GameObject.Find("GameObject/player/TopPoint");
        GameObject bottomPoint = GameObject.Find("GameObject/player/BottomPoint");
        GameObject temp1 = Instantiate(VortexEffect2, topPoint.transform.position, Quaternion.identity) as GameObject;
        GameObject temp2 = Instantiate(VortexEffect2, bottomPoint.transform.position, Quaternion.identity) as GameObject;
        temp1.transform.SetParent(player.transform);
        temp2.transform.SetParent(player.transform);

        Destroy(temp1, 8f);
        Destroy(temp2, 8f);
    }

    GameObject effect2; //爆炸特效
    //生成敌机
    public void CreateEnemy(Collider collider)
    {
        GameObject temp;
        GameObject enemy1;
        GameObject enemy2;
        
        Transform topPoint = player.transform.Find("TopPoint");
        Transform bottomPoint = player.transform.Find("BottomPoint");

        if(topPoint.childCount == 1) {
            Destroy(topPoint.GetChild(0).gameObject);
            //播放敌机死亡特效
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect2, GlobalMgr.Inst.effectsMgr.Effect_enemy, topPoint.GetChild(0));

        }

        if (bottomPoint.childCount == 1) {
            Destroy(bottomPoint.GetChild(0).gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect2, GlobalMgr.Inst.effectsMgr.Effect_enemy, bottomPoint.GetChild(0));
        }

        
            if(collider.name == "Brachiosaurus(Clone)") {
                temp = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs2/Brachiosaurus") as GameObject;
                //敌机初始化
                enemy1 = Instantiate(temp) as GameObject;
                enemy2 = Instantiate(temp) as GameObject;
                enemy1.transform.position = topPoint.position;
                enemy2.transform.position = bottomPoint.position;            
                enemy1.transform.SetParent(topPoint);
                enemy2.transform.SetParent(bottomPoint);
            enemy1.transform.localPosition = new Vector3(0, 0, 0);
            enemy2.transform.localPosition = new Vector3(0, 0, 0);


        } else if(collider.name == "Raptor(Clone)") {
                temp = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs2/Raptor") as GameObject;
                //敌机初始化
                enemy1 = Instantiate(temp) as GameObject;
                enemy2 = Instantiate(temp) as GameObject;
                enemy1.transform.position = topPoint.position;
                enemy2.transform.position = bottomPoint.position;
                enemy1.transform.SetParent(topPoint);
                enemy2.transform.SetParent(bottomPoint);
            enemy1.transform.localPosition = new Vector3(0, 0, 0);
            enemy2.transform.localPosition = new Vector3(0, 0, 0);

        } else if(collider.name == "Diplodocus(Clone)") {
                temp = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs2/Diplodocus") as GameObject;
                //敌机初始化
                enemy1 = Instantiate(temp) as GameObject;
                enemy2 = Instantiate(temp) as GameObject;
                enemy1.transform.position = topPoint.position;
                enemy2.transform.position = bottomPoint.position;
                enemy1.transform.SetParent(topPoint);
                enemy2.transform.SetParent(bottomPoint);
            enemy1.transform.localPosition = new Vector3(0, 0, 0);
            enemy2.transform.localPosition = new Vector3(0, 0, 0);
        } else if(collider.name == "Spinosaurus(Clone)") {
                temp = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs2/Spinosaurus") as GameObject;
                //敌机初始化
                enemy1 = Instantiate(temp) as GameObject;
                enemy2 = Instantiate(temp) as GameObject;
                enemy1.transform.position = topPoint.position;
                enemy2.transform.position = bottomPoint.position;
                enemy1.transform.SetParent(topPoint);
                enemy2.transform.SetParent(bottomPoint);
            enemy1.transform.localPosition = new Vector3(0, 0, 0);
            enemy2.transform.localPosition = new Vector3(0, 0, 0);
        } else if(collider.name == "Triceratops(Clone)") {
                temp = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs2/Triceratops") as GameObject;
                //敌机初始化
                enemy1 = Instantiate(temp) as GameObject;
                enemy2 = Instantiate(temp) as GameObject;
                enemy1.transform.position = topPoint.position;
                enemy2.transform.position = bottomPoint.position;
                enemy1.transform.SetParent(topPoint);
                enemy2.transform.SetParent(bottomPoint);
            enemy1.transform.localPosition = new Vector3(0, 0, 0);
            enemy2.transform.localPosition = new Vector3(0, 0, 0);
        }

        

       

    }


}
