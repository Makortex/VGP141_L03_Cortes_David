using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PSearch : MonoBehaviour
{
    public Text Name;
    public Text Level;
    public Text Score;

    string errorText = "Error 404 data not found";

    private string input;
    public Hashtable h;

       


    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        
    }
    public void ReadStringInput(string s)
    {
        Player P1 = new Player("Amogus", "1", "200");
        Player P2 = new Player("Bryan", "56", "86394");
        Player P3 = new Player("Laura", "169", "13");

        //Player.
        input = s;
        h = new Hashtable();
        h.Add(1, "Amogus");
        h.Add(2, "Bryan");
        h.Add(3, "Laura");
        
        if (h.ContainsValue(input))
        {
            //Debug.Log(input + h[2]);
            Name.text = s.ToString();
            if (input == "Amogus")
            {
                Name.text = s.ToString();
                Level.text = P1.Level.ToString();
                Score.text = P1.Score.ToString();
            }
            if (input == "Bryan")
            {
                Name.text = s.ToString();
                Level.text = P2.Level.ToString();
                Score.text = P2.Score.ToString();
            }
            if (input == "Laura")
            {
                Name.text = s.ToString();
                Level.text = P3.Level.ToString();
                Score.text = P3.Score.ToString();
            }
        }
        else
        {
            //Debug.Log("{0} Error 404 " + input + " not found");
            Name.text = errorText.ToString();
            Level.text = errorText.ToString();
            Score.text = errorText.ToString();

        }
        //string var = Player.player
    }
}
