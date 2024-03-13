using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Borular : MonoBehaviour
{
    public float hiz; // Borularýn hareket hýzý

    private void Start()
    {
        Destroy(gameObject,10); // 10 Saniye sonra sil
    }

    void Update()
    {
        transform.position += Vector3.left * hiz * Time.deltaTime; // Fiziksel Hareket kodu
    }
}
