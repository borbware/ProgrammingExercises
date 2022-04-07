using System;
using UnityEngine;

public class VariablesAndConditionals : MonoBehaviour
{
	
	string terve_maailma = "Hello World"; // tämä on kommentti
	int numero0 = 2;
	short numero1 = 15;
	long numero2 = 120301230102301;
	double desimaaliluku1 = 20.30303030;
	float desimaaliluku2 = 123124.1231f;

	bool totuusarvo = true;
	bool totuusarvo2 = false;

	/*
	nyt
	voidaan
	kirjoittaa
	vaikka
	romaani
	*/


	/// <summary>
	/// Tämä ois tämmönen aritmetiikkafunktio
	/// </summary>
	/// <param name="a"></param>
	/// <param name="b"></param>
	void Aritmetics(float a, float b)
	{
		Debug.Log($"{a} + {b} = {a + b}");
		Debug.Log($"{a} - {b} = {a - b}");
		Debug.Log($"{a} * {b} = {a * b}");
		Debug.Log($"{a} / {b} = {a / b}");
		Debug.Log($"{a} % {b} = {a % b}");
	}
	void Conditionals1(float a, float b)
	{
		string nimi1 = "Matti";
		string nimi2 = "matti";

		Debug.Log(nimi1.Length < nimi2.Length);
		Debug.Log(nimi1 != nimi2);
		Debug.Log(a != b);
		Debug.Log(a < b);
		Debug.Log(a <= b);
		Debug.Log(a > b);
		Debug.Log(a >= b);
	}
	void Conditionals2(string nimi1)
	{
		Debug.Log($"Testataan nimen {nimi1} pituutta");
		if (nimi1.Length < 5)
		{
			Debug.Log("onpas lyhyt nimi!");
		}
		else if (nimi1.Length < 10)
		{
			Debug.Log("ihan normaalin mittanen nimi i guess");
		}
		else if (nimi1.Length < 20)
		{
			Debug.Log("keskimääräistä pidempi nimi");
		}
		else
		{
			Debug.Log("no nyt on nimellä pituutta");
		}
	}
	void Conditionals2Variant(string nimi1)
	{
		Debug.Log($"Testataan nimen {nimi1} pituutta");
		if (nimi1.Length < 5)
			Debug.Log("onpas lyhyt nimi!");
		else if (nimi1.Length < 10) 
			Debug.Log("ihan normaalin mittanen nimi i guess");
		else if (nimi1.Length < 20)
			Debug.Log("keskimääräistä pidempi nimi");
		else
			Debug.Log("no nyt on nimellä pituutta");
	}
	void Testi()
	{
		Debug.Log(DateTime.Now);
	}

    void BooleanOperators()
    {
        string nimi1 = "Teppo";
        string nimi2 = "Matti";
        if (!(nimi1 == "Teppo")) // not operator
            Debug.Log("Se ei ole teppo");

        if ((nimi1 == "Matti" && nimi2 == "Teppo" )
        ||  (nimi1 == "Teppo" && nimi2 == "Matti"))
        {
            Debug.Log("Nehän on sitten matti ja teppo");
        }

        if (nimi1 == "Matti" && (nimi2 == "Teppo" || nimi2 == "Seppo"))
        {
            Debug.Log("Nehän on sitten matti ja teppo/seppo");
        }
    }

    void AssignmentOperators()
    {
        float i = 0;
        Debug.Log(i);
        i = i + 1;
        Debug.Log(i);
        i += 1;
        Debug.Log(i);
        i++;
        Debug.Log(i);
        i *= 20;
        i /= 5;
        i *= 0.2f;
    }
    void TernaryExample()
    {
        int health = -1;

        // if-else version
        string messageToTellIfPlayerIsAliveOrNot;
        if (health > 0)
            messageToTellIfPlayerIsAliveOrNot = "Player is alive!";
        else
            messageToTellIfPlayerIsAliveOrNot = "Player is dead!";
        
        // ternary version
        string message2ToTellIfPlayerIsAliveOrNot = 
              health > 10 ? "Player has many a health!" 
            : health > 0 ? "Player is barely alive" 
            : "Player is dead!";

        Debug.Log(message2ToTellIfPlayerIsAliveOrNot);
    }
	
    void StringExample()
    {
        string name1 = "Matti";
        string name2 = "Teppo";
        string bandName = name1 + " ja " + name2;
        string pitkäTeksti = $"Olipa kerran\n{name1} ja {name2}";
        string pitkäTeksti2 = "Olipa kerran\n" + name1 + " ja " + name2;
        Debug.Log(bandName);
        Debug.Log(pitkäTeksti);
    }

	// Start is called before the first frame update
	void Start()
	{
		// Debug.LogWarning(terve_maailma);
		// Aritmetics(4, 0);
		// Conditionals1(4, 4);
		// Conditionals2("Peppi Lotta Sikuriina Rullakatriina Efraimintytär Pitkätossu");
		// Conditionals2("Matti Teppo");
		// Conditionals2("Pasi");
		// Testi();
        // AssignmentOperators();

        // TernaryExample();
        StringExample();
	}

	// Update is called once per frame
	void Update()
	{
		// Debug.LogError(numero2);
	}
}


