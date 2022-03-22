using UnityEngine;
using WebXR;
using System.Collections;
using System.Collections.Generic;

  public class GestoAbrirMenu : MonoBehaviour
  {

      public WebXRController controller;
      public Canvas canvas;
      

       void Update() {

        if(controller.GetButtonDown(WebXRController.ButtonTypes.Trigger)){

            if(canvas.gameObject.activeSelf == false){
                canvas.gameObject.SetActive(true);
            }else
            {
                canvas.gameObject.SetActive(false);
            }

        }
        

      }

    }

