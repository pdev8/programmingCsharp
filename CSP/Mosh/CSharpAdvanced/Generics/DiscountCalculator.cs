namespace CSP.Mosh.CSharpAdvanced.Generics
{
    class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product) => product.Price;
    }
}
