using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Collections;

[ExecuteInEditMode]
public class LoginMenu : MonoBehaviour {
    public Text usernameText;
	public Text passwordText;

	void Awake() { 
		transform.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 0f, 0f);
		gameObject.SetActive(false);

    }

	void Start() {
	}
	
	void Update() {
	}
    
    public void AttemptLogin() {

		if(usernameText.text != null && passwordText.text != null) { 
			Debug.Log("User: " + usernameText.text);
			Debug.Log("Pass: " + passwordText.text);
			GameObject gameManager = GameObject.FindGameObjectWithTag("GameManager");
			if (gameManager != null) {
				Network network = gameManager.GetComponent<Network>();
				network.SendLoginRequest(usernameText.text, passwordText.text);
			}
			else {
				Debug.LogError("Cannot find GameManager instance.");
			}
        }
        return;
    }
}
