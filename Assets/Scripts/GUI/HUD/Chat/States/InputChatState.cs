using UnityEngine;
using System.Collections;

public abstract class InputChatState {
    protected Chat chat = null;
    
    public InputChatState(Chat chat) { 
        this.chat = chat;
        return;
    }

    abstract public void UpdateInputEvents();
}
