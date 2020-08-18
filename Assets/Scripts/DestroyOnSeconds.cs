using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnSeconds : MonoBehaviour
{
    [SerializeField] private float destroyTime = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DestroyAtTime(destroyTime));
    }

    private IEnumerator DestroyAtTime(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(gameObject);
    }

}
