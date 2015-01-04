using UnityEngine;
using System.Collections;

using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using Sfs2X.Logging;

public class Network : MonoBehaviour {
    public string           ip          = "192.168.0.205";
    public int              port        = 9933;
    private bool            isLoggedIn  = false;
    private SmartFox        smartFox    = null;
    private bool            isDebugging = true;
    private readonly string zone        = "MMOZone";


    public Network() {
        smartFox = new SmartFox(isDebugging);
        AddEventListeners();
        if (isDebugging) { 
            smartFox.AddLogListener(LogLevel.DEBUG, OnDebugMessage);
            
        }
    }

    void FixedUpdate() { 
        smartFox.ProcessEvents();
    }

    void OnApplicationQuit() {
        CloseConnection();
        return;
    }


    void OnDebugMessage(BaseEvent evt) { 
        string message = (string)evt.Params["message"];
        Debug.Log("NetworkManager.cs: " + message);
    }

    void OnConnection(BaseEvent evt) { 
        bool success = (bool)evt.Params["success"];
        if (success) {
            Debug.Log("Connected!");
            
        }
        else {
            Debug.Log("Could not connect!");
        }      
    }

    void OnConnectionLost(BaseEvent evt) { 
        isLoggedIn = false;
        return;
    }

    void OnLogin(BaseEvent evt) { 
        isLoggedIn = true;
        Debug.Log("Logged in!");
        return;
    }

    void OnLogout(BaseEvent evt) { 
        Debug.Log("Logged out!");
        isLoggedIn = false;
        return;
    }

    void OnLoginError(BaseEvent evt) { 
        Debug.Log("Login failure: " + (string)evt.Params["errorMessage"]);
        return;
    }

    public void AddEventListeners() { 
        smartFox.AddEventListener(SFSEvent.CONNECTION, OnConnection);
        smartFox.AddEventListener(SFSEvent.CONNECTION_LOST, OnConnectionLost);
        smartFox.AddEventListener(SFSEvent.LOGIN, OnLogin);
        smartFox.AddEventListener(SFSEvent.LOGOUT, OnLogout);
        smartFox.AddEventListener(SFSEvent.LOGIN_ERROR, OnLoginError);
        
    }

    public void CloseConnection() {
        if (smartFox.IsConnected) {
            smartFox.Disconnect();
            //smartFox.RemoveAllEventListeners();
            
        }
        isLoggedIn = false;
        return;
    }

    public SmartFox GetSmartFoxConnection() { 
        return smartFox;
    }

    public bool IsPlayerLoggedIn() { 
        return isLoggedIn;
    }

    public void ConnectToSmartFox(string ip) { 
		smartFox.Connect(ip, port);
    }

    public void SendLoginRequest(string username, string password) { 
        smartFox.Send(new LoginRequest(username, password, zone));
    }

}
