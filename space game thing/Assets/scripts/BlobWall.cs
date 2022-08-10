using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobWall : MonoBehaviour
{
    public Rigidbody2D body;
    
    public Rigidbody2D playerbody;
    
    bool startSequenceEnded = false;
    
    float t = 0;
    
    //float newtimer = 0;
    
    bool canTP = true;

    private void Update()
    {
        t += Time.deltaTime;

        if (startSequenceEnded == false)
        {
            
            if (t < 12.5)
            {
                body.velocity = new Vector2(2 * t + 8, 0);
            }
            else
            {
                body.velocity = new Vector2(33, 0); //startup sequence max speed
            }
        
        } 

        if (startSequenceEnded == true)
        {
            
            
            if (canTP == true && playerbody.velocity.x < 30) //low speed
            {
                body.position = new Vector2(playerbody.position.x - 30, 0);
                body.velocity = new Vector2(33, 0); //regular max speed
                canTP = false;
                Debug.Log("too slow!");
            }

            
            if(canTP == false && playerbody.position.x - body.position.x > 36)
            {
                body.velocity = new Vector2(0, 0);
                canTP = true;
                Debug.Log("you got away");
            }
        
        }

        
        if (playerbody.position.x - body.position.x > 46 && startSequenceEnded == false)
        {
            
            body.velocity = new Vector2(0, 0);
            startSequenceEnded = true;
            Debug.Log("start sequence ended");
        
        }

    }
}
