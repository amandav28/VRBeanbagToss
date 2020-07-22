using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bagsController : Singleton<bagsController>
{
    //private int beanbagcount = 0;

    public GameObject BeanBag;
    public GameObject interactionTable;
    public Transform ondecklocation;
    public GameObject[] beanbags;

    public void BagOnDeck()
    {
        var bean = Instantiate(BeanBag, ondecklocation.position, ondecklocation.rotation);
        bean.transform.SetParent(interactionTable.transform);
       // beanbagcount++;
    }

    public void DestroyAllBeanbags()
    {
        beanbags = GameObject.FindGameObjectsWithTag("Beanbag");
        foreach (GameObject Beanbag in beanbags)
            GameObject.Destroy(Beanbag);
        //beanbagcount = 0;
    }
}
