using System;
using System.Threading.Tasks;

namespace Inventar.Data
{
    public class Gun
    {
        private string name;

        public string Name
        {
            get { return name; }
            internal set { name = value; }
        }

        public int Cartridge { get; internal set; }
        public int Recharge { get; internal set; }

        public Gun() { }
        public Gun(string name, int cartridge, int reCharge)
        {
            Name = name;
            Cartridge = cartridge;
            Recharge = reCharge;
        }

        public async Task<string> ShotGun()
        {
            
            int cartNow = Cartridge;
            int shotCount = 0;


            while (cartNow != 0)
            {
                shotCount++;
                cartNow--;

                Console.WriteLine($"Выстрел - {shotCount}");
                await Task.Delay(300);

            }

            return $"Патроны закончились. Для перезарядки нажмите - {Constants._recharge}";
        }

        public async Task<bool> RechargeGun()
        {
            Console.WriteLine($"время перезарядки:{Recharge} сек");
            await Task.Delay(Recharge * 1000);

            return true;
        }
    }
}
