using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rework : MonoBehaviour
{
    public int life = 2;    //命数
    GameObject player_Pre;
    GameObject canvas;
    Text lifeText;
   
    
    void Awake()
    {
        player_Pre = Resources.Load("player") as GameObject;
        canvas = GameObject.Find("Canvas");
        lifeText = canvas.transform.Find("TOP_UI/life/Text").GetComponent<Text>();

    }
    void Update()
    {
        rework();
        lifeText.text = life.ToString();
        
    }

    GameObject Player;
    public void rework()
    {
        if (transform.childCount <= 0 && life > 0)
        {
            Debug.Log("2");
            life--;
            Player = Instantiate(player_Pre, transform.position, new Quaternion(0, -0.7f, 0, -0.7f)) as GameObject;
            Player.transform.parent = transform;
            Player.GetComponent<BoxCollider>().enabled = false;
            Player.name = "player";

            StartCoroutine(delay());
        }
    }


    IEnumerator delay()
    {
        yield return new WaitForSeconds(1.5f);
        Player.GetComponent<BoxCollider>().enabled = true;
    }
}
