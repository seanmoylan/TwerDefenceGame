using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Touch touch;
    Vector2 targetPosition;

    void Start(){
        // Get target position based on mouse input
        //if (Input.)
        targetPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        // Get user input from a touch device
        
    }

    void Update(){

        // Vector2.moveTowards takes in the stating position, ending position and speed in which to travel at
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    

        // Checks to see if the projectile is close to the position then destroys it
        if(Vector2.Distance(transform.position, targetPosition) < 0.2){
            Destroy(gameObject);
        }
    }
}
