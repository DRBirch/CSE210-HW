using System;
using System.Collections.Generic;

public class SmartHome
{
    private List<Device> _devices = new List<Device>();

    public void AddDevice(Device device)
    {
        _devices.Add(device);
    }

    public void DisplayDevices()
    {
        foreach (Device device in _devices)
        {
            device.DisplayStatus();
        }
    }
}