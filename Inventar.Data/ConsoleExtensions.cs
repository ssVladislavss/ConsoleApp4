using System;
using System.Linq;

namespace Inventar.Data
{
    public static class ConsoleExtensions
    {
        public static Gun SelectionUserGun(this PlayInventar inventar)
        {
            string userSelectGunStr = string.Empty;
            while (true)
            {
                Console.WriteLine("Выберите оружие:");
                userSelectGunStr = Console.ReadLine();
                if (userSelectGunStr == Constants._exit)
                    break;

                if (string.IsNullOrEmpty(userSelectGunStr))
                    Console.WriteLine("Выберите оружие:");

                Gun gun = inventar.Guns.FirstOrDefault(x => x.Name == userSelectGunStr);

                if (gun == null)
                    Console.WriteLine("Такого оружия нет\nПорпробуйте снова выбрать");
                else
                {
                    Console.WriteLine($"Вы выбрали - {gun.Name}. У Вас {gun.Cartridge} патронов. Перезарядка составляет {gun.Recharge} секунд");
                    Console.WriteLine($"Выберите действие ({Constants._shotGun} - стрельба, {Constants._recharge} - перезарядка)");

                    return gun;
                }
            }

            return null;
        }

        public static void ShowInventarInfo(this PlayInventar inventar)
            => Console.WriteLine(inventar.ToString());



        public static int SelectionAction(this PlayInventar inventar)
        {
            Console.WriteLine($"Выберете действие: {Constants._shotGun}-стрельба, {Constants._recharge}-Кд");
            return int.TryParse(Console.ReadLine(), out int result) ? result : 0;

        }
        public static string FireAction(this PlayInventar inventar, Gun gun) => gun.ShotGun().Result;

        public static bool RechengeAction(this PlayInventar inventar, Gun gun) => gun.RechargeGun().Result;

        public static void ErrorWorking(this PlayInventar inventar, string errorMassege )
        {
            Console.WriteLine(errorMassege);

        }
    }    


}
