using UnityEngine;
using System.Collections;

public class PlayState : GameState {
    private bool menuOpened = false;
    //private float logoutTimer = 10f;

	public void Start() {
		GUI gui = GameObject.FindGameObjectWithTag("GUI").GetComponent<GUI>();
		if (gui != null) {
			gui.chat.gameObject.SetActive(true);
			gui.optionsMenu.gameObject.SetActive(true);
			gui.characterStatus.gameObject.SetActive(true);
			gui.loginMenu.gameObject.SetActive(false);
		}
	}

    public void Update() {     
        
        if (Input.GetKeyDown(KeyCode.Escape)) {
            menuOpened = !menuOpened;
            if (menuOpened) {
                //game.PushState("MenuState");
            }
            else { 
                //game.PopState();
            }
        }
        /*
        if (game.Network().IsPlayerLoggedIn() == false) {
            logoutTimer -= Time.deltaTime;
            if (logoutTimer <= 0f) { 
                //if (this.transform.root.Find("MenuState")) { 
                    //game.PopState();
                //}
                Destroy(game);
                //game.PopState();
                //game.PushState("LoginState");
                //game.ResetNetworkingContext();
                Application.LoadLevel("Scn_Login");
            }
        }
         * */
        return;
    }
}
