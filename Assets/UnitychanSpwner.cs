using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitychanSpwner : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab = null;
    // Start is called before the first frame update
    void Start()
    {
        var instance = Instantiate(_prefab);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
