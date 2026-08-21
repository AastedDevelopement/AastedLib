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
using FTOptix.S7TiaProfinet;
using FTOptix.EdgeAppPlatform;
#endregion

public class TypeSelector : BaseNetLogic
{
    public override void Start()
    {
        {
            IUAVariable ValueType = LogicObject.GetVariable("InputValue");
            IUAVariable IntOrNot = LogicObject.GetVariable("IntOrNot");

            if (ValueType.Value.Value is Int16 ||
                ValueType.Value.Value is UInt16 ||
                ValueType.Value.Value is Int32 ||
                ValueType.Value.Value is UInt32)
            {
                IntOrNot.Value = true;
            }
            else
            {
                IntOrNot.Value = false;
            }
        }
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
