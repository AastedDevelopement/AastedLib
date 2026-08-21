#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.WebUI;
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
using FTOptix.ODBCStore;
using FTOptix.InfluxDBStoreLocal;
using FTOptix.InfluxDBStore;
using FTOptix.SerialPort;
using FTOptix.S7TiaProfinet;
using FTOptix.EdgeAppPlatform;
#endregion

public class Script_UpdateNavigationPath2 : BaseNetLogic
{
    public override void Start()
    {
        DisplayNo = LogicObject.GetVariable("NumberToModel");      
        
        DisplayNo.Value = true;
    }

    public override void Stop()
    {
        DisplayNo.Value = false;
    }
    private IUAVariable DisplayNo; 
}
