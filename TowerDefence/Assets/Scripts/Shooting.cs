﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public GameObject shot;
   private Transform playerPos;

   void Start(){
       playerPos = GetComponent<Transform>();
   }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Animation.
            Instantiate(shot, playerPos.position, Quaternion.identity);
        }else{

        }
        
    }
}
