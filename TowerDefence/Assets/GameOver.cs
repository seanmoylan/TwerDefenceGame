using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI finalScore;
    public GameObject mainMenu;

    public void showFinalScore(){
        finalScore.text = "Final Score: "+LevelManager.totalScore;
    }

    public void returnMenu(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
