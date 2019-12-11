using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public float speed;
    public int health;
    public GameObject effect;
    private Transform playerPos;
    private Player player;
    private WallScript wall;
    SpriteRenderer spriteRenderer;

    void Start(){
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
        playerPos = GameObject.FindGameObjectWithTag("Player").transform;
        health = LevelManager.enemyHealth;
        //spriteRenderer.color = new Color(22,22,22);
    }

    void Update(){
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);

    }

    void OnTriggerEnter2D(Collider2D other){
        
        /*
        if(other.CompareTag("Player")){
            // Player Losses Health
            player.health--;
            Debug.Log("Player lost health = "+player.health);
            Destroy(gameObject);
        }
        */
        if(other.CompareTag("Wall")){
            // Player losses health 
            player.health--;
            Destroy(gameObject);

        }

        if(other.CompareTag("Projectile")){

            // Enemy looses health if hit by a projectile
            health--;

            if(health == 0){
                LevelManager.score++; 
            }
            
            Debug.Log("Player Score = "+player.score);

            Destroy(other.gameObject);

            
            spriteRenderer.color = new Color(255,0,0);

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
