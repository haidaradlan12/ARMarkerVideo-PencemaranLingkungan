using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class UIManager : MonoBehaviour
{
    public RectTransform ButtonTulisan, Button, KIKD, TP, PP, Profil, SoalTulisan, Hasil, Soal1, Soal2, Soal3, Soal4, Soal5, Soal6, Soal7, Soal8, Soal9, Soal10, Soal11, Soal12, Soal13, Soal14, Soal15;    
    // Start is called before the first frame update
    void Start()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0,0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Kembalibutton()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Button.DOAnchorPos(new Vector2(0, 0), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void KIKDbutton()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(0, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void TPbutton()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(0, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void PPbutton()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Profilbutton()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(0, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal1button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal2button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal3button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal4button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal5button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal6button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal7button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal8button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal9button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal10button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal11button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal12button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal13button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal14button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soal15button()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(0, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
    }
    public void Soalevaluasibutton()
    {
        ButtonTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Button.DOAnchorPos(new Vector2(0, -3000), 1.0f);
        KIKD.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        TP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        PP.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Profil.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        SoalTulisan.DOAnchorPos(new Vector2(0, 3000), 1.0f);
        Soal1.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal2.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal3.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal4.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal5.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal6.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal7.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal8.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal9.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal10.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal11.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal12.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal13.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal14.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Soal15.DOAnchorPos(new Vector2(2000, 0), 1.0f);
        Hasil.DOAnchorPos(new Vector2(0, 0), 1.0f);
    }
}
