using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

public class InactiveChatInput : InputChatState {
    
    public InactiveChatInput(Chat chat) : base(chat) { 
    }

    public override void UpdateInputEvents() { 
        if (Input.GetKeyUp(KeyCode.Return) || Input.GetKeyUp(KeyCode.KeypadEnter)) {
            //Set Active;
            EventSystem.current.SetSelectedGameObject(chat.inputField.gameObject, null);
            chat.inputField.OnPointerClick(new PointerEventData(EventSystem.current));

            chat.ChangeState(new ActiveInputChat(chat));
            
            chat.gameObject.transform.FindChild("Scrollbar").gameObject.SetActive(true);
        }
    }
}
