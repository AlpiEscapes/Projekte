using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	public Transform menuPanel;
	Event keyEvent;
	Text buttonText;
	KeyCode newKey;

	bool waitingForKey;


	void Start ()
	{
		//Assign menuPanel to the Panel object in our Canvas
		//Make sure it's not active when the game starts
		/*menuPanel = transform.Find("KeybindPanel");
		menuPanel.gameObject.SetActive(true);*/
		waitingForKey = false;


		
		

		for (int i = 0; i < menuPanel.childCount; i++)
		{
			if (menuPanel.GetChild(i).name == "ForwardKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.forward.ToString();
			else if (menuPanel.GetChild(i).name == "BackwardKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.backward.ToString();
			else if (menuPanel.GetChild(i).name == "LeftKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.left.ToString();
			else if (menuPanel.GetChild(i).name == "RightKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.right.ToString();
			else if (menuPanel.GetChild(i).name == "JumpKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.jump.ToString();
			else if (menuPanel.GetChild(i).name == "HealKey")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.heal.ToString();
			/*
			else if (menuPanel.GetChild(i).name == "LeftClick")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.leftClick.ToString();
			else if (menuPanel.GetChild(i).name == "RightClick")
				menuPanel.GetChild(i).GetComponentInChildren<Text>().text = GameManager.GM.rightClick.ToString();		
			*/
		}

	}
		

	

	void OnGUI()
	{
		/*keyEvent dictates what key our user presses
		 * bt using Event.current to detect the current
		 * event
		 */
		keyEvent = Event.current;

		//Executes if a button gets pressed and
		//the user presses a key
		if(keyEvent.isKey && waitingForKey)
		{
			newKey = keyEvent.keyCode; //Assigns newKey to the key user presses
			waitingForKey = false;
		}
	}

	/*Buttons cannot call on Coroutines via OnClick().
	 * Instead, we have it call StartAssignment, which will
	 * call a coroutine in this script instead, only if we
	 * are not already waiting for a key to be pressed.
	 */
	public void StartAssignment(string keyName)
	{
		if(!waitingForKey)
			StartCoroutine(AssignKey(keyName));
	}

	//Assigns buttonText to the text component of
	//the button that was pressed
	public void SendText(Text text)
	{
		buttonText = text;
	}

	//Used for controlling the flow of our below Coroutine
	IEnumerator WaitForKey()
	{
		while(!keyEvent.isKey)
			yield return null;
	}

	/*AssignKey takes a keyName as a parameter. The
	 * keyName is checked in a switch statement. Each
	 * case assigns the command that keyName represents
	 * to the new key that the user presses, which is grabbed
	 * in the OnGUI() function, above.
	 */
	public IEnumerator AssignKey(string keyName)
	{
		waitingForKey = true;

		yield return WaitForKey(); //Executes endlessly until user presses a key

		switch(keyName)
		{
		case "forward":
			GameManager.GM.forward = newKey; //Set forward to new keycode
			buttonText.text = GameManager.GM.forward.ToString(); //Set button text to new key
			PlayerPrefs.SetString("forwardKey", GameManager.GM.forward.ToString()); //save new key to PlayerPrefs
			break;
		case "backward":
			GameManager.GM.backward = newKey; //set backward to new keycode
			buttonText.text = GameManager.GM.backward.ToString(); //set button text to new key
			PlayerPrefs.SetString("backwardKey", GameManager.GM.backward.ToString()); //save new key to PlayerPrefs
			break;
		case "left":
			GameManager.GM.left = newKey; //set left to new keycode
			buttonText.text = GameManager.GM.left.ToString(); //set button text to new key
			PlayerPrefs.SetString("leftKey", GameManager.GM.left.ToString()); //save new key to playerprefs
			break;
		case "right":
			GameManager.GM.right = newKey; //set right to new keycode
			buttonText.text = GameManager.GM.right.ToString(); //set button text to new key
			PlayerPrefs.SetString("rightKey", GameManager.GM.right.ToString()); //save new key to playerprefs
			break;
		case "jump":
			GameManager.GM.jump = newKey; //set jump to new keycode
			buttonText.text = GameManager.GM.jump.ToString(); //set button text to new key
			PlayerPrefs.SetString("jumpKey", GameManager.GM.jump.ToString()); //save new key to playerprefs
			break;
		case "heal":
			Debug.Log(newKey);
			GameManager.GM.heal = newKey; 
			buttonText.text = GameManager.GM.heal.ToString(); 
			PlayerPrefs.SetString("healKey", GameManager.GM.heal.ToString()); 
		break;
		case "leftClick":
			GameManager.GM.leftClick = newKey;
			buttonText.text = GameManager.GM.leftClick.ToString(); 
			PlayerPrefs.SetString("leftClick", GameManager.GM.leftClick.ToString()); 
			break;
		case "rightClick":
			GameManager.GM.rightClick = newKey;
			buttonText.text = GameManager.GM.rightClick.ToString();
			PlayerPrefs.SetString("rightClick", GameManager.GM.rightClick.ToString()); 
			break;
		}

		yield return null;
	}
}
