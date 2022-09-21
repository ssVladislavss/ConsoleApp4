using System.Collections.Generic;

namespace Inventar.Data
{
    public class PlayInventar
    {
        private List<Gun> _guns = new();

        public List<Gun> Guns
        {
            get { return _guns; }
            set { _guns = value; }
        }

        public _911 Aptechka { get; set; }

        public PlayInventar() { }
        public PlayInventar(_911 aptechka)
        {
            this._guns = new()
            {
                new Gun(Constants._selectAK, 30, 5),
                new Gun(Constants._selectM16, 28, 7),
                new Rifle(Constants._selectSVD, 10, 9, "6x")
            };
            this.Aptechka = aptechka;
        }
        
        public override string ToString()
        {
            string result = "Ваш инвентарь:\n";

            foreach (Gun item in Guns)
            {
                if (item is not Rifle rifle)
                {
                    result += $"{item.Name}." +
                              $"( Патроны: {item.Cartridge}." +
                              $" Перезарядка: {item.Recharge})\n";
                }
                else
                {
                    result += $"{rifle.Name}." +
                              $"( Патроны: {rifle.Cartridge}." +
                              $" Перезарядка: {rifle.Recharge}." +
                              $" Прицел: {rifle.Pricel})\n";
                }
            }

            result += $"Аптечка: {Aptechka.Name}\n";

            return result;
        }
    }
}
