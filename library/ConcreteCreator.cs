using System;
namespace MyStore.library
{
    class ConcreteCreator: IFactory
    {
        public override Product GetProduct(string type)
        {
            switch(type)
            {
                case "Generic": return new GenericProduct();
                case "Book": return new Book();
                case "Membership": return new Membership();
                default: throw new ArgumentException("Invalid type", "type");
            }
        }
    }
}
