using System;
namespace MyStore.library
{
    abstract class IFactory
    {
        public abstract Product GetProduct(string type);
    }
}
