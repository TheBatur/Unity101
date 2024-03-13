using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score; // Score de�i�keni olu�tur
    public TMP_Text ScoreText; // ScoreText referans

    void Start()
    {
        Score = 0; // Oyun ba�lad���nda Score = 0 yap
        ScoreText.text= Score.ToString(); // int olan score u string yap ve ScoreText �zerine yaz.
    }

    public void UpdateScore() // UpdateScore Fonksiyonu olu�turuldu
    {
        Score++; // Fonksiyon her �a��r�ld���nda score de�i�kenini +1 artt�r
        ScoreText.text= Score.ToString(); // ScoreText �zerinde Score de�i�kenini yaz
    }

    public void RestartGame() // Restartgame fonksiyonunu olu�tur
    {
        SceneManager.LoadScene(0); // 0. sahneyi y�kle
    }
}
