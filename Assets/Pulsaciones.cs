using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Pulsaciones : MonoBehaviour
{
    public TextMesh pulsacionesText;
    public List<Sprite> emoji = new List<Sprite>();
    public GameObject notificacion;
    public Transform cameraFollower;
    public SpriteRenderer emojiRender;
    public float tiempo = 50f;

    // Update is called once per frame
    void Update()
    {
        tiempo = tiempo + 10 * Time.deltaTime;
        pulsacionesText.text = "" + tiempo.ToString("f0");

        if(tiempo >= 160)
        {
            BorrarNotificacion();
            tiempo = 50f;
        }

        if(tiempo > 50 && tiempo < 90)
        {         
            CambiarEmoji(emoji[0]);
        }

        if(tiempo > 90 && tiempo < 120)
        {         
            CambiarEmoji(emoji[1]);
        }

        if(tiempo > 120 && tiempo < 160)
        {         
            CambiarEmoji(emoji[2]);
            MostrarNotificacion();        
        }
    }

    private void CambiarEmoji(Sprite emoji)
    {
        emojiRender.sprite = emoji;
    }

    private void MostrarNotificacion()
    {
        notificacion.SetActive(true);            
    }

    private void BorrarNotificacion()
    {
        notificacion.SetActive(false);
    }


}
