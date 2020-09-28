using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public void LoadStartMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadMainGame()
    {
        SceneManager.LoadScene("Game");
        FindObjectOfType<GameSession>().ResetGame();
    }

    public void LoadGameOver()
    {
        StartCoroutine(DeleyBelowDie());
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    IEnumerator DeleyBelowDie()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Game Over");
    }


}
