using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    private int score=0;
    [SerializeField]private Text ScoreText;
    [SerializeField]private Text HighScoreText;
    [SerializeField] GameObject gameOver;
    private GameObject bird;
    private float HighScore=0;

    void Start(){
        bird=GameObject.FindGameObjectWithTag("Player");
        if(PlayerPrefs.HasKey("HighScore")){
            HighScore=PlayerPrefs.GetFloat("HighScore");
            HighScoreText.text=HighScore.ToString();
        }
    }
    public void addScore(){
        score++;
        ScoreText.text=score.ToString();
    }

    public void resetGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver(){
        gameOver.SetActive(true);
        if(score>HighScore)
            PlayerPrefs.SetFloat("HighScore",score);
        Destroy(bird);
        birddestroy();
    }


    IEnumerable birddestroy(){
        yield return new WaitForSeconds(2);
        Destroy(bird);
    }
}
