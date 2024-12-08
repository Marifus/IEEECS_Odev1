using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class objehareket : MonoBehaviour
{
    public float hiz;
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, 1) * hiz * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -1) * hiz * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-1, 0, 0) * hiz * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(1, 0, 0) * hiz * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = transform.position + new Vector3(0, 1, 0) * hiz * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftControl))
        {
            transform.position = transform.position + new Vector3(0, -1, 0) * hiz * Time.deltaTime;
        }

    }
}
