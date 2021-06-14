using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public float PressDownTimer; 
    private bool PressDown;
    public UnityEvent onLongClick; 
    [SerializeField]
    public float HoldTime;
    public void OnPointerDown(PointerEventData eventData)
    {
        PressDown = true;
        Debug.Log("PressDown");
    }
    public void OnPointerUp(PointerEventData eventData)
    {
        PressDown = false;
        PressDownTimer = 2;
        Debug.Log("PressUp");
    }
    void Update()
    {
        if (PressDown == true)
        {
            PressDownTimer += Time.deltaTime;
            if (PressDownTimer >= HoldTime)
            {
                if (onLongClick != null)
                {
                    onLongClick.Invoke();
                }
                PressDownTimer = 0;
            }
        }
    }
    public void Hold(Slot slot)
    {
        InventoryManager.useItem(slot);
        Debug.Log("Hold");
    }
}
