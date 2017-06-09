using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Fire_UI_Mgr : MonoBehaviour {

    Button setting_Mgr;
    Button pause_button;
    GameObject setting_GameObject;
   public static  GameObject pauseGame;

    void Awake()
    {
        pause_button = transform.Find("TOP_UI/pause").GetComponent<Button>();
        pause_button.onClick.AddListener(OpenSetting);
        pauseGame = transform.Find("TOP_UI/PauseGame_text").gameObject;

      
    }
    //战斗页面右上角设置按钮事件
    void OpenSetting()
    {
        // fire_setting_ui.setting_Mgr.SetActive(true);
        fire_setting_ui.EnterSetting();
        Invoke("PauseGame",1.4f);
    }

    //暂停游戏

    void PauseGame()
    {
        Time.timeScale = 0;
        pauseGame.SetActive(true);
    }

    void Start () {
	
	}
	
	void Update () {
	
	}
}
