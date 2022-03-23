using UnityEngine;
using WebXR;
using System.Collections;
using System.Collections.Generic;

  public class GestoAbrirMenu : MonoBehaviour
  {

      public WebXRController controllerR;
      public WebXRController controllerL;
      public Canvas canvas;

      private WebXRHandData handData;
      private WebXRHandJoint handJoint;

      private WebXRJointData jointData;
      

       void Update() {

        if(controllerR.GetButtonDown(WebXRController.ButtonTypes.Trigger) || controllerL.GetButtonDown(WebXRController.ButtonTypes.Trigger)){

            if(canvas.gameObject.activeSelf == false){
                canvas.gameObject.SetActive(true);
            }else
            {
                canvas.gameObject.SetActive(false);
            }
        }
      }
    }

