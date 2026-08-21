#region Using directives
using FTOptix.Alarm;
using FTOptix.CommunicationDriver;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.DataLogger;
using FTOptix.EventLogger;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.NetLogic;
using FTOptix.RAEtherNetIP;
using FTOptix.Recipe;
using FTOptix.Retentivity;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.System;
using FTOptix.UI;
using System;
using System.Globalization;
using UAManagedCore;
using FTOptix.S7TiaProfinet;
using FTOptix.WebUI;
using FTOptix.EdgeAppPlatform;
using static System.Net.Mime.MediaTypeNames;
using OpcUa = UAManagedCore.OpcUa;
#endregion

public class TimeFilter_Script : BaseNetLogic
{
    private IUAVariable Year;
    private IUAVariable Month;
    private IUAVariable Day;
    private IUAVariable Hour;
    private IUAVariable Minute;
    private IUAVariable Second;

    private DateTimePicker FromPicker;
    private DateTimePicker ToPicker;

    public override void Start()
    {
        Year = LogicObject.GetVariable("Year");
        Month = LogicObject.GetVariable("Month");
        Day = LogicObject.GetVariable("Day");
        Hour = LogicObject.GetVariable("Hour");
        Minute = LogicObject.GetVariable("Minute");
        Second = LogicObject.GetVariable("Second");

        // Owner = parent node of this NetLogic
        FromPicker = Owner.Children.Get<DateTimePicker>("From");
        ToPicker = Owner.Children.Get<DateTimePicker>("To");

        ApplyPlcTimeToPickers();
    }

    public override void Stop()
    {

    }
    private void ApplyPlcTimeToPickers()
    {
        try
        {
            int year = Convert.ToInt32(Year.Value.Value);
            int month = Convert.ToInt32(Month.Value.Value);
            int day = Convert.ToInt32(Day.Value.Value);
            int hour = Convert.ToInt32(Hour.Value.Value);
            int minute = Convert.ToInt32(Minute.Value.Value);
            int second = Convert.ToInt32(Second.Value.Value);
            var plcNow = new DateTime(year, month, day, hour, minute, second, DateTimeKind.Local);

            ToPicker.Value = plcNow;
            FromPicker.Value = plcNow.AddDays(-1);

            //Log.Info($"PLC time -> To={ToPicker.Value:O}, From={FromPicker.Value:O}");
        }
        catch (Exception ex)
        {
            Log.Warning($"ApplyPlcTimeToPickers failed: {ex.Message}");
        }
    }
}
