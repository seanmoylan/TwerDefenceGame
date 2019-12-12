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
    public GameObject gameover;

    void Start(){

        
    }

    void Update(){
        healthDisplay.text = "Health: "+ health;
        scoreDisplay.text = "Score: " + LevelManager.score;
        levelDisplay.text = "Level: " + LevelManager.level;

        if(health <= 0){
            // Game Over
            LevelManager.playerHealth = 0;
            Time.timeScale = 0f;
            gameover.SetActive(true);
        }

        if(LevelManager.score == 10){
            //LevelManager.score = 11;
            LevelManager.nextLevel();
        }
    }
}
