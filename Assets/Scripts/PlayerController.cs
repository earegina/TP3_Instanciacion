using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int playerLives = 10;
    public float speedPlayer = 10.0f;
       
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        //MovePlayer();
    }

    /*public void MovePlayer(){
        transform.Translate(speedPlayer * Time.deltaTime * Vector3.right);
    }*/

    public void PlayerHealing(int healing) 
    {
        playerLives += healing;

    }

    public void PlayerDamage(int damage) 
    {
       playerLives -= damage;
    }
    
}
