
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

//敌机管理类
public class EnemyMgr : MonoBehaviour
{
    static EnemyMgr inst;
    public static EnemyMgr Inst
    {
        get
        {
            return inst;
        }
    }

    int enemyNum = 5;

    List<GameObject> enemyGroup = new List<GameObject>();
    List<GameObject> enemyGroup1 = new List<GameObject>();
    GameObject tempEnemy;


    //查找到敌机，并把敌机添加到集合里面
    public void FindAllEnemy()
    {
        enemyGroup.Clear();
        //敌机1
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Brachiosaurus") as GameObject;
        enemyGroup.Add(tempEnemy);
        //敌机2
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Diplodocus") as GameObject;
        enemyGroup.Add(tempEnemy);
        //敌机3
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Raptor") as GameObject;
        enemyGroup.Add(tempEnemy);
        //敌机4
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Spinosaurus") as GameObject;
        enemyGroup.Add(tempEnemy);
        //敌机5
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Stegosaurus") as GameObject;
        enemyGroup.Add(tempEnemy);
        //敌机6
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Triceratops") as GameObject;
        enemyGroup.Add(tempEnemy);
        //敌机7
        tempEnemy = Resources.Load("Model/Enemy/Spaceship Pack/Prefabs/Tyrannosaurus") as GameObject;
        enemyGroup.Add(tempEnemy);
    }

    //获取大Boss护卫队
    public void guard()
    {
        tempEnemy = Resources.Load("Model/Enemy/SpaceShip/Prefab/SpaceShip2_v3") as GameObject;
        enemyGroup1.Add(tempEnemy);
        tempEnemy = Resources.Load("Model/Enemy/SpaceShip/Prefab/SpaceShip3_v1") as GameObject;
        enemyGroup1.Add(tempEnemy);
        tempEnemy = Resources.Load("Model/Enemy/SpaceShip/Prefab/SpaceShip4_v2") as GameObject;
        enemyGroup1.Add(tempEnemy);
        tempEnemy = Resources.Load("Model/Enemy/SpaceShip/Prefab/SpaceShip_v3") as GameObject;
        enemyGroup1.Add(tempEnemy);
    }

    //创建敌机1
    GameObject _enemy;
    void CreatEnemy()
    {
        _enemy = Instantiate(enemyGroup[0]) as GameObject;
        Enemys Enemyss = _enemy.AddComponent<Enemys>();
        Enemyss.transform.parent = transform;
        Enemyss.transform.localPosition = Vector3.zero;
        Enemyss.transform.localRotation = new Quaternion();
        Enemyss.transform.localScale = new Vector3(50, 50, 50);
        Enemyss.transform.Rotate(new Vector3(0, -90, 0));
        //EnemyBullet enbu = new EnemyBullet();
        Destroy(_enemy, 7);
    }

    //创建敌机2
    public void CreatEnemy2()
    {
        _enemy = Instantiate(enemyGroup[2]) as GameObject;
        Enemys enemyss = _enemy.AddComponent<Enemys>();
        enemyss.transform.parent = transform;
        enemyss.transform.localPosition = Vector3.zero;
        enemyss.transform.localRotation = new Quaternion();
        enemyss.transform.localScale = new Vector3(240, 240, 240);
        enemyss.transform.Rotate(new Vector3(0, -90, 0));
        Destroy(_enemy, 7);
    }

    //创建敌机3
    public void CreatEnemy3()
    {
        _enemy = Instantiate(enemyGroup[1]) as GameObject;
        Enemys enemysss = _enemy.AddComponent<Enemys>();
        enemysss.transform.parent = transform;
        enemysss.transform.localPosition = Vector3.zero;
        enemysss.transform.localRotation = new Quaternion();
        enemysss.transform.localScale = new Vector3(110,110,110);
        enemysss.transform.Rotate(new Vector3(0, -90, 0));
        Destroy(_enemy,7);
    }

