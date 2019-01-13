using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class mapMoving : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] GameObject player;
    


    Vector3 startPosition;
  
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "PlayerCheck")
        {
            if (!player.GetComponent<Player>().mapMoving)
            {
                
                        MoveRight();
                CountDown.timer += 10;
            }
        }
    }

 
   private void MoveRight()
   {
   startPosition = map.transform.position+ new Vector3(10,0,-10);
   player.transform.position = player.transform.position + new Vector3(4, 0, 0);
   map.transform.position = startPosition;                 
   }
}
