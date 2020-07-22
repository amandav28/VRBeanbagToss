using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentController : MonoBehaviour
{
    public GameObject Nature;
    public GameObject White;
    // Start is called before the first frame update
    void Start()
    {
        Nature.gameObject.SetActive(true);
        White.gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void NatureCalled()
    {
        Nature.gameObject.SetActive(true);
        White.gameObject.SetActive(false);
    }

    public void WhiteCalled()
    {
        Nature.gameObject.SetActive(false);
        White.gameObject.SetActive(true);
    }
}
