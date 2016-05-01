using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CharacterActionChickenBrown:ICharacterAction
{
	public CharacterActionChickenBrown()
	{
		Debug.Log ("chicken brown character has been selected");
		PlayerPrefs.SetInt("selectedCharacter", 1); 
		SceneManager.LoadScene("LEVEL_1");
	}
}
