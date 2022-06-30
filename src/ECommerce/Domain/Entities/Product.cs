using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : BaseEntity
    {
        public Guid UserId { get; set; }
        public Guid CategoryId { get; set; }
        public Guid BrandId { get; set; }
        public Guid ColorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public enum SizeTypes {XXS,XS,S,M,L,XL,XXL,XXXL};
        public SizeTypes SetSize { get; set; }
        public string ImagePath { get; set; }
        public enum UsageStatus { Recent, BarelyUsed, Old }
        public UsageStatus SetUsage { get; set; }
        public decimal Price { get; set; }
        public bool IsOfferable { get; set; }
        public int SoldCount { get; set; }

        public virtual User CreatedBy { get; set; }
        public virtual Brand? Brand { get; set; }
        public virtual Category? Category { get; set; }
        public virtual Color? Color { get; set; }
        public virtual ICollection<Offer> Offers { get; set; }
    }
}
