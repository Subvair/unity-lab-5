using System;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject prefab;           
    public GameObject prefabVariant;    
    public bool useVariant = false;     

    private float timer;

    public static Action OnObjectInstantiated;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)
        {
            timer = 0f;

            GameObject toSpawn = useVariant ? prefabVariant : prefab;
            Instantiate(toSpawn, GetRandomPosition(), Quaternion.identity);

            OnObjectInstantiated?.Invoke();
        }
    }

    Vector3 GetRandomPosition()
    {
        return new Vector3(UnityEngine.Random.Range(-5f, 5f), 0, UnityEngine.Random.Range(-5f, 5f));
    }
}
