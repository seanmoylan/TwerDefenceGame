using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Player : MonoBehaviour
{
    public int health = 10;
    public int score = 0;
    public TextMeshProUGUI healthDisplay;
    public TextMeshProUGUI scoreDisplay;

    void Start(){
        
    }

    void Update(){
        healthDisplay.text = "Health = "+ health;
        scoreDisplay.text = "Score = "+score;

        if(health <= 0){
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
