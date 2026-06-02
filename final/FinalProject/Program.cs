using System;

class Program
{
    static void Main(string[] args)
    {
        SmartHome myHome = new SmartHome();

        Light light = new Light();
        Thermostat thermostat = new Thermostat();
        DoorLock doorLock = new DoorLock();
        Roomba roomba = new Roomba();
        SecurityCamera camera = new SecurityCamera();
        Alarm alarm = new Alarm();

        myHome.AddDevice(light);
        myHome.AddDevice(thermostat);
        myHome.AddDevice(doorLock);
        myHome.AddDevice(roomba);
        myHome.AddDevice(camera);
        myHome.AddDevice(alarm);
        myHome.DisplayDevices();

        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. Turn Light On/off");
        Console.WriteLine("2. Set Thermostat");
        Console.WriteLine("3. Lock/Unlock Door");
        Console.WriteLine("4. Activate Roomba");
        Console.WriteLine("5. Activate camera");
        Console.WriteLine("6. Activate Alarm");
        Console.WriteLine("7. Display Devices");

    Console.Write("Choose an option: ");
    int choice = int.Parse(Console.ReadLine());

    if (choice == 1)
        {
            Console.WriteLine("Enter on or off: ");
            string answer = Console.ReadLine();
            if (answer == "on")
            {
                light.TurnOn();
            }
            else
            {
                light.TurnOff();
            }
        }
    else if (choice == 2)
        {
            Console.WriteLine("Enter temperature: ");
            int temp = int.Parse(Console.ReadLine());
            thermostat.SetTemperature(temp);
        }
    else if (choice == 3)
        {
            Console.WriteLine("Lock or Unlock door? ");
            string answer = Console.ReadLine();
            if (answer == "Lock")
            {
                doorLock.LockDoor();
            }
            else
            {
                doorLock.UnlockDoor();
            }
        }
    else if (choice == 4)
        {
            roomba.StartCleaning();
        }
    else if (choice == 5)
        {
            camera.StartRecording();
        }
    else if (choice == 7)
        {
            myHome.DisplayDevices();
        }
    }
}