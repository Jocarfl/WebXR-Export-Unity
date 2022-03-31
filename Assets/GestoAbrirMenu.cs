using UnityEngine;
using WebXR;
using System.Collections;
using System.Collections.Generic;

  public class GestoAbrirMenu : MonoBehaviour
  {

      public WebXRController controllerL;
      public WebXRController controllerR;
      public Canvas menuHUD;
      public Canvas menuSpace;

      public Transform  cameraFollower;
      

       void Update()
       {
           if(controllerL.isHandActive)
           {
               if(menuHUD.gameObject.activeSelf == false)
               {
                    ShowMenuHUD();
               }
               else
               {
                   HideMenuHUD();
               }
           }

           if(controllerR.isHandActive)
           {
              
           }


        }

        private void ShowMenuHUD()
        {    
            if(controllerL.GetButtonDown(WebXRController.ButtonTypes.Trigger))
            {
                menuHUD.gameObject.SetActive(true);
            }
        }

        private void HideMenuHUD()
        {
            if(controllerL.GetButtonDown(WebXRController.ButtonTypes.Trigger))
            {
                menuHUD.gameObject.SetActive(false);
            }
        }

        private void StartMenu()
        {
            if(controllerR.GetButtonDown(WebXRController.ButtonTypes.Trigger))
            {
                //Instantiate(menuSpace,);
            }
        }
    }

