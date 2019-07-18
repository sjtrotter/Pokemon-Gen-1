using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     Vector3 pos;                   // For movement
    public float speed = 2.0f;      // Speed of movement
     
     void Start () {
         pos = transform.position;  // Take the initial position
     }
 
     void FixedUpdate () {

         float moveHorizontal = Input.GetAxis ("Horizontal");

         float moveVertical = Input.GetAxis ("Vertical");

         if(moveHorizontal < 0 && transform.position == pos) {        // Left
             pos += Vector3.left;
         }
         if(moveHorizontal > 0 && transform.position == pos) {        // Right
             pos += Vector3.right;
         }
         if(moveVertical > 0 && transform.position == pos) {        // Up
             pos += Vector3.up;
         }
         if(moveVertical < 0 && transform.position == pos) {        // Down
             pos += Vector3.down;
         }
         transform.position = Vector3.MoveTowards(transform.position, pos, Time.deltaTime * speed);    // Move there
     }
}
