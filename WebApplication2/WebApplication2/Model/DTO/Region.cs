using WebApplication2.Model.Domain;

namespace WebApplication2.Model.DTO
{
    public class Region
    {
        public Guid Id { get; set; }
        public int Code { get; set; }

        public string? Name { get; set; }

        public double Area { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public long Population { get; set; }

    }
}
