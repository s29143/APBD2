namespace APBD2
{
    abstract class Container
    {
        public static double Id { get; set; } = 0;
        public double CargoWeight { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public double Depth { get; set; }
        public string SerialNumber {  get; set; }
        public double Capacity { get; set; }

        public Container(double cargoWeight, double height, double weight, double depth, string name, double capacity)
        {
            Id++;
            CargoWeight = cargoWeight;
            Height = height;
            Weight = weight;
            Depth = depth;
            SerialNumber = name + Id;
            Capacity = capacity;
        }

        public virtual void EmptyLoading()
        {
            CargoWeight = 0;
        }

        public virtual void Load(double weight) 
        {
            if(weight + CargoWeight > Capacity) 
            {
                throw new OverfillException("Container overfilled!");
            }
            CargoWeight += weight;
        }
    }
}
