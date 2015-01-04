using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class ActiveInputChat : InputChatState {
    public ActiveInputChat(Chat chat) : base(chat) { 
    }

    public override void UpdateInputEvents() { 
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter)) {
            if (chat.inputField.text != "") { 
            
                //Insert the new chatline into chat window.
                chat.chatText.text += ("\n" + chat.inputField.text);

                chat.inputField.text = "";
                chat.inputField.DeactivateInputField();
                
                EventSystem.current.SetSelectedGameObject(null, null);
                //chat.ChangeState(new InactiveState(chat));
            }
            
            
        }
        if (chat.inputField.isFocused == false && Input.anyKey == false) { 
                
                chat.ChangeState(new InactiveChatInput(chat));
            
                chat.gameObject.transform.FindChild("Scrollbar").gameObject.SetActive(false);
                //return;
        }
        return;
    }

	// Update is called once per frame
	//void override Update () {
        //Debug.Log("Input State");
     /*
	 if (inputField != null) { 
            if (inputField.isFocused) {
                Debug.Log(inputField.isFocused);
                if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter)) {
                    if (true) {
                        //Send Text.
                        Debug.Log("Send: " + inputField.GetComponentInChildren<Text>().text);
                        inputField.GetComponentInChildren<Text>().text = "";
                        inputField.DeactivateInputField();
                    }
                }
            }
            else {
                if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter)) {
                    //Set Active;
                    Debug.Log("active");
                    EventSystem.current.SetSelectedGameObject(inputField.gameObject, null);
                    inputField.OnPointerClick(new PointerEventData(EventSystem.current));
                }
            }
        }
        */
	//}
         
}
