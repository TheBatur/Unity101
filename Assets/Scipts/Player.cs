using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float kuvvet; // Z�plama kuvveti
    private Rigidbody2D rb; // Rigidbody referans
    
    public GameManager gameManager; // GameManager referans
    public GameObject Death; // DeathScreen Referans

    void Start()
    {
        Time.timeScale = 1f; // Oyun ba�lad���nda Zaman ak�� h�z�n� 1 yap
        rb = GetComponent<Rigidbody2D>(); // Referans
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // E�er fare �zerinde sol click yap�l�rsa veya dokunmatik ekranda click yap�l�rsa parantez i�ini �al��t�r.
        {
            rb.velocity = Vector2.up * kuvvet; // karakterin rigidbody sine yukar� y�nde kuvvet de�i�kenini ekle
        }
    }

    private void OnTriggerEnter2D(Collider2D collision) // Tetikleme ger�ekle�irse
    {
        if(collision.gameObject.name=="Score") // tetikleyen objenin ad� Score ise..
        {
            gameManager.UpdateScore(); // GameManager �zerindeki UpdateScore fonksiyonunu �al��t�r.
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) // �arp��ma olursa
    {
        if(collision.gameObject.tag=="Engel") // ve �arp���lan objenin tag� Engel ise..
        {
            Time.timeScale = 0f; // Zaman� durdur.
            Death.SetActive(true); // �l�m ekran�n�n g�r�n�rl���n� aktif et.
        }
    }
}
