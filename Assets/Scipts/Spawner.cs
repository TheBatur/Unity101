using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Borular; // Spawn olacak olan obje referans

    public float yukseklik; // Yukseklik pay�
    public float SpawnHiz; // olu�turma bekleme s�resi


    void Start()
    {
        StartCoroutine(SpawnObject(SpawnHiz)); // Oyun ba�lad���nda SpawnObject fonksiyonunu �al��t�r
    }

    public IEnumerator SpawnObject(float time)
    {
        while (true) // Bu i�lemi s�rekli tekrarla
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-yukseklik, yukseklik), 0), Quaternion.identity); // Spawn i�lemi
            yield return new WaitForSeconds(time); // Bekleme s�resi
        }

    }
}
