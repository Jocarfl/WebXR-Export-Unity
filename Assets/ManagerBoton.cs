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
        if(panelMenu.activeSelf == true)
        {       
            Off();
        }
        else
        {
            On();
        }
    }

    private void On()
    {
        panelMenu.SetActive(true);
        var boton = _botonMuñeca.gameObject.GetComponent<Renderer>();
        Color colorBoton = new Color(0, 0, 1, 1);
        boton.material.SetColor("_Color",colorBoton);
    }

    private void Off()
    {
        panelMenu.SetActive(false);
        var boton = _botonMuñeca.gameObject.GetComponent<Renderer>();
        Color colorBoton = new Color(0, 0, 0, 0);
        boton.material.SetColor("_Color",colorBoton);
    }
}
