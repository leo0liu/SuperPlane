using UnityEngine;
using System.Collections;

public class EffectsMgr : MonoBehaviour {

    public GameObject Effect_player;
    public GameObject Effect_enemy;
    public GameObject Effect_boss;
    public GameObject Effect_bullet;
    public void Inst()
    {
        Effect_player = Resources.Load("Explosion_Player") as GameObject;
        Effect_enemy = Resources.Load("Explosion_Enemy") as GameObject;
        Effect_boss = Resources.Load("Explosion_Boss")as GameObject;
        Effect_bullet = Resources.Load("bullet_effect") as GameObject;

    }

    //创建特效

    public void CreatEffect(GameObject _inst, GameObject _effect, Transform _tan)
    {
        _inst = Instantiate(_effect) as GameObject;
        _inst.transform.parent = _tan.parent;
        _inst.transform.position = _tan.position;
        _inst.transform.rotation = new Quaternion();
        _inst.AddComponent<Effects>().destroy();
        
        
    }

    //打击特效 
    public void CreatEffect_bullet(GameObject _inst, GameObject _effect, Transform _tan)
    {
        _inst = Instantiate(_effect) as GameObject;
        _inst.transform.parent = _tan.parent;
        _inst.transform.position = _tan.position;
        _inst.transform.rotation = new Quaternion();
        _inst.AddComponent<Effects>().destroy_bullet();
    }



}
