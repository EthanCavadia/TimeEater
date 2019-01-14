using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class mapMoving : MonoBehaviour
{
    [SerializeField] GameObject map;
    [SerializeField] GameObject player;
    float TileSizeX = 0f;
    float TileSizeY = 10f;
    float waitForSeconds = 0.005f;
    float playerMoveX = 0.165f;
    float playerMoveY = 0.155f;


    [SerializeField] TriggerPosition triggerPosition;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player")
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
   player.transform.position = player.transform.position + new Vector3(3, 0, 0);
   map.transform.position = startPosition;                 
   }
}
