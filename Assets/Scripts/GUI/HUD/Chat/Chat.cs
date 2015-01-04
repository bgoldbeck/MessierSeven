using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class Chat : MonoBehaviour {
    public  float          backgroundAlpha = 0.6f;
    public  InputField     inputField;
    public  Text           chatText;
    private InputChatState currentState;

	//Use this for initialization.
	void Start() {
        gameObject.transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(5f, 40f, 0f);
        gameObject.GetComponent<Image>().color                              = new Color(1f, 1f, 1f, backgroundAlpha);
        inputField.gameObject.GetComponent<Image>().color                   = new Color(1f, 1f, 1f, backgroundAlpha);
        currentState                                                        = new InactiveChatInput(this);

        if (inputField != null) { 
            inputField.text = "Lorem Ipsum";
        }

        transform.FindChild("Scrollbar").gameObject.SetActive(false);
		gameObject.SetActive(false);
        return;
	}
	
	//Update is called once per frame.
	void Update() {
        currentState.UpdateInputEvents();
        return;
    }
    
    public void ChangeState(InputChatState state) {
        currentState = state;
        return;
    }
}
