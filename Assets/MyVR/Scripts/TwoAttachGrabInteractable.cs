using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace MyVR
{   
    /// <summary>
    ///  잡히는 오브젝트의 잡히는 위지가 왼쪽과 오른쪽 다른게 있는 경우
    /// </summary>
    public class TwoAttachGrabInteractable : XRGrabInteractable
    {
        #region Variables
        //잡히는 위치
        public Transform leftAttactTransform;
        public Transform rightAttactTransform;
        #endregion

        #region Unity Event Method
         protected override void OnSelectEntered(SelectEnterEventArgs args)
        {
            if (args.interactorObject.transform.CompareTag("LeftHand"))
            {
                attachTransform = leftAttactTransform;
            }
            else if (args.interactableObject.transform.CompareTag("RightHand"))
            { 
                attachTransform = rightAttactTransform;
            }

            base.OnSelectEntered(args);
        }
        #endregion
    }
}