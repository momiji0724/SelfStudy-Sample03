using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpwner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab = null;

    // Start is called before the first frame update
    void Start()
    {
        for (var i = 0; i < 10; i++)
        {
            var instance = Instantiate(_prefab);
            var x = Random.Range(-5.0f, 5.0f);
            var y = Random.Range(3.0f, 7.0f);
            var z = Random.Range(-5.0f, 5.0f);
            instance.transform.Translate(x, y, z);
        }

    }
}
    // Update is called once per frame
