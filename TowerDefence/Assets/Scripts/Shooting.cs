using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public GameObject shot;
   private Transform playerPos;
   Touch touch;


   void Start(){
       playerPos = GetComponent<Transform>();
   }

    // Update is called once per frame
    void Update()
    {

        // Dont allow player to shoot if game is paused
        if(PauseMenu.gameIsPaused == false){
            
            if(Input.GetMouseButtonDown(0)){
                Instantiate(shot, playerPos.position, Quaternion.identity);
            }
        }
        

        
    }
}
