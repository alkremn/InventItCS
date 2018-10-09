namespace Model
{
    public class Inhouse : Part
    {
        public int MachineId { get; set; }

        public Inhouse(int partid, string name, double price, int inStock, int min, int max, int machineId) :
            base(partid, name, price, inStock, min, max)
        {
            MachineId = machineId;
        }

        public override string ToString()
        {
            return string.Format($"{this.GetType()},{base.ToString()},{MachineId}");
        }
    }
}
