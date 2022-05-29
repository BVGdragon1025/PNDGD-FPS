using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CelReaktywny : MonoBehaviour
{
    public void ReactToHit()
    {
        PodstawowyAI behavior = GetComponent<PodstawowyAI>();
        if(behavior != null)
        {
            behavior.SetAlive(false);
        }
        StartCoroutine(Die());
    }

    private IEnumerator Die()
    {
        this.transform.Rotate(75, 0, 0);
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
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
