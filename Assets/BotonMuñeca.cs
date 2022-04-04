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
            StartCoroutine(DesactivarTrigger());
        }       
    }

    //Desactivar collider durante 1s para que no detecte todo el rato que estas pulsando
    private IEnumerator DesactivarTrigger()
    {
        this.gameObject.GetComponent<SphereCollider>().enabled = false;
        yield return new WaitForSeconds(1);
        this.gameObject.GetComponent<SphereCollider>().enabled = true; 
    }
}
