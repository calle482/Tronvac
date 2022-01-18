using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;



public class MenuTextHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    // Gör texten vit när man håller över den med muspekaren
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        GetComponent<TextMeshProUGUI>().color = Color.white;
    }
    // Gör texten orange när man tar bort muspekaren från texten
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        GetComponent<TextMeshProUGUI>().color = new Color32(255, 143, 23, 255);
    }

}
