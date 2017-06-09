using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadTheFirstScene : MonoBehaviour {

    Button enterGame_Button;

    void Awake()
    {
        enterGame_Button = transform.GetComponent<Button>();
        enterGame_Button.onClick.AddListener(loadScene);
    }

   public static void loadScene()
    {
        SceneManager.LoadScene(1);
    }

    
}


