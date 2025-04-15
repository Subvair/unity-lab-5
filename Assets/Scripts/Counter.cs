using UnityEngine;

public class Counter : MonoBehaviour
{
    private int count = 0;

    private void OnEnable()
    {
        Factory.OnObjectInstantiated += IncrementCounter;
    }

    private void OnDisable()
    {
        Factory.OnObjectInstantiated -= IncrementCounter;
    }

    private void IncrementCounter()
    {
        count++;
        Debug.Log($"[Counter] Объектов создано: {count}");
    }
}
