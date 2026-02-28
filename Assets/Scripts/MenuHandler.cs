using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEditor;

public class MenuHandler : MonoBehaviour
{
    public TMP_InputField nameInput;

    public void StartGame()
    {
        PlayerData.playerName = nameInput.text;
        SceneManager.LoadScene(1);
    }
    
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}