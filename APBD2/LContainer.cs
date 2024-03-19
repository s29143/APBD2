namespace APBD2
{
    class LContainer : Container, IHazardNotifier
    {
        public LoadType LoadType { get; set; }
        public LContainer(double cargoWeight, double height, double weight, double depth, string name, double capacity, LoadType loadType) : base(cargoWeight, height, weight, depth, name, capacity) { }

        public void NotifyHazard(string message)
        {
            Console.WriteLine(message);
        }

        public override void Load(double weight) 
        {
            if(this.LoadType == LoadType.HAZARD && weight + CargoWeight > Capacity / 2)
            {
                this.NotifyHazard("Loaded too much dangerous load");
            }
            else if (weight + CargoWeight > Capacity * 0.9)
            {
                this.NotifyHazard("Loaded too much");
            }
            else
            {
                base.Load(weight);
            }
        }
    }

    enum LoadType
    {
        SAFE,
        HAZARD
    }
}