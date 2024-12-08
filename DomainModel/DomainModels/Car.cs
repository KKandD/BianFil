namespace DomainModel.DomainModels
{
    public class Car : BaseDomain
    {
        public string Brand { get; set; } = string.Empty;
        public string Model { get; set; } = string.Empty;
        public int YearOfProduction { get; set; }
        public int Milleage { get; set; }
        public string Color { get; set; } = string.Empty; //Probably will be enum
        public string? ColorType { get; set; } //Change to enum like metalic, pearl etc
        public decimal Price { get; set; }
        public bool IsDamaged { get; set; }
        public bool WasDamaged { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime DateOfCreation { get; set; }
    }
}
