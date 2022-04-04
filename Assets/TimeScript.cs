using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeScript : MonoBehaviour
{
   
   public TextMesh horaText;
   public TextMesh fechaText;
   public TextMesh horaTextB;
   public TextMesh fechaTextB;
   public System.TimeSpan timeSpan;


    // Update is called once per frame
    void Update()
    {    
        var hora = DateTime.UtcNow.ToLocalTime().ToString("hh:mm");
        var data = DateTime.UtcNow.ToLocalTime().ToString("dd/MM/yy");

        horaText.text = hora;
        fechaText.text = data;

        horaTextB.text = hora;
        fechaTextB.text = data;

    }
}
