using UnityEngine;
using WebXR;
using System.Collections;
using System.Collections.Generic;

  public class GestoAbrirMenu : MonoBehaviour
  {

      public WebXRController controllerL;
      public Canvas canvas;
      

       void Update() {

           if(controllerL.isHandActive)
           {
               if(canvas.gameObject.activeSelf == false)
               {
                    On();
               }
               else
               {
                   Off();
               }
           }
        }

        private void On(){
              
            if(controllerL.GetButtonDown(WebXRController.ButtonTypes.Trigger))
            {
                canvas.gameObject.SetActive(true);
            }
        }

        private void Off(){

            if(controllerL.GetButtonDown(WebXRController.ButtonTypes.Trigger))
            {
                canvas.gameObject.SetActive(false);
            }
        }
    }

