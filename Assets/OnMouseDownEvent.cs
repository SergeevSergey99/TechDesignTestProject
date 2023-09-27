using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseDownEvent : MonoBehaviour
{
    [SerializeField] private UnityEvent onMouseDownEvent;
    public void OnMouseDown()
    {
        onMouseDownEvent.Invoke();
    }
}
