using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif


[RequireComponent(typeof(MainManager))]
public class MenuUIHandler : MonoBehaviour
{
    public GameObject playerNameField;
    public Text BestScoreText;
    public static string playerName;

    private void Awake()
    {
        MainManager.LoadScore();
        BestScoreText.text = "Best Score: " + MainManager.bestScore;
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void StoreName()
    {
        playerName = playerNameField.GetComponent<Text>().text;
    }

    // Update is called once per frame
   
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit(); 
#endif
    }
}
