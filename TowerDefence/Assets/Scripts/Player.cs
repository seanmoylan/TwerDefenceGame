using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    public int health = LevelManager.playerHealth;
    public int score = 0;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;
    public TextMeshProUGUI levelDisplay;

    void Start(){
        LevelManager.level++;

        if(LevelManager.score == 20){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void Update(){
        healthDisplay.text = "Health: "+ health;
        scoreDisplay.text = "Score: " + LevelManager.score;
        levelDisplay.text = "Level: " + LevelManager.level;

        if(health <= 0){
            // Game Over
            

        }

        
    }
}
