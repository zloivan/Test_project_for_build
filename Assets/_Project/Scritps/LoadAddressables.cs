using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

public class LoadAddressables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Addressables.LoadSceneAsync("Some environment", LoadSceneMode.Additive);
    }
}