using Inventar.Data;
using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayInventar inventar = new PlayInventar(new _911());

            inventar.ShowInventarInfo();
            Gun gun = inventar.SelectionUserGun()??throw new Exception();
               
            int action = inventar.SelectionAction();
            while (true)
            {
                switch (action)
                {
                    case 1:
                        string fireResult = inventar.FireAction(gun);
                        if (!string.IsNullOrEmpty(fireResult))
                        {
                            action = inventar.SelectionAction();
                            continue;
                        }
                        break;
                    case 2:
                        bool rechargeResult = inventar.RechengeAction(gun);
                        if (rechargeResult)
                        {
                            action = inventar.SelectionAction();
                            continue;
                        }
                        break;
                    default:
                        inventar.ErrorWorking("ERROR: НЕИЗВЕСТНОЕ ДЕЙСТВИЕ");

                        break;
                }
            }

            
           


















            Console.ReadLine();
            
           






























            //        Gun gun = null;
            //        string selectedGun = string.Empty;
            //        int selectAction;
            //        bool isError = false;
            //        string action = string.Empty;
            //        string errorMessage = string.Empty;
            //        string exit = string.Empty;
            //        PlayInventar inventar = new(new _911());

            //        inventar.ShowInventarInfo();
            //        var result = inventar.SelectionUserGun();

            //        Console.WriteLine($"Для выхода из игры введите: {Constants._exit}");

            //        while (true)
            //        {
            //            if (exit == Constants._exit)
            //                break;

            //            if (string.IsNullOrEmpty(selectedGun))
            //            {
            //                Console.WriteLine("Выберите оружие:");
            //                selectedGun = Console.ReadLine();
            //                if (selectedGun == Constants._exit)
            //                    break;

            //                if (string.IsNullOrEmpty(selectedGun))
            //                    Console.WriteLine("Выберите оружие:");

            //                gun = inventar.Guns.FirstOrDefault(options => options.Name == selectedGun);
            //                if (gun != null)
            //                {
            //                    Console.WriteLine($"Вы выбрали - {gun.Name}. У Вас {gun.Cartridge} патронов. Перезарядка составляет {gun.Recharge} секунд");
            //                    Console.WriteLine($"Выберите действие ({Constants._shotGun} - стрельба, {Constants._recharge} - перезарядка)");

            //                    action = Console.ReadLine();
            //                    if (action == Constants._exit)
            //                        break;
            //                }
            //                else
            //                    selectedGun = null;
            //            }

            //            if (!isError)
            //            {
            //                if (gun != null)
            //                {
            //                    if (int.TryParse(action, out selectAction))
            //                    {
            //                        if (selectAction == Constants._shotGun)
            //                        {
            //                            while (true)
            //                            {
            //                                if (!isError)
            //                                {
            //                                    var shotResult = gun.ShotGun();
            //                                    if (!string.IsNullOrEmpty(shotResult))
            //                                    {
            //                                        Console.WriteLine(shotResult);
            //                                        action = Console.ReadLine();
            //                                        if (action == Constants._exit)
            //                                        {
            //                                            exit = Constants._exit;
            //                                            break;
            //                                        }

            //                                        if (int.TryParse(action, out selectAction))
            //                                        {
            //                                            if (selectAction == Constants._recharge)
            //                                            {
            //                                                if (gun.RechargeGun().Result)
            //                                                    continue;
            //                                                else
            //                                                    break;
            //                                            }
            //                                            else
            //                                                isError = true;
            //                                        }
            //                                        else
            //                                        {
            //                                            isError = true;
            //                                            errorMessage = $"";
            //                                        }

            //                                    }
            //                                }
            //                                else
            //                                {
            //                                    Console.WriteLine("Для перезарядки нажмите 2");
            //                                    action = Console.ReadLine();
            //                                    if (action == Constants._exit)
            //                                    {
            //                                        exit = Constants._exit;
            //                                        break;
            //                                    }

            //                                    if (int.TryParse(action, out selectAction))
            //                                    {
            //                                        if (selectAction == Constants._recharge)
            //                                        {
            //                                            if (gun.RechargeGun().Result)
            //                                                isError = false;
            //                                        }
            //                                    }
            //                                    else
            //                                    {
            //                                        isError = true;
            //                                        errorMessage = $"";
            //                                    }
            //                                }
            //                            }
            //                        }
            //                        else
            //                        {
            //                            isError = true;
            //                            errorMessage = $"для стрельбы нажмите {Constants._shotGun} ";
            //                        }
            //                    }
            //                    else
            //                    {
            //                        isError = true;
            //                        errorMessage = "ты блять цифры забыл, уебан?";
            //                    }
            //                }
            //                else
            //                    Console.WriteLine("Оружие не неайдено");
            //            }
            //            else
            //            {
            //                action = Console.ReadLine();
            //                if (action == Constants._exit)
            //                    break;

            //                Console.WriteLine(errorMessage);

            //                if (int.TryParse(action, out selectAction))
            //                    isError = false;
            //            }
            //        }
        }

    }
}
