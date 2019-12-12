using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LevelManager
{
    public static float spawnIncrement = 1.5f;
    public static int enemyHealth = 2;
    public static float enemySpeed = 1;
    public static int playerHealth = 10;
    public static int score= 0;
    public static int totalScore = 0;
    public static int level = 1;
    public static float touchDelay = 0.3f;

    public static void nextLevel(){
        // Increment the level
        level++;

        // Reset score to 0 after each level 
        // but keep total score for the end of the game
        // This gets incremented in the enemy script 
        // when they are destroyed and is never reset
        
        score = 0;

        switch(level){
            case 1: 
                break;
            case 2:
                break;
            case 3: 
                enemyHealth = 4;
                enemySpeed = enemySpeed*1.2f;
                break;
            case 4:
                spawnIncrement = spawnIncrement - spawnIncrement/6f;
                enemySpeed = enemySpeed*1.1f;
                break;
            default:
                spawnIncrement = spawnIncrement - spawnIncrement/6f;
                enemySpeed = enemySpeed*1.1f;
                break;
        }

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    
}
