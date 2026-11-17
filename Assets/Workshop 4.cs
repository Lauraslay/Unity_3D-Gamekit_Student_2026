using System;
using UnityEngine;
using Random = UnityEngine.Random;
using FMODUnity;
using Gamekit3D;


public class Workshop4 : MonoBehaviour
{
	
	public enum ElementalPower
	{
		None,
		Light,
		Heavy,
		Ice,
		Fire,
	}
	[System.Serializable]
//Unity inspector grejsimojs
	public struct CharacterInformation
	{
		public string Name;
		public ElementalPower ep;
		public float speed;
		public int health;
		public bool canFly;
		public int damagePower;
	}
	public ElementalPower ep;
	//Lägger till variabel i unity inspector, en variabel av en enum
	
	public CharacterInformation[] characterInformation;
	//en variabel av en struct

	public int[] highScores;
	//Lägger till en lista man kan expandera, börjar alltid räkna från 0, en array av ints.
	private void Start()
	{
		
		foreach (CharacterInformation score in characterInformation)
		{
			Debug.Log(score.Name);
		}

		foreach (CharacterInformation score in characterInformation)
		{
			switch (score.Name)
			{
				case "Cat":
					Debug.Log("Meow");
					break;
				default:
					Debug.Log("uuhh");
					break;
			}
		}
		
		/*switch (ep) //switch motsvarar if
		{
			case ElementalPower.Fire:
				Debug.Log("Fire");
				if (true == false)
				{
					Debug.Log("noo");
				}
				break;
			case ElementalPower.Light:
				Debug.Log("Light");
				break;
			case ElementalPower.Heavy:
				Debug.Log("Heavy");
				break;
			case ElementalPower.Ice:
				Debug.Log("Ice");
				break;
			case ElementalPower.None:
				Debug.Log("None");
				break;
					
		}*/
		
		Debug.Log(ep);
		
		//Debug.Log(characterInformation.Name);
		
		Debug.Log(highScores[2]);
		//Visar det som står i element 2
		
		//int i = Random.Range(5, 7);

		for (int i = 0; i < highScores.Length; i++) //for loop, i berättar värdet
		{
			Debug.Log(i);
		}
	}
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Debug.Log("Yaa");
		}
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Debug.Log(highScores[3]);
		}
	}
}
