using System.Diagnostics.CodeAnalysis;
using Mirror;
using UnityEngine;

public class MyNetworkManager : NetworkManager
{
    public override void OnStartServer()
    {
        Debug.Log("Server started!");
    }

    public override void OnStopServer()
    {
        Debug.Log("Server stopped!");
    }

    [SuppressMessage("ReSharper", "Unity.PerformanceCriticalCodeInvocation")]
    public override void OnClientConnect(NetworkConnection conn)
    {
        Debug.Log("Connected to server!");
    }

    public override void OnClientDisconnect(NetworkConnection conn)
    {
        Debug.Log("Disconnected from the server!");
    }
}