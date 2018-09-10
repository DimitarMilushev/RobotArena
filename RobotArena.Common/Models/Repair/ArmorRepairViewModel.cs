namespace RobotArena.Common.Models.Repair
{
    public class ArmorRepairViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public int ArmorPoints { get; set; }
        public int CurrentArmor { get; set; }
        public int Durability { get; set; }
    }
}