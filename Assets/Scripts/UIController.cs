using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    //Private Variables
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private UstawieniaPopup _ustawieniaPopup;

    // Start is called before the first frame update
    void Start()
    {
        _ustawieniaPopup.Close();
    }

    // Update is called once per frame
    void Update()
    {
        scoreLabel.text = Time.realtimeSinceStartup.ToString();
    }

    public void OnOpenSettings()
    {
        _ustawieniaPopup.Open();
    }

    public void OnPointerDown()
    {
        Debug.Log("Pointer Down");
    }
}
