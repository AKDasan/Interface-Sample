using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceHandler : MonoBehaviour
{
    // Bu script player'a atanacak. Eðer deðdiði nesne'de ICollectable'a veya IInteractable'a rastlarsa onun fonksiyonunu çaðýracaktýr.

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out ICollectable collect))
        {
            if (collect != null)
            {
                collect.Collect();
            }           
        }

        if (other.gameObject.TryGetComponent(out IInteractable interact))
        {
            if (interact != null)
            {
                interact.Interact();
            }
        }
    }
}
