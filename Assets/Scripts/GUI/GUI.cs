using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
	//public  GameObject hudCanvasPrefab;
	//public  GameObject loginMenuPrefab;
	//public  GameObject chatPrefab;
	//public  GameObject optionsMenuPrefab;
	//public  GameObject characterStatusPrefab;

	public LoginMenu       loginMenu;
	public Chat        	   chat;
	public OptionsMenu     optionsMenu;
	public CharacterStatus characterStatus;

	//private GameObject login;
	//private GameObject chat;
	//private GameObject optionsMenu;
	//private GameObject characterStatus;

	void Awake() { 
	
		//We'll keep this object around on scene changes.
		DontDestroyOnLoad(this);

		//hudCanvas = transform.Find("HUDCanvas").GetComponent<Canvas>();


		/*
		//The GUI has a canvas.
		if (hudCanvasPrefab != null) {
			canvas      = GameObject.Instantiate(hudCanvasPrefab) as GameObject;
			canvas.name = "HUDCanvas";
			canvas.transform.SetParent(this.transform);
			 
			//The the canvas has a Login Menu child.
			if (loginMenuPrefab != null) {
				//Create the game object.
				login       = GameObject.Instantiate(loginMenuPrefab) as GameObject;
				login.name  = "LoginMenu";
				login.transform.SetParent(canvas.transform);
				//0, 0, 0 the transform.
				login.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 0f, 0f);
				login.SetActive(false);
			}

			//The the canvas has a chat child.
			if (chatPrefab != null) {
				//Create the game object.
				chat       = GameObject.Instantiate(chatPrefab) as GameObject;
				chat.name  = "Chat";
				chat.transform.SetParent(canvas.transform);
				//0, 0, 0 the transform.
				chat.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 0f, 0f);
				chat.SetActive(false);
			}

			//The the canvas has a options menu child.
			if (optionsMenuPrefab != null) {
				//Create the game object.
				optionsMenu       = GameObject.Instantiate(optionsMenuPrefab) as GameObject;
				optionsMenu.name  = "OptionsMenu";
				optionsMenu.transform.SetParent(canvas.transform);
				//0, 0, 0 the transform.
				optionsMenu.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 0f, 0f);
				optionsMenu.SetActive(false);
			}

			//The the canvas has a options menu child.
			if (characterStatusPrefab != null) {
				//Create the game object.
				characterStatus       = GameObject.Instantiate(characterStatusPrefab) as GameObject;
				characterStatus.name  = "CharacterStatus";
				characterStatus.transform.SetParent(canvas.transform);
				//0, 0, 0 the transform.
				characterStatus.GetComponent<RectTransform>().anchoredPosition = new Vector3(0f, 0f, 0f);
				characterStatus.SetActive(false);
			}

		}
			*/
	}

	//Use this for initialization
	void Start() {
	}

	//Update is called once per frame
	void Update() {
	}

	/*
	private GameObject canvas;
	private GameObject login;
	private GameObject chat;
	private GameObject optionsMenu;
	private GameObject characterStatus;

	public GameObject k;
	*/
}
