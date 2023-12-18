using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class Global : NetworkBehaviour
{
    [SyncVar(hook = nameof(ValueChanged))]
    public uint asd;

    public static Global Instance;

    private void Awake()
    {
        Instance = this;
    }

    private void ValueChanged(uint oldValue, uint newValue)
    {
        Debug.Log($"Value Changed, {newValue}");
    }
}
