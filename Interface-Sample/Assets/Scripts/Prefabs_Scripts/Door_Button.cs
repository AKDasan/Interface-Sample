using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Door_Button : MonoBehaviour, IInteractable
{
    private Renderer buttonRenderer;

    [SerializeField] Material button_Deactive;      // Kap� kapal� ise k�rm�z� material
    [SerializeField] Material button_Active;        // Kap� a��k ise ye�il material

    private void Awake()
    {
        buttonRenderer = GetComponent<Renderer>();
        buttonRenderer.material = button_Deactive;
    }

    public void Interact()
    {
        // Door_button'a de�ildi�inde yap�lacak i�lemler.
        buttonRenderer.material = button_Active;
        
        Transform parent = transform.parent;

        if (parent != null )
        {
            transform.parent = null;
            Destroy(parent.gameObject);
        }
    }
}
