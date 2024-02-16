using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class charSlection : MonoBehaviour
{
    public GameObject boy;
    public GameObject girl;
    public GameObject SelectionScreen;
    public GameObject BoyMugshot;
    public GameObject GirlMugshot;
    public GameObject BoyMugshotW;
    public GameObject GirlMugshotW;
    public GameObject Name;
    public GameObject NameW;


    // Start is called before the first frame update
    public void PickBoy()
    {
        Name.GetComponent<Text>().text = "Hamad";
        NameW.GetComponent<Text>().text = "Hamad";
        girl.SetActive(false);
        boy.SetActive(true);
        SelectionScreen.SetActive(false);
        BoyMugshot.SetActive(true);
        GirlMugshot.SetActive(false);
        BoyMugshotW.SetActive(true);
        GirlMugshotW.SetActive(false);

    }
    public void Pickgirl(){
        Name.GetComponent<Text>().text = "Aisha";
        NameW.GetComponent<Text>().text = "Aisha";
        BoyMugshot.SetActive(false);
        GirlMugshot.SetActive(true);
        BoyMugshotW.SetActive(false);
        GirlMugshotW.SetActive(true);
        girl.SetActive(true);
        boy.SetActive(false);
        SelectionScreen.SetActive(false);
    }
}
