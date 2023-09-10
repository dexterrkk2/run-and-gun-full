using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EndTrigger : MonoBehaviour
{
    public GameObject CompleteLevelUI;
    public float gameEndDelay;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "player") 
        {
            CompleteLevelUI.gameObject.SetActive(true);
            Gamemanager.instance.Invoke("CompleteLevel", gameEndDelay);
        }
    }
}
