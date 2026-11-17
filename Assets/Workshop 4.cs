using System;
using UnityEngine;

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
	
	public CharacterInformation characterInformation;
	//en variabel av en struct

	public int[] highScores;
	//Lägger till en lista man kan expandera, börjar alltid räkna från 0, en array av ints.
	private void Start()
	{
		Debug.Log(ep);
		Debug.Log(characterInformation.Name);
		Debug.Log(highScores[2]);
		//Visar det som står i element 2
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
