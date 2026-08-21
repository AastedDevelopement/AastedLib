#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.Alarm;
using FTOptix.Recipe;
using FTOptix.EventLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.RAEtherNetIP;
using FTOptix.System;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.DataLogger;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using FTOptix.S7TiaProfinet;
using FTOptix.WebUI;
using FTOptix.EdgeAppPlatform;
#endregion

public class Trends_Script : BaseNetLogic
{
    public override void Start()
    {
        Extended = LogicObject.GetVariable("Extended");
        Follow = LogicObject.GetVariable("Follow");

        Extended.Value = false;

        //When trends time window change, the trend stops following, så false true to restart follow
        Follow.Value = true;
        Follow.Value = false;
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }

    private IUAVariable Extended;
    private IUAVariable Follow;


}
