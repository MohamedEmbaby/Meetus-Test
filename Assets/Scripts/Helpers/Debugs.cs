using Unity.VisualScripting;
using UnityEngine;

public class Debugs : MonoBehaviour
{
    public bool isDebug;
    public static Debugs Instance { get; private set; }
    public enum DebugType { Normal, Warning, Error }

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void Log(string msg, DebugType debug_Level)
    {
        if (isDebug) {
            switch (debug_Level)
            {
                case DebugType.Normal:
                    Debug.Log(msg);
                    break;
                case DebugType.Warning:
                    Debug.LogWarning(msg);
                    break
                        ;
                case DebugType.Error:
                    Debug.LogError(msg);
                    break;

            }
        }
       


    }


}
