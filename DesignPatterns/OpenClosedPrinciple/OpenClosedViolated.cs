namespace DesignPatterns.OpenClosedPrinciple
{
    public class OpenClosedViolated
    {
        private IEnumerable<Product> _products;
        private ProductFilter _filter;
        public OpenClosedViolated(IEnumerable<Product> products, ProductFilter filter)
        {
            _products = products;
            _filter = filter;
        }

        public IEnumerable<Product> FilterProductsByColor(Color color)
        {
            return _filter.FilterByColor(_products, color);
        } 
        
        public IEnumerable<Product> FilterProductsBySize(Size size)
        {
            return _filter.FilterBySize(_products, size);
        }
    }
}
