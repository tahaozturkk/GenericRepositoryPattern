﻿namespace Domains.Entities
{
    public class Department: BaseEntity
    {
        public Department()
        {
             Personnels = new List<Personnel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Personnel> Personnels { get; set; }
    }
}
