using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.XR;

public class BeanBag : MonoBehaviour
{

    // Start is called before the first frame update
   public void Thrown()
    {
        bagsController.Instance.BagOnDeck();
        this.gameObject.layer = 2;
    }
}
