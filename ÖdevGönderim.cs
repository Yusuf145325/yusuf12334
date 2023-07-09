using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ÖdevGönderim : MonoBehaviour
{
    void Bolenleribul(int ilksayi, int ikincisayi)
    {
        List<int> Listeadi = new();
        List<int> İkiyeBölünenler = new();
        List<int> Ücebölünenler = new ();
        List<int> Dördebölünenler = new ();
        List<int> Beşebölünenler = new();

        for(int i = ilksayi; i <=ikincisayi; i++)
        {
            Listeadi.Add(i);

            if (i % 2 ==0 )
            {
                İkiyeBölünenler.Add(i);

            }

            if(i % 3 ==0 )
            {
                Ücebölünenler.Add(i);

            }

            if(i % 4 == 0 )
            {
                Dördebölünenler.Add(i);

            }

            if (i % 5 == 0)
            {
                Beşebölünenler.Add(i);
            }
        }


        foreach (int eleman in Listeadi)
        {
            print("Listemdeki bütün elemanlar " + eleman);

        }

        foreach (int iki in İkiyeBölünenler)
        {
            print("İkiye Bölünenler Şu Şekildedir " + iki);
        }

        foreach (int üç in Ücebölünenler)
        {
            print("Üçe bölünenler şu şekildedir " + üç);
        }

        foreach (int dört in Dördebölünenler)
        {
            print("Dörde Bölünenler şu şekildedir " + dört);
        }

        foreach (int beş in Beşebölünenler)
        {
            print("Beşe bölünenler şu şekildedir " + beş);
        }



    }
    void Start()
    {
        Bolenleribul(10, 30);
    }



}
