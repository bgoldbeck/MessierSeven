using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class WidgetDraggable : MonoBehaviour, IDragHandler {
	private RectTransform rectTransform = null;
	
	// Use this for initialization
	void Start() {
		rectTransform = GetComponent<RectTransform>();
	}
	
	public void OnDrag(PointerEventData eventData) {
		rectTransform.position += new Vector3(eventData.delta.x, eventData.delta.y);
		
		// magic : add zone clamping if's here.
	}
}