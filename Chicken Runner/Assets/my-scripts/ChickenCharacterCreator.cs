using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class ChickenCharacterCreator:Creator
{
	public override void setCharacterAction()
	{
		new CharacterActionChicken ();
	}
}