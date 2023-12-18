using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class My_NetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        base.OnStartServer();
        //Global.Instance.asd = 1;
    }

    public override void OnServerAddPlayer(NetworkConnectionToClient conn)
    {
        base.OnServerAddPlayer(conn);
        Global.Instance.asd++;
        Debug.Log(Global.Instance.asd);
    }
}
