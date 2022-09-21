namespace Inventar.Data
{
    public class Rifle : Gun
    {
        public string Pricel { get; set; }

        public Rifle() { }
        public Rifle(string name, int cartridge, int reCharge, string pricel) : base(name, cartridge, reCharge)
        {
            Pricel = pricel;
        }
    }
}
