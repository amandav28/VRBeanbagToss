using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class collisionBoard : MonoBehaviour
{
    public GameController gameController;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beanbag")
        {
            gameController.scoreAdd("Board");
        }
    }
}
