using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float kuvvet; // Zýplama kuvveti
    private Rigidbody2D rb; // Rigidbody referans
    
    public GameManager gameManager; // GameManager referans
    public GameObject Death; // DeathScreen Referans

    void Start()
    {
        Time.timeScale = 1f; // Oyun baþladýðýnda Zaman akýþ hýzýný 1 yap
        rb = GetComponent<Rigidbody2D>(); // Referans
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Eðer fare üzerinde sol click yapýlýrsa veya dokunmatik ekranda click yapýlýrsa parantez içini çalýþtýr.
        {
            rb.velocity = Vector2.up * kuvvet; // karakterin rigidbody sine yukarý yönde kuvvet deðiþkenini ekle
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // Tetikleme gerçekleþirse
    {
        if(collision.gameObject.name=="Score") // tetikleyen objenin adý Score ise..
        {
            gameManager.UpdateScore(); // GameManager üzerindeki UpdateScore fonksiyonunu çalýþtýr.
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // Çarpýþma olursa
    {
        if(collision.gameObject.tag=="Engel") // ve çarpýþýlan objenin tagý Engel ise..
        {
            Time.timeScale = 0f; // Zamaný durdur.
            Death.SetActive(true); // Ölüm ekranýnýn görünürlüðünü aktif et.
        }
    }
}
