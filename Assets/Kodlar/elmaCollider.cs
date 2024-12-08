using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elmaCollider : MonoBehaviour
{
    public GameObject sepetPrefab;
    public GameObject elmaPrefab;
    public canskor canskor;
    public int can;
    public int skor;
    public GameObject Elma;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("sepet"))
        {
            canskor.SkorArtir();
            Destroy(Elma);
            Destroy(other.gameObject);
            spawnSepet();
            spawnElma();
        }

        if (other.CompareTag("zemin"))
        {
            canskor.CanAzalt();
            Destroy(Elma);
            spawnElma();
        }
    }
    public void spawnSepet()
    {
        float konumx = Random.Range(-18, 18);
        float konumz = Random.Range(-18, 18);
        Instantiate(sepetPrefab, new Vector3(konumx, 0, konumz), Quaternion.identity);
    }
    public void spawnElma()
    {
        Instantiate(elmaPrefab, new Vector3(0, 22, 0), Quaternion.identity);
    }
}
