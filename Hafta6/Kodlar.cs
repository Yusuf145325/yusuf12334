using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kodlar : MonoBehaviour
{
 public void CikisButonu()
    {
        Application.Quit();
    }

    public void YeniOyun()
    {
        SceneManager.LoadScene("Orman");

    }

    public void ÝlkSahne()
    {
        SceneManager.LoadScene(0);
    }
    
    public void AraziyeGitme()
    {
        SceneManager.LoadScene(2);
    }
    public void AnaMenü()
    {
        SceneManager.LoadScene(0);
    }
}
