using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraHareket : MonoBehaviour
{
    public GameObject obje;
    void Update()
    {
        transform.position = obje.transform.position + new Vector3(0, 2, 0);
    }
}
