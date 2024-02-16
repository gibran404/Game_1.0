using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class raceStart : MonoBehaviour
{
    public GameObject boy;
    public GameObject girl;
    public GameObject woman;

    public GameObject StartScreen;

    [SerializeField] public float StartTime;
    [SerializeField] public float timePassed;

    public GameObject Timer;
    public static bool raceStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        StartScreen.SetActive(true);
        Timer.SetActive(true);

        StartTime = Time.time;

        if (charSlection.character == "Boy")
        {
            girl.SetActive(false);
            boy.SetActive(true);
        }
        if (charSlection.character == "Girl")
        {
            girl.SetActive(true);
            boy.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        timePassed = Time.time - StartTime;
        
        if (timePassed > 6f)
        {
            Timer.GetComponent<Text>().text = "GO!";
            StartScreen.SetActive(false);
            raceStarted = true;
        }
        else if (timePassed > 5f)
        {
            // make timer text "1"
            Timer.GetComponent<Text>().text = "Race Starting in: 1";
        }
        else if (timePassed > 4f)
        {
            // make timer text "2"
            Timer.GetComponent<Text>().text = "Race Starting in: 2";
        }
        else if (timePassed > 3f)
        {
            // make timer text "3"
            Timer.GetComponent<Text>().text = "Race Starting in: 3";
        }
        else
        {
            // make timer text " "
            Timer.GetComponent<Text>().text = "Keep Pressing SpaceBar to Accelerate!";
        }
        
    }
}
