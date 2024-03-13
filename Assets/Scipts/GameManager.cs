using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int Score; // Score deðiþkeni oluþtur
    public TMP_Text ScoreText; // ScoreText referans

    void Start()
    {
        Score = 0; // Oyun baþladýðýnda Score = 0 yap
        ScoreText.text= Score.ToString(); // int olan score u string yap ve ScoreText üzerine yaz.
    }

    public void UpdateScore() // UpdateScore Fonksiyonu oluþturuldu
    {
        Score++; // Fonksiyon her çaðýrýldýðýnda score deðiþkenini +1 arttýr
        ScoreText.text= Score.ToString(); // ScoreText üzerinde Score deðiþkenini yaz
    }

    public void RestartGame() // Restartgame fonksiyonunu oluþtur
    {
        SceneManager.LoadScene(0); // 0. sahneyi yükle
    }
}