    //创建敌机4
    public void CreatEnemy4()
    {
        _enemy = Instantiate(enemyGroup[3]) as GameObject;
        Enemys enemys = _enemy.AddComponent<Enemys>();
        enemys.transform.parent = transform;
        enemys.transform.localPosition = Vector3.zero;
        enemys.transform.localRotation = new Quaternion();
        enemys.transform.localScale = new Vector3(200,200,200);
        enemys.transform.Rotate(new Vector3(0, -90, 0));
        Destroy(_enemy, 7);
    }



    //创建敌机5
    public void CreatEnemy5()
    {
        _enemy = Instantiate(enemyGroup[5]) as GameObject;
        Enemys enemys = _enemy.AddComponent<Enemys>();
        enemys.transform.parent = transform;
        enemys.transform.localPosition = Vector3.zero;
        enemys.transform.localRotation = new Quaternion();
        enemys.transform.localScale = new Vector3(200, 200, 200);
        enemys.transform.Rotate(new Vector3(0, -90, 0));
        Destroy(_enemy, 7);
    }

    //创建小Boss
    public void CreatEnemy7()
    {
        _enemy = Instantiate(enemyGroup[4]) as GameObject;
        Enemys enemys = _enemy.AddComponent<Enemys>();
        enemys.transform.parent = transform;
        enemys.transform.localPosition = Vector3.zero;
        enemys.transform.localRotation = new Quaternion();
        enemys.transform.localScale = new Vector3(200, 200, 200);
        enemys.transform.Rotate(new Vector3(0, -90, 0));
    }

    //创建护卫队1
    public void guard1()
    {
        _enemy = Instantiate(enemyGroup1[0]) as GameObject;
        Enemys enemys = _enemy.AddComponent<Enemys>();
        enemys.transform.parent = transform;
        enemys.transform.localPosition = Vector3.zero;
        enemys.transform.localRotation = new Quaternion();
        enemys.transform.localScale = new Vector3(13, 13, 13);
        enemys.transform.Rotate(new Vector3(0, -90, 0));
        Destroy(_enemy,7);
    }

    //创建大boss
    public void CreatEnemy6()
    {
        _enemy = Instantiate(enemyGroup[6]) as GameObject;
        Enemys Enemyss = _enemy.AddComponent<Enemys>();
        Enemyss.transform.parent = transform;
        Enemyss.transform.localPosition = Vector3.zero;
        Enemyss.transform.localRotation = new Quaternion();
        Enemyss.transform.localScale = new Vector3(200, 190, 122);
        Enemyss.transform.Rotate(new Vector3(0, -90, 0));
    }

    //禁止第一波兵调用
    void StopOne()
    {
        
        CancelInvoke("CreatEnemy");
        CancelInvoke("CreatEnemy2");
    }
    //禁止第二波兵调用
    void StopTwo()
    {
        CancelInvoke("CreatEnemy3");
    }
    //禁止第三波兵调用
    void StopThr()
    {
        CancelInvoke("CreatEnemy4");
    }

    //禁止第四波兵调用
    void StopFiv()
    {
        CancelInvoke("CreatEnemy5");
    }

    //禁止调用护卫队（）
   

    void Awake()
    {
        inst = this;
    }

    public void Start()
    {
        FindAllEnemy();
        //第一波兵
        InvokeRepeating("CreatEnemy", 10, 1);
        InvokeRepeating("CreatEnemy2", 10, 1);
        Invoke("StopOne", 14);

        //第二波兵
        InvokeRepeating("CreatEnemy3", 28, 1);
        Invoke("StopTwo",32);

        //第三波兵
        InvokeRepeating("CreatEnemy4", 46, 1);
        Invoke("StopThr", 50);

        //第四波兵
        InvokeRepeating("CreatEnemy5",60, 1);
        Invoke("StopFiv", 64);

        //小Boss出现
        Invoke("CreatEnemy7", 76);
        //Invoke("CreatEnemy6", 1);
    }

    
}
