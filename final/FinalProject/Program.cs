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

        int choice = 0;
        while (choice != 8)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Light brightness level:");
            Console.WriteLine("2. Set Thermostat");
            Console.WriteLine("3. Lock/Unlock Door");
            Console.WriteLine("4. Activate Roomba");
            Console.WriteLine("5. Activate camera");
            Console.WriteLine("6. Activate Alarm");
            Console.WriteLine("7. Display Devices");
            Console.WriteLine("8. Quit Program");

            Console.Write("Choose an option: ");
            choice = int.Parse(Console.ReadLine());

            
            if (choice == 1)
                {
                    Console.WriteLine("Level of brightness: ");
                    int brightness = int.Parse(Console.ReadLine());
                    light.AdjustBrightness(brightness);          
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
                    Console.WriteLine("Start cleaning or return to chargine port? ");
                    string answer = Console.ReadLine();
                    if (answer == "Start cleaning")
                    {
                    roomba.StartCleaning();
                    }
                    else
                    {
                    roomba.ReturnHome();
                    }
                }
            else if (choice == 5)
                {
                    Console.WriteLine("Record or stop recording?");
                    string answer = Console.ReadLine();
                    if (answer == "Record")
                    {
                    camera.StartRecording();
                    }
                    else
                    { 
                    camera.StopRecording();
                    }
                }
            else if (choice == 6)
                {
                    Console.WriteLine("Turn alarm on or off?");
                    string answer = Console.ReadLine();
                    if (answer == "On")
                    {
                    alarm.AlarmOn();
                    }
                    else
                    {
                    alarm.AlarmOff();
                    }
                }
            else if (choice == 7)
                {
                    Console.WriteLine();
                    myHome.DisplayDevices();
                }
            
        }
    }
}