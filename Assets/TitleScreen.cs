using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{
    public Button startButton, exitButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        exitButton.onClick.AddListener(ExitGame);
    }

    void StartGame()
    {
        SceneManager.LoadScene(1);
    }


    void ExitGame()
    {
       Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
