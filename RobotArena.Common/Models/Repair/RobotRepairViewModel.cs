namespace RobotArena.Common.Models.Repair
{
    public class RobotRepairViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ImageUrl { get; set; }
        public int CurrentHealth { get; set; }
        public int BaseHealth { get; set; }
        public int DamageReduction { get; set; }
    }
}