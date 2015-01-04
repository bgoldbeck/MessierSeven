using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager : MonoBehaviour {
    //Persistant game variables.
	 
    public    	   Vector2     minimumScreenSize = new Vector2(1280f, 1024f);
	private        string      currentState      = null;
	private static GameManager instance          = null;
    
    
    void Awake() {
        //Make this game object and all its transform children survive when loading a new scene.
        if (instance == null) {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else {
            //There can be only one!
            if (this != instance) {
                Destroy(transform.gameObject);
            }
        }
		//When we start, we begin in the login state. Always.
		ChangeState(GameStates.LOGIN_STATE.ToString());
    }

	//Use this for initialization
	void Start() {
		//Application.LoadLevel("Scn_World");
        return;
	}
	
	//Update is called once per frame
	void Update() {
		if (Screen.width < minimumScreenSize.x) {
			Screen.SetResolution((int)minimumScreenSize.x, Screen.height, Screen.fullScreen);
        }
		if (Screen.height < minimumScreenSize.y) { 
			Screen.SetResolution(Screen.width, (int)minimumScreenSize.y, Screen.fullScreen);
        }
        return;
	}

    void FixedUpdate() { 
    }

    void OnApplicationQuit() {
        return;
    }

    public void ChangeState(string state) {
		if (currentState != null) {
			Destroy(gameObject.GetComponent(currentState));
		}
		gameObject.AddComponent(state);
		currentState = state;
        return;
    }

    //public Network Network() { 
        //return network;
    //}

    //public Stack<GameObject> States {
        //get { return states; }
        //set { states = value; }
    //}

    //public void ResetNetworkingContext() { 
        //network = new Network();
        //return;
    //}

    public void ChangeScene(string name) { 
    }
}
