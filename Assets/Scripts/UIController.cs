using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIController : MonoBehaviour
{
    //Private Variables
    [SerializeField] private TextMeshProUGUI scoreLabel;
    [SerializeField] private UstawieniaPopup _ustawieniaPopup;
    private int _score;

    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
        scoreLabel.text = "Score: " + _score.ToString();
        _ustawieniaPopup.Close();
    }

    private void Awake()
    {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnDestroy()
    {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnEnemyHit()
    {
        _score += 1;
        scoreLabel.text = "Score: " + _score.ToString();
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
