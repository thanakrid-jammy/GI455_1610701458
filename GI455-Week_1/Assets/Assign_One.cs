using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Assign_One : MonoBehaviour
{
        List<string> gamename = new List<string>() { "Hytale", "Minecraft", "Terraria", "Cube World", "Starbound" };
        public List<Text> Gamelist = new List<Text>();

        public InputField Input_Field;
        public GameObject Result;
        //public Button Searhing;

        public void FilterGamename()
        {                
            for (int i = 0; i <= gamename.Count - 1; i++)
            {
                Gamelist[i].text = gamename[i].ToString();
            }
        }

        public void FindGameName(string Gamelist)
        {        
            if (gamename.Contains(Input_Field.text))
            {
                Result.GetComponent<Text>().text = "[ " + Input_Field.text + "]" + " is found.";
            }
            else
            {
                Result.GetComponent<Text>().text = "[ " + Input_Field.text + "] " + " is not found. ";
            }
        }    
}


