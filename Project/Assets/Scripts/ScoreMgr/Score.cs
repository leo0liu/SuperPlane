using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text text;

    void Awake()
    {
        text = transform.Find("Text").GetComponent<Text>();
    }

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        text.text = GlobalMgr.Inst.scoreMgr.score.ToString();
	}
}
