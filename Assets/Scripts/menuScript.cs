using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

    public Button start;
    public Button exit;

	void Start () {

        start = start.GetComponent<Button>();
        exit = start.GetComponent<Button>();

	}
	
	

	void Update () {
	
	}

    public void StartLevel()
    {
        Application.LoadLevel(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
