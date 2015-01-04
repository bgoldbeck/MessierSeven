using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class WidgetFocus : MonoBehaviour, IPointerDownHandler {
    private RectTransform widget;

    void Awake () {
        widget = GetComponent<RectTransform>();  
    }

	public void OnPointerDown (PointerEventData data) {
        if(widget == null) { return; }

        widget.SetAsLastSibling();
        return;
    }

}