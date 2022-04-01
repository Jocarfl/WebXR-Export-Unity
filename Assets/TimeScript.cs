using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TimeScript : MonoBehaviour
{
   
   public TextMesh horaText;
   public TextMesh fechaText;
   public System.TimeSpan timeSpan;


    // Update is called once per frame
    void Update()
    {    
        horaText.text = DateTime.UtcNow.ToLocalTime().ToString("hh:mm"); 
        fechaText.text = DateTime.UtcNow.ToLocalTime().ToString("dd/MM/yy");

    }
}
