using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BotonMuñeca : MonoBehaviour
{
    public UnityEvent onHit;

    private void OnTriggerEnter(Collider other) {
        
        if(other.gameObject.tag == "Player"){

            onHit.Invoke();


        }       

    }




}
