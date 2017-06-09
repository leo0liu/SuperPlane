using UnityEngine;
using System.Collections;

//全局管理类
public class GlobalMgr : MonoBehaviour {

    //全局管理类单例化
    static GlobalMgr inst;
    public static GlobalMgr Inst
    {
        get
        {
            return inst;   
        }          
    }

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        inst = this;

        //添加各种管理类组件到全局管理上
        //playerMgr = gameObject.AddComponent<PlayerMgr>();
        //playerMgr.Inst();
       

        bulletMgr = gameObject.AddComponent<BulletMgr>();

        effectsMgr = gameObject.AddComponent<EffectsMgr>();
        effectsMgr.Inst();
        audioMgr = gameObject.AddComponent<AudioMgr>();
       
        uIMgr = gameObject.AddComponent<UIMgr>();

        scoreMgr = gameObject.AddComponent<ScoreMgr>();
    }

    //玩家管理类
    //public PlayerMgr playerMgr {
    //    get;
    //    private set;
    //}

   

	//子弹管理类
    public BulletMgr bulletMgr
    {
        get;
        private set;
    }

    //特效管理类
    public EffectsMgr effectsMgr
    {
        get;
        private set;
    }

    //音效管理类
    public AudioMgr audioMgr
    {
        get;
        private set;
    }

    //UI界面管理类
    public UIMgr uIMgr
    {
        get;
        private set;
    }

    //计分管理类
    public ScoreMgr scoreMgr
    {
        get;
        private set;
    }

}
