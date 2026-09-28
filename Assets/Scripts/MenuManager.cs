using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    // Bắt đầu chơi game (gọi từ MainMenu hoặc nút Restart ở EndGame)
    public void PlayGame()
    {
        SceneManager.LoadScene("Gameplay");
    }

    // Quay về Main Menu
    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Thoát game
    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}