using UnityEngine;
using System.Collections;
using UnityEngine.UI;

//敌机
public class Enemys : MonoBehaviour
{
    public int BrachiosaurusLife = 1;
    public int RaptorLife = 1;
    public int DiplodocusLife = 4;
    public int SpinosaurusLife = 6;
    public int TriceratopsLife = 8;
    public int StegosaurusLife = 150;

    GameObject effect;  //特效引用
    public void Damage()
    {
        Debug.Log("dddd");
        if(gameObject.name == "Brachiosaurus(Clone)") {
            BrachiosaurusLife--;
        }

        if (gameObject.name == "Raptor(Clone)") {           
            RaptorLife--;
            Debug.Log(RaptorLife);
        }

        if (gameObject.name == "Diplodocus(Clone)") {
            DiplodocusLife--;
            Debug.Log(DiplodocusLife);
        }

        if (gameObject.name == "Spinosaurus(Clone)") {
            SpinosaurusLife--;
            Debug.Log(SpinosaurusLife);
        }

        if (gameObject.name == "Triceratops(Clone)") {
            TriceratopsLife--;
            Debug.Log(TriceratopsLife);
        }

        if (gameObject.name == "Stegosaurus(Clone)") {
            StegosaurusLife--;
            Debug.Log(StegosaurusLife);
        }

        if(BrachiosaurusLife <= 0) {
            Destroy(gameObject);
            //播放敌机死亡特效
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);

            //击中敌机加分
            GlobalMgr.Inst.scoreMgr.score += 1;
        }

        if (RaptorLife <= 0) {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 10;
        }

        if (DiplodocusLife <= 0) {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 20;
        }

        if (SpinosaurusLife <= 0) {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 30;
        }
        if (TriceratopsLife <= 0) {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 40;
        }
        if (StegosaurusLife <= 0) {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_boss, transform);
            GlobalMgr.Inst.scoreMgr.score += 1000;
        }
        Die();
    }

    //爆炸方法
    public void Damage_2()
    {

        if (gameObject.name == "Brachiosaurus(Clone)")
        {
            BrachiosaurusLife -= 50;
        }

        if (gameObject.name == "Raptor(Clone)")
        {
            RaptorLife -= 50;
            Debug.Log(RaptorLife);
        }

        if (gameObject.name == "Diplodocus(Clone)")
        {
            DiplodocusLife -= 50;
            Debug.Log(DiplodocusLife);
        }

        if (gameObject.name == "Spinosaurus(Clone)")
        {
            SpinosaurusLife -= 50;
            Debug.Log(SpinosaurusLife);
        }

        if (gameObject.name == "Triceratops(Clone)")
        {
            TriceratopsLife -= 50;
            Debug.Log(TriceratopsLife);
        }

        if (gameObject.name == "Stegosaurus(Clone)")
        {
            StegosaurusLife -= 90;
            Debug.Log(StegosaurusLife);
        }
        Die();
        
    }

    void Die() {
        if (BrachiosaurusLife <= 0)
        {
            Destroy(gameObject);
            //播放敌机死亡特效
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 1;

        }

        if (RaptorLife <= 0)
        {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 10;

        }

        if (DiplodocusLife <= 0)
        {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 20;

        }

        if (SpinosaurusLife <= 0)
        {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 30;

        }
        if (TriceratopsLife <= 0)
        {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_enemy, transform);
            GlobalMgr.Inst.scoreMgr.score += 40;

        }
        if (StegosaurusLife <= 0)
        {
            Destroy(gameObject);
            GlobalMgr.Inst.effectsMgr.CreatEffect(effect, GlobalMgr.Inst.effectsMgr.Effect_boss, transform);
            GlobalMgr.Inst.scoreMgr.score += 1000;

        }
    }
    
    public void Text()
    {
        Debug.Log("我我我我");
    }

}
