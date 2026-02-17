using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemSpwner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab = null;
    private void Start() 
    {
        StartCoroutine(GetItemCreationIterator());
    }
    IEnumerator GetItemCreationIterator() 
    {
        for (var i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(0.5f);
            var instance = Instantiate(_prefab);
            var x = Random.Range(-5.0f, 5.0f);
            var y = Random.Range(3.0f, 7.0f);
            var z = Random.Range(-5.0f, 5.0f);
            instance.transform.Translate(x, y, z);


            yield return null;
        }

    }
}

