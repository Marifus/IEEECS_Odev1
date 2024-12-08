using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elmaHareket : MonoBehaviour
{
    public GameObject obje;
    public bool hareket;

    void Awake()
    {
        obje = GameObject.Find("obje");
        hareket = true;
        GetComponent<Rigidbody>().useGravity = false;
    }
    

    void Update()
    {
        if (hareket)
        {
            transform.position = obje.transform.position;
        }

        if (Input.GetKey(KeyCode.E))
        {

            GetComponent<Rigidbody>().useGravity = true;
            hareket = false;

        }
    }
}