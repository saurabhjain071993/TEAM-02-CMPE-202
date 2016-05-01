using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterActionChicken:ICharacterAction
{
	public CharacterActionChicken()
	{
		Debug.Log ("chicken character has been selected");
		PlayerPrefs.SetInt("selectedCharacter", 0); 
		SceneManager.LoadScene("LEVEL_1");
	}
}