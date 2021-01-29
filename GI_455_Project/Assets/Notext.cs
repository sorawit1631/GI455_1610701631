using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Notext : MonoBehaviour
{
    public string input;
    public string[] wave = new string[] { "poiu", "olm", "jkl", "yhnm","kloij" };
    public Text chalk;

    public void PanaInput(string s)
    {
        input = s;
        print(input);
    }
    public void fava()
    {
        for(int i = 0; i <wave.Length; i++)
        {
            if(wave[i] == input)
            {
                chalk.text = "[" + "<color=green>" + wave[i] + "</color>" + "]is found.";
                break;
            }
            else
            {
                chalk.text = "[" + "<color=red>" + input + "</color>" + "]is not found.";
            }
        }
    }
}
