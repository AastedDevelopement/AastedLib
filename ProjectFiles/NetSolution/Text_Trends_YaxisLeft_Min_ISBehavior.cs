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
using FTOptix.CommunicationDriver;
using FTOptix.DataLogger;
using FTOptix.Core;
using FTOptix.EdgeAppPlatform;
using FTOptix.S7TiaProfinet;
#endregion

[CustomBehavior]
public class Text_Trends_YaxisLeft_Min_ISBehavior : BaseNetBehavior
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined behavior is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined behavior is stopped
    }

#region Auto-generated code, do not edit!
    protected new Text_Trends_YaxisLeft_Min_IS Node => (Text_Trends_YaxisLeft_Min_IS)base.Node;
#endregion
}
