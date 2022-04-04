using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerBoton : MonoBehaviour
{   
    [Header("ReferenceEquals")]
    [SerializeField] BotonMuñeca _botonMuñeca;
    public GameObject panelMenu;
    public TextMesh textHoraB;
    public TextMesh textFechaB;

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
        Color colorBoton = new Color(0.3294118f, 0.454902f, 0.654902f, 1);
        boton.material.SetColor("_Color",colorBoton);
        textHoraB.gameObject.SetActive(false);
        textFechaB.gameObject.SetActive(false);
    }

    private void Off()
    {
        panelMenu.SetActive(false);
        var boton = _botonMuñeca.gameObject.GetComponent<Renderer>();
        Color colorBoton = new Color(0.07843138f, 0.1098039f, 0.1647059f, 1);
        boton.material.SetColor("_Color",colorBoton);
        textHoraB.gameObject.SetActive(true);
        textFechaB.gameObject.SetActive(true);
    }
}
