using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartHome
{
    class Menu
    {


        List<IDevicable> myDevice = new List<IDevicable>();
        Factory mySmartHome = new Factory();// создаем фабрику
        private void MenuStateDevice()
        {
            Console.Clear();
            Console.WriteLine("Ваши устройства:");
            foreach (IDevicable device in myDevice)
            {
                Console.WriteLine(device.ToString());
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
        }
        private void NewOrDelDevice(string stringNumber, bool creat)
        {
            string[] comand = stringNumber.Split(' ');
            if (creat && comand.Length == 3)
            {
                switch (comand[1])
                {
                    case "tv":
                        {
                            myDevice.Add(mySmartHome.CreatorTV(comand[2]));
                            break;
                        }
                    case "sound":
                        {
                            myDevice.Add(mySmartHome.CreatorSound(comand[2]));
                            break;
                        }
                    case "conditoiner":
                        {
                            myDevice.Add(mySmartHome.CreatorSound(comand[2]));
                            break;
                        }
                    case "heater":
                        {
                            myDevice.Add(mySmartHome.CreatorHeater(comand[2]));
                            break;
                        }
                    case "blower":
                        {
                            myDevice.Add(mySmartHome.CreatorBlower(comand[2]));
                            break;
                        }
                }
            }
            else
            {
                //int x = mySmartHome;
                switch (comand[1])
                {
                    case "tv":
                        {
                            for (int i = 0; i < myDevice.Count; i++)
                            {
                                if (myDevice[i] is TV && myDevice[i].Name == comand[2])
                                {
                                    myDevice.RemoveAt(i);
                                }
                            }
                            break;
                        }
                    case "sound":
                        {
                            for (int i = 0; i < myDevice.Count; i++)
                            {
                                if (myDevice[i] is Sound && myDevice[i].Name == comand[2])
                                {
                                    myDevice.RemoveAt(i);
                                }
                            }
                            break;
                        }
                    case "conditoiner":
                        {
                            for (int i = 0; i < myDevice.Count; i++)
                            {
                                if (myDevice[i] is Conditioner && myDevice[i].Name == comand[2])
                                {
                                    myDevice.RemoveAt(i);
                                }
                            }
                            break;
                        }
                    case "heater":
                        {
                            for (int i = 0; i < myDevice.Count; i++)
                            {
                                if (myDevice[i] is Heater && myDevice[i].Name == comand[2])
                                {
                                    myDevice.RemoveAt(i);
                                }
                            }
                            break;
                        }
                    case "blower":
                        {
                            for (int i = 0; i < myDevice.Count; i++)
                            {
                                if (myDevice[i] is Blower && myDevice[i].Name == comand[2])
                                {
                                    myDevice.RemoveAt(i);
                                }
                            }
                            break;
                        }
                }
            }
        }


        public void MySmartHome()
        {

            myDevice.Add(mySmartHome.CreatorTV("Samsung"));//создаем наши девайсы
            myDevice.Add(mySmartHome.CreatorSound("MyIPod"));
            myDevice.Add(mySmartHome.CreatorConditioner("Panas"));
            myDevice.Add(mySmartHome.CreatorHeater("my Hot Heater"));
            myDevice.Add(mySmartHome.CreatorBlower("Oriston"));

            while (true)
            {
                MenuStateDevice();

                Console.WriteLine("Веберите устройство для работы:");
                byte i = 1;
                foreach (var device in myDevice)
                {
                    Console.WriteLine(i++ + " - " + device.Name);
                }
                Console.WriteLine("new tv name - создать новый телевизор с именем");
                Console.WriteLine("del tv name - удалить телевизор по имени");
                Console.WriteLine("new sound name - создать новое музыкальное устройство с именем");
                Console.WriteLine("del sound name - удалить музыкальное устройство по имени");
                Console.WriteLine("new сonditioner name - создать новый кондиционер с именем");
                Console.WriteLine("del сonditioner name - удалить кондиционер по имени");
                Console.WriteLine("new heater name - создать новое нагревательное устройство с именем");
                Console.WriteLine("del heater name - удалить нагревательное устройство по имени");
                Console.WriteLine("new blower name - создать новый вентилятор с именем");
                Console.WriteLine("del blower name - удалить устройство по имени");
                Console.WriteLine("------------------------------------------------------------------------------");
                byte workDevice;
                bool mainMenu = false;
                while (true)
                {
                    Console.WriteLine("Введите команду:");
                    string stringNumber = Console.ReadLine();
                    bool creat = stringNumber.Contains("new");
                    bool delete = stringNumber.Contains("del");

                    if (byte.TryParse(stringNumber, out workDevice) && workDevice > 0 && workDevice <= myDevice.Count)
                    {
                        workDevice = Convert.ToByte(workDevice - 1);
                        mainMenu = true;
                        break;
                    }
                    else if (creat || delete)
                    {
                        NewOrDelDevice(stringNumber, creat);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели неизвестное значение, попробуйте еще раз:");
                    }
                }
                
                while (mainMenu)
                {
                    Console.Clear();

                    MenuStateDevice();

                    Console.WriteLine("Работа с " + myDevice[workDevice].Name + ":");
                    Console.WriteLine("on - включить устройство");
                    Console.WriteLine("off - выключить устройство");
                    if (myDevice[workDevice] is IVolumenable)
                    {
                        Console.WriteLine("1...100 - установить громкость");
                        Console.WriteLine("+ - сделать громче");
                        Console.WriteLine("- - сделать тише");
                    }
                    if (myDevice[workDevice] is ISwitchable && myDevice[workDevice] is IColorRedable)
                    {
                        Console.WriteLine("chanel 0... - включить канал");
                        Console.WriteLine("next - следующий канал");
                        Console.WriteLine("prev - предыдущий канал");
                    }
                    if (myDevice[workDevice] is ISwitchable && myDevice[workDevice] is IBassable)
                    {
                        Console.WriteLine("track 0... - включить трек");
                        Console.WriteLine("next - следующий трек");
                        Console.WriteLine("prev - предыдущий трек");
                    }

                    if (myDevice[workDevice] is IColorRedable)
                    {
                        Console.WriteLine("red 1...100 - установить насыщенность красного");
                        Console.WriteLine("red + - сделать насыщенней");
                        Console.WriteLine("red - - сделать тусклее");
                    }
                    if (myDevice[workDevice] is IBassable)
                    {
                        Console.WriteLine("bas 1...100 - установить уровень баса");
                        Console.WriteLine("bas + - сделать бас выше");
                        Console.WriteLine("bas - - сделать бас ниже");
                    }
                    if (myDevice[workDevice] is ITemperaturable)
                    {
                        Console.WriteLine("18...30 - установить температуру");
                        Console.WriteLine("+ - сделать температуру выше");
                        Console.WriteLine("- - сделать температуру ниже");
                    }
                    if (myDevice[workDevice] is ISpeedAirable)
                    {
                        Console.WriteLine("Low - вкл. вентилятор на низкий режим");
                        Console.WriteLine("Medium - вкл. вентилятор на средний режим");
                        Console.WriteLine("Hight - вкл. вентилятор на высокий режим");
                    }
                    Console.WriteLine("up - вернуться в главное меню");
                    Console.WriteLine("exit - выйти из программы");
                    Console.WriteLine("------------------------------------------------------------------------------");
                    Console.WriteLine("Введите каманду:");
                    //string commandState;

                    byte valueNumber;
                    string commandState = Console.ReadLine();
                    if (byte.TryParse(commandState, out valueNumber))
                    {
                        commandState = "valueNumber";
                    }
                    bool red = commandState.Contains("red");
                    bool chanel = commandState.Contains("chanel");
                    bool track = commandState.Contains("track");
                    bool bas = commandState.Contains("bas");
                    byte number = 0;// переменная для установки цвета
                    if (red || track || chanel || bas)
                    {
                        char[] trimRed = { 'r', 'e', 'd', ' ', 'c', 'h', 'a', 'n', 'l', 't', 'k', 'b', 's' };
                        commandState = commandState.Trim(trimRed);
                        byte.TryParse(commandState, out number);
                        commandState = "valueNumber";
                    }


                    switch (commandState)
                    {
                        case "on":
                            {
                                myDevice[workDevice].On();
                                break;
                            }
                        case "off":
                            {
                                myDevice[workDevice].Off();
                                break;
                            }
                        case "valueNumber":
                            {
                                if (myDevice[workDevice] is IVolumenable)
                                {
                                    ((IVolumenable)myDevice[workDevice]).Volume = valueNumber;
                                }
                                if (myDevice[workDevice] is ITemperaturable)
                                {
                                    ((ITemperaturable)myDevice[workDevice]).Temperature = valueNumber;
                                }
                                if (red && myDevice[workDevice] is IColorRedable)
                                {

                                    ((IColorRedable)myDevice[workDevice]).ColorRed = number;
                                }
                                if (chanel || track && myDevice[workDevice] is ISwitchable)
                                {
                                    ((ISwitchable)myDevice[workDevice]).Current = number;
                                }
                                if (bas && myDevice[workDevice] is IBassable)
                                {
                                    ((IBassable)myDevice[workDevice]).BassLevel = number;
                                }
                                if (myDevice[workDevice] is ITemperaturable)
                                {
                                    ((ITemperaturable)myDevice[workDevice]).Temperature = valueNumber;
                                }
                                break;
                            }
                        case "+":
                            {
                                if (myDevice[workDevice] is IVolumenable)
                                {
                                    ((IVolumenable)myDevice[workDevice]).VolumeUp();
                                }
                                if (myDevice[workDevice] is ITemperaturable)
                                {
                                    ((ITemperaturable)myDevice[workDevice]).TemperatureUp();
                                }
                                break;
                            }
                        case "-":
                            {
                                if (myDevice[workDevice] is IVolumenable)
                                {
                                    ((IVolumenable)myDevice[workDevice]).VolumeDown();
                                }
                                if (myDevice[workDevice] is ITemperaturable)
                                {
                                    ((ITemperaturable)myDevice[workDevice]).TemperatureDown();
                                }
                                break;
                            }


                        case "next":
                            {
                                if (myDevice[workDevice] is ISwitchable)
                                {
                                    ((ISwitchable)myDevice[workDevice]).Next();
                                }
                                break;
                            }
                        case "prev":
                            {
                                if (myDevice[workDevice] is ISwitchable)
                                {
                                    ((ISwitchable)myDevice[workDevice]).Previous();
                                }
                                break;
                            }
                        case "red +":
                            {
                                {
                                    if (myDevice[workDevice] is IColorRedable)
                                    {
                                        ((IColorRedable)myDevice[workDevice]).ColorRedUp();
                                    }
                                    break;
                                }
                            }
                        case "red -":
                            {
                                {
                                    if (myDevice[workDevice] is IColorRedable)
                                    {
                                        ((IColorRedable)myDevice[workDevice]).ColorRedDown();
                                    }
                                    break;
                                }
                            }
                        case "bas +":
                            {
                                {
                                    if (myDevice[workDevice] is IBassable)
                                    {
                                        ((IBassable)myDevice[workDevice]).BassUp();
                                    }
                                    break;
                                }
                            }
                        case "bas -":
                            {
                                {
                                    if (myDevice[workDevice] is IBassable)
                                    {
                                        ((IBassable)myDevice[workDevice]).BassDown();
                                    }
                                    break;
                                }
                            }
                        case "Low":
                            {
                                if (myDevice[workDevice] is ISpeedAirable)
                                {
                                    ((ISpeedAirable)myDevice[workDevice]).SpeedAirLow();
                                }
                                break;
                            }
                        case "Medium":
                            {
                                if (myDevice[workDevice] is ISpeedAirable)
                                {
                                    ((ISpeedAirable)myDevice[workDevice]).SpeedAirMedium();
                                }
                                break;
                            }
                        case "Hight":
                            {
                                if (myDevice[workDevice] is ISpeedAirable)
                                {
                                    ((ISpeedAirable)myDevice[workDevice]).SpeedAirHight();
                                }
                                break;
                            }
                        case "up":
                            {
                                mainMenu = false;
                                break;
                            }
                        case "exit":
                            {

                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Неизвестная команда. Попробуйте снова.");
                                System.Threading.Thread.Sleep(1000);
                                break;
                            }

                    }



                }
            }
            //Console.WriteLine(myDevice[0].Name);
            //myDevice[0].Name = "adfsad";
            //Console.WriteLine(myDevice[0].Name);
        }
    }
}
