using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VictoryScreen : MonoBehaviour
{
    public Button nextbutton;
    public string SceneName;
    Scene ActiveScene;
    // Start is called before the first frame update
    void Start()
    {
        nextbutton.onClick.AddListener(NextLevel);
    }

    void NextLevel()
    {
        ActiveScene = SceneManager.GetActiveScene();
        SceneName = ActiveScene.name;
        for (int i = 0; i < 7; i++)
        {
            if(SceneName == "Level " + i)
            {
                SceneManager.LoadScene("Level " + (i + 1));
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
