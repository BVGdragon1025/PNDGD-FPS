using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(PlayerManager))]
[RequireComponent(typeof(InventoryManager))]

public class Managers : MonoBehaviour
{
    //Public Variables
    public static PlayerManager Player { get; private set; }
    public static InventoryManager Inventory { get; private set; }

    //Private Variables
    private List<IGameManager> _startSequence;

    private void Awake()
    {
        Player = GetComponent<PlayerManager>();
        Inventory = GetComponent<InventoryManager>();
        _startSequence = new List<IGameManager>();
        _startSequence.Add(Player);
        _startSequence.Add(Inventory);
        StartCoroutine(StartupManagers());
    }

    private IEnumerator StartupManagers()
    {
        yield return null;
        int numModules = _startSequence.Count;
        int numReady = 0;
        while(numReady < numModules)
        {
            int lastReady = numReady;
            numReady = 0;
            foreach(IGameManager manager in _startSequence)
            {
                if(manager.status == ManagerStatus.Started)
                {
                    numReady++;
                }
            }
            if(numReady > lastReady)
            {
                Debug.Log("Progress: " + numReady + "/" + numModules);
                yield return null;
            }
            Debug.Log("All managers started up!");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}