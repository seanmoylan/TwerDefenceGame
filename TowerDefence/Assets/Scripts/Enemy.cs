using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public int health;
    public int hitNum = 0;
    public GameObject effect;
    private Transform playerPos;
    private Player player;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        health = LevelManager.enemyHealth;
        speed = LevelManager.enemySpeed;
        //spriteRenderer.color = new Color(22,22,22);
    }

    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        
        if(other.CompareTag("Wall")){
            // Player losses health 
            player.health--;
            Destroy(gameObject);

        }

        if(other.CompareTag("Projectile")){
            // Indicate to player that the enemy has been hit by changing the colour
            hitNum++;
            if(hitNum == 1){
                // Change enemy colour to indicate it has been hit
                spriteRenderer.color = new Color(255,0,0);

            }else if(hitNum == 2){
                spriteRenderer.color = new Color(0,255,0);
            }else if(hitNum == 3){
                spriteRenderer.color = new Color(100,100,100);
            }



            // Enemy looses health if hit by a projectile
            health--;

            if(health == 0){
                LevelManager.score++; 
                LevelManager.totalScore++;
            }
            
            Debug.Log("Player Score = "+player.score);

            // Destroy the projectile when it has hit the enemy
            Destroy(other.gameObject);

            
            // Once enemy health gets to 0 destroy it
            if(health <= 0){
                Destroy(gameObject);
            }
            
        }

        
    }

    void OnDestroy()
    {
        Debug.Log("OnDestroyEnemyScript");
    }
}
