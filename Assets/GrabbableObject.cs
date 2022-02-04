using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GrabbableObject : MonoBehaviour
{
    public GameObject m_snapToObject;
    [SerializeField]
    private bool m_holding = false;

    public void OnGrab(InputAction.CallbackContext context)
    {
        if (context.started == true)
        {
            Debug.Log("Grab Pressed");
            m_holding = !m_holding;
        }
        else if (context.canceled == true)
        {
            Debug.Log("Grab Released");
            m_holding = !m_holding;
        }

    }

    private void FixedUpdate()
    {
        if (m_holding)
        {
            transform.position = m_snapToObject.transform.position;
        }

    }
}
