using UnityEngine;
using System.Collections;

public sealed class GameStates {
	
	private readonly string name;
	private readonly int    value;
	
	public static readonly GameStates LOGIN_STATE = new GameStates (1, "LoginState");
	public static readonly GameStates MENU_STATE  = new GameStates (2, "MenuState");
	public static readonly GameStates PLAY_STATE  = new GameStates (3, "PlayState");        
	
	private GameStates(int value, string name){
		this.name  = name;
		this.value = value;
	}
	
	public override string ToString(){
		return name;
	}

	public int ToValue() {
		return value;
	}
}

public abstract class GameState : MonoBehaviour {
}
