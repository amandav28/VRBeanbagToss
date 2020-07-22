using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionHole : MonoBehaviour
{
    public GameController gameController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Beanbag")
        {
            gameController.scoreAdd("Hole");
        }
    }

}
