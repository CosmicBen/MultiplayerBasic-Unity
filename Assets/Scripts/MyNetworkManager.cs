using Mirror;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    public override void OnServerAddPlayer(NetworkConnection conn)
    {
        base.OnServerAddPlayer(conn);

        Color randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));

        MyNetworkPlayer myPlayer = conn.identity.GetComponent<MyNetworkPlayer>();
        myPlayer.SetDisplayName($"Player {numPlayers}");
        myPlayer.SetDisplayColor(randomColor);
    }
}
