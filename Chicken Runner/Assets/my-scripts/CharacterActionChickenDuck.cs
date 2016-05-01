using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;



public class CharacterActionChickenDuck:ICharacterAction
{
	public CharacterActionChickenDuck()
	{
		Debug.Log ("duck character has been selected");
		PlayerPrefs.SetInt("selectedCharacter", 2); 
		SceneManager.LoadScene("LEVEL_1");
	}
}

