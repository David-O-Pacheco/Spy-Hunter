using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class health : MonoBehaviour {
    public float healthSet;
    public Image healthBar;
	void Start () {
	
	}
	
	void Update () {

        healthBar.fillAmount = 1f - healthSet;

	}
}
