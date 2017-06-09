using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fire_setting_ui : MonoBehaviour {

    Button login_button;//登入确认按钮
    Button register_button; //登陆界面的进入注册界面的按钮
    Button register_true;//注册界面的确定注册按钮
    Button retrun_button;//返回按钮
    Button prompt_button;//提示框的确定按钮
public static  Button setting_button;//设置按钮
    Button gameAgain;//重新开始游戏按钮
    Button exitGame;//退出游戏按钮
    Button settingCancel_button;//设置里的取消按钮

    Toggle ismusic;//音量开关
    Slider starMusicControl;//音量控制

    AudioSource audioStarMusic;

    GameObject login_Mgr;
    GameObject register_Mgr;
    GameObject prompt;
    public static GameObject setting_Mgr;

    InputField registerInput_id;
    InputField registerInput_pass;
    InputField loginIput_id;
    InputField loginIput_pass;

    Text prompt_text;

    // 用户信息
    public string id = "id";
    public string pass = "pass";

    void Awake()
    {
        login_Mgr = transform.Find("login_Mgr").gameObject;
        register_Mgr = transform.Find("register_Mgr").gameObject;
        prompt = transform.Find("prompt").gameObject;
        setting_Mgr = transform.Find("setting_Mgr").gameObject;

        ismusic = transform.Find("setting_Mgr/ismusic").GetComponent<Toggle>();
        ismusic.onValueChanged.AddListener(delegate(bool a) { ismusicToggle(a); });

        register_button = transform.Find("login_Mgr/register").GetComponent<Button>() ;
        register_button.onClick.AddListener(LoadRegister);
        retrun_button = transform.Find("register_Mgr/retrun").GetComponent<Button>();
        retrun_button.onClick.AddListener(ReturnLogin);
        login_button = transform.Find("login_Mgr/enterGame_Button").GetComponent<Button>();
        login_button.onClick.AddListener(PlayerTure);
        register_true = transform.Find("register_Mgr/register").GetComponent<Button>();
        register_true.onClick.AddListener(SaveInfo);
        prompt_button = transform.Find("prompt/ture").GetComponent<Button>();
        prompt_button.onClick.AddListener(StopPrompt);
        setting_button = transform.Find("login_Mgr/setting").GetComponent<Button>();
        setting_button.onClick.AddListener(EnterSetting);
        gameAgain = transform.Find("setting_Mgr/gameAgain").GetComponent<Button>();
        gameAgain.onClick.AddListener(gameAgain_fuction);
        exitGame = transform.Find("setting_Mgr/ExitGame").GetComponent<Button>();
        exitGame.onClick.AddListener(ExitGame);
        settingCancel_button = transform.Find("setting_Mgr/cancel").GetComponent<Button>();
        settingCancel_button.onClick.AddListener(SettingCancel);

        registerInput_id = transform.Find("register_Mgr/id").GetComponent<InputField>() ;
        registerInput_pass = transform.Find("register_Mgr/password").GetComponent<InputField>();
        loginIput_id = transform.Find("login_Mgr/id").GetComponent<InputField>() ;
        loginIput_pass = transform.Find("login_Mgr/password").GetComponent<InputField>();

        prompt_text = transform.Find("prompt/tital/Text (1)").GetComponent<Text>();

        audioStarMusic = GameObject.FindWithTag("StarMusic").GetComponent<AudioSource>();

        starMusicControl = transform.Find("setting_Mgr/starMusicControl").GetComponent<Slider>();
        starMusicControl.onValueChanged.AddListener(delegate (float a) { StarMusicControl(a); });
    }

	void Start () {
	
	}
	
    //从登陆界面事件跳转进入注册界面
    void LoadRegister()
    {
        login_Mgr.SetActive(false);
        register_Mgr.SetActive(true);

    }

    //从注册界面按下返回按钮,返回到登陆界面
    void ReturnLogin()
    {
        login_Mgr.SetActive(true);
        register_Mgr.SetActive(false);
    }

    //注册保存用户账号密码信息
    void SaveInfo()
    {
        Debug.Log(registerInput_id.text);
        if (registerInput_id.text==""|| registerInput_pass.text=="")
        {

            prompt.SetActive(true);
            prompt_text.text = "请输入信息";

        }
        else
        {
            if (PlayerPrefs.HasKey(registerInput_id.text))
            {
                prompt.SetActive(true);
                prompt_text.text = "账号已存在,请重新输入";
            }
            else
            {
                PlayerPrefs.SetString(id, registerInput_id.text);
                PlayerPrefs.SetString(pass, registerInput_pass.text);
                PlayerPrefs.Save();
                prompt.SetActive(true);
                prompt_text.text = "注册成功";

            }
        }
    }

    //检查用户名与密码是否正确,并进入游戏
     void PlayerTure()
    {
        if ((loginIput_id.text == PlayerPrefs.GetString(id)) &&(loginIput_pass.text == PlayerPrefs.GetString(pass)))
        {
            LoadTheFirstScene.loadScene();
        }
        else
        {
            prompt.SetActive(true);
            prompt_text.text = "用户名与密码不正确";
        }
      
    }
     //取消提示框
     void StopPrompt()
    {
        prompt.SetActive(false);
    }

    //设置按钮事件弹出设置栏
  public static void EnterSetting()
    {
        setting_Mgr.SetActive(true);
    }

    //重新游戏
    void gameAgain_fuction()
    {
        LoadTheFirstScene.loadScene();
        Time.timeScale = 1;
    }
    
    //退出游戏
    void ExitGame()
    {
        Application.Quit();
    }

    //音量开关
    void ismusicToggle(bool a1)
    {
        if (a1==false)
        {
            a1 = true;
            audioStarMusic.Stop();
            return;
        }
        if (a1==true)
        {
            a1 = false;
            audioStarMusic.Play();
            return;
        }
    }
    //音量控制
    void StarMusicControl(float a)
    {
        audioStarMusic.volume = a;
    }

    //设置栏取消按钮事件
   void SettingCancel()
    {
        setting_Mgr.SetActive(false);
        Time.timeScale = 1;
        Fire_UI_Mgr.pauseGame.SetActive(false);
    }
}
