using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBoton : MonoBehaviour
{   
    [Header("ReferenceEquals")]
    [SerializeField] BotonMuñeca _botonMuñeca;
    public GameObject panelMenu;

    private void OnEnable() {

        _botonMuñeca.onHit.AddListener(_RegisterHit);
  
    }

    private void OnDisable() {
        _botonMuñeca.onHit.RemoveListener(_RegisterHit);

    }

    void _RegisterHit()
    {
        if(panelMenu.activeSelf == true){
            panelMenu.SetActive(false);
        }
        
        if(panelMenu.activeSelf == false)
        {
            panelMenu.SetActive(true);
        }
        

    }
}
