using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Door_Button : MonoBehaviour, IInteractable
{
    private Renderer buttonRenderer;

    [SerializeField] Material button_Deactive;      // Kapý kapalý ise kýrmýzý material
    [SerializeField] Material button_Active;        // Kapý açýk ise yeþil material

    private void Awake()
    {
        buttonRenderer = GetComponent<Renderer>();
        buttonRenderer.material = button_Deactive;
    }

    public void Interact()
    {
        // Door_button'a deðildiðinde yapýlacak iþlemler.
        buttonRenderer.material = button_Active;
        
        Transform parent = transform.parent;

        if (parent != null )
        {
            transform.parent = null;
            Destroy(parent.gameObject);
        }
    }
}
