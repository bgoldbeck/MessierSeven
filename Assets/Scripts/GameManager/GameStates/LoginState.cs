using UnityEngine;
using UnityEngine.UI;
using System.Collections;

using Sfs2X;
using Sfs2X.Core;
using Sfs2X.Entities;
using Sfs2X.Entities.Data;
using Sfs2X.Requests;
using Sfs2X.Logging;

public class LoginState : GameState {
    private float  loginTimer   = 0.5f;
	private Network network = null;
	void Awake() {
	}

	void Start() {
		network = gameObject.GetComponent<Network>();
		GUI gui = GameObject.FindGameObjectWithTag("GUI").GetComponent<GUI>();
		if (gui != null) {
			gui.chat.gameObject.SetActive(false);
			gui.optionsMenu.gameObject.SetActive(false);
			gui.characterStatus.gameObject.SetActive(false);
			gui.loginMenu.gameObject.SetActive(true);
		}
		else {
			Debug.LogError("Cannot find GUI instance");
		}
	}

    void Update() {
        loginTimer -= Time.deltaTime;

		if (network.IsPlayerLoggedIn()) {
			//game.PopState();
			GameManager gameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
			if (gameManager != null) {
				gameManager.ChangeState(GameStates.PLAY_STATE.ToString());
			}
			else {
				Debug.LogError("Cannot reference GameManager");
			}
			Application.LoadLevel("Scn_World"); //TODO: Probably character select screen later on 
		}

		if (loginTimer <= 0f) {

            if (network != null && !network.IsPlayerLoggedIn()) { 
				network.ConnectToSmartFox(network.ip);
                Debug.Log("Connecting... " + Time.timeSinceLevelLoad);
                loginTimer = 15f; //Reset
            }
			

        }
	}
}
		


