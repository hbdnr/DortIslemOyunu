using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dortislem : MonoBehaviour
{
    public Text ilksayi,islem,ikincisayi,sonuc,durum;
    public InputField sonucmetini;
    double sayi1, sayi2, islemisareti, islemsonuc;
    // Start is called before the first frame update
    void Start()
    {
        YeniSoru();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void kontrol()
    {
        if (double.Parse(sonuc.text) == islemsonuc)
            durum.text = "DOÐRU";
        else
            durum.text = "YANLIÞ";
    }

    public void YeniSoru()
    {
        sonucmetini.text = "";
        durum.text = "";
        sayi1 = Random.Range(1, 10);
        sayi2 = Random.Range(1, 10);
        islemisareti = Random.Range(1, 5);

        switch (islemisareti)
        {
            case 1:
                islem.text = "+";
                islemsonuc = sayi1 + sayi2;
                break;
            case 2:
                islem.text = "-";
                islemsonuc = sayi1 - sayi2;
                break;
            case 3:
                islem.text = "*";
                islemsonuc = sayi1 * sayi2;
                break;
            case 4:
                islem.text = "/";
                islemsonuc = sayi1 / sayi2;
                break;
        }
        ilksayi.text = sayi1 + "";
        ikincisayi.text = sayi2 + "";
    }

}
