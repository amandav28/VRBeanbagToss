using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IDCollision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision hit)
    {

        Debug.Log(this.gameObject.name + " just hit " + hit.gameObject.name);
    }
}
