using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Borular; // Spawn olacak olan obje referans

    public float yukseklik; // Yukseklik payý
    public float SpawnHiz; // oluþturma bekleme süresi


    void Start()
    {
        StartCoroutine(SpawnObject(SpawnHiz)); // Oyun baþladýðýnda SpawnObject fonksiyonunu çalýþtýr
    }

    public IEnumerator SpawnObject(float time)
    {
        while (true) // Bu iþlemi sürekli tekrarla
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity); // Spawn iþlemi
            yield return new WaitForSeconds(time); // Bekleme süresi
        }

    }
}
