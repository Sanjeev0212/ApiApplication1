﻿namespace WebApplication2.Model.Domain
{
    public class Region
    {

        public Guid Id { get; set; }
        public int Code { get; set; }

        public string? Name { get; set; }

        public string? Regions { get; set; }

        public double Area { get; set; }

        public double Lat { get; set; }

        public double Long { get; set; }

        public long Population { get; set; }

        //Navigation property

        public IEnumerable<Walks>? Walks { get; set; }

        
    }

}
