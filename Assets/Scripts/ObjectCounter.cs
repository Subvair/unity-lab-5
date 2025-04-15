using UnityEngine;

public class ObjectCounter : MonoBehaviour
{
    public static ObjectCounter Instance { get; private set; }

    public int TotalObjectsCreated { get; private set; } = 0;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void UpdateCount(int newCount)
    {
        TotalObjectsCreated = newCount;
        Debug.Log($"[Singleton] Всего объектов: {TotalObjectsCreated}");
    }
}
