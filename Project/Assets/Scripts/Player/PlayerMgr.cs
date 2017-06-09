using UnityEngine;
using System.Collections;


public class PlayerMgr : MonoBehaviour
{


    public float Player_Speed = 10f;


    GameObject missile_Point_Right;   //子弹发射位置
    GameObject missile_Point_Light;
    GameObject missil_Point_Center;
    GameObject missile_Light;
    GameObject missile_Right;
    GameObject missile_EX;
    AudioSource AudPlay;
    GameObject bullet_btn;
    GameObject buhuo_btn;
    GameObject Explode_btn;  //全屏爆炸
    ETCJoystick move_setting;
    AudioClip Ex_Sound;
    AudioClip shoot;
    public bool isDie = false;
    public void Awake()
    {
        missile_Point_Right = transform.Find("ShootPointRight").gameObject;
        missile_Point_Light = transform.Find("ShootPointLeft").gameObject;
        missil_Point_Center = transform.Find("ShootPointCenter").gameObject;
        missile_Light = transform.Find("Bullet1").gameObject;
        missile_Right = transform.Find("Bullet2").gameObject;
        missile_EX = transform.Find("Bullet3").gameObject;
        bullet_btn = GameObject.Find("bullet").gameObject;
        buhuo_btn = GameObject.Find("capture").gameObject;
        Explode_btn = GameObject.Find("other Button").gameObject;
        move_setting = GameObject.Find("player_move").GetComponent<ETCJoystick>();
        buhuo_btn.GetComponent<ETCButton>().onDown.AddListener(Discharge_EX);
        bullet_btn.GetComponent<ETCButton>().onDown.AddListener(Shoot);
        Explode_btn.GetComponent<ETCButton>().onDown.AddListener(Explode_EX);
        AudPlay = transform.GetComponent<AudioSource>();
        move_setting.axisX.directTransform = transform;
        move_setting.axisY.directTransform = transform;
        Ex_Sound = Resources.Load("Ex_Sound") as AudioClip;
        shoot = Resources.Load("Player_bullet_Audio") as AudioClip;
    }


    void Update()
    {
        Player_Move();
      
        Limit();

    }
    void Player_Move()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");
        transform.position += new Vector3(hor * Player_Speed, ver * Player_Speed, 0);
    }


    //发射子弹

    GameObject temp_Missile;
    GameObject temp_Missile_Right;
    public void Shoot()
    {
        temp_Missile = Instantiate(missile_Light,
            missile_Point_Right.transform.position, new Quaternion(1, 1, 0, 0)) as GameObject;
        temp_Missile.transform.localScale = new Vector3(30, 15, 5);
        temp_Missile.AddComponent<PlayerBullet>().isEx = true;
        temp_Missile.SetActive(true);
        temp_Missile_Right = Instantiate(missile_Right,
            missile_Point_Light.transform.position, new Quaternion(0.7f, 0.7f, 0, 0)) as GameObject;
        temp_Missile_Right.transform.localScale = new Vector3(30, 15, 5);
        temp_Missile_Right.AddComponent<PlayerBullet>().isEx=true;
        temp_Missile_Right.SetActive(true);
        AudPlay.clip = shoot;
        AudPlay.Play();
    }


    //捕获技能释放
    GameObject Missile_EX;


    public void Shoot_Ex()
    {
        Missile_EX = Instantiate(missile_EX,
            missil_Point_Center.transform.position, new Quaternion(1, 1, 0, 0)) as GameObject;
        Missile_EX.transform.localScale = new Vector3(100, 50, 5);
        Missile_EX.AddComponent<PlayerBullet>().isEx=false;
        Missile_EX.SetActive(true);
        AudPlay.clip = Ex_Sound;
        AudPlay.Play();
       
    }
    //EX技能释放限制
    public int T = 3;   //可释放次数

    public void Discharge_EX()
    {
        
        if (T > 0)
        {
            T--;
            Shoot_Ex();
        }
    }

    //全屏爆炸
    public void Explode_EX() {
        
        if (T > 0)
        {
            T--;
            GameObject[] enemys = GameObject.FindGameObjectsWithTag("Enemy");
            
            
            
            for (int i = 0; i < enemys.Length; i++)
            {
                Debug.Log(enemys[i].name);
                enemys[i].GetComponent<Enemys>().Damage_2();
            }
        }

    }

    //限制飞行范围 
    float limit_X_lift = -480f;
    float limit_X_right = 500f;
    float limit_Y_up = 260f;
    float limit_Y_down = -250f;
    void Limit()
    {
        //左边
        if (transform.position.x < limit_X_lift)
        {
            transform.position = new Vector3(limit_X_lift, transform.position.y, transform.position.z);
        }
        //右边
        if (transform.position.x > limit_X_right)
        {
            transform.position = new Vector3(limit_X_right, transform.position.y, transform.position.z);
        }
        //上边
        if (transform.position.y > limit_Y_up)
        {
            transform.position = new Vector3(transform.position.x, limit_Y_up, transform.position.z);
        }
        //下边
        if (transform.position.y < limit_Y_down)
        {
            transform.position = new Vector3(transform.position.x, limit_Y_down, transform.position.z);
        }
    }

    //玩家死亡


    GameObject effectS;  //特效引用
  
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Enemy")
        {
            GlobalMgr.Inst.effectsMgr.CreatEffect(effectS, GlobalMgr.Inst.effectsMgr.Effect_player, transform);
            isDie = true; 
            Destroy(gameObject);
        }

        if(other.transform.tag == "NormalBullet" || other.transform.tag == "SpecialBullet" || other.transform.tag == "LineBullet") {
            GlobalMgr.Inst.effectsMgr.CreatEffect(effectS, GlobalMgr.Inst.effectsMgr.Effect_player, transform);
            isDie = true;
            Destroy(gameObject);
        }
    } 





}


