using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text score;
    public GameObject gameOverPanel;
    private int killcount;
    public KillCounter kill;
    public void GameOver()
    {
        killcount = kill.GetCount();
        ScoreShow(killcount);
        gameOverPanel.SetActive(true);
    }
    public void Restart()
    {
        SceneManager.LoadScene("Balledonna");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void ScoreShow(int count)
    {
        score.text = count.ToString()+" Points";
    }
}
