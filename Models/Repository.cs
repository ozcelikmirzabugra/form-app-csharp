namespace FormsApp.Models{
    public class Repository{
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository(){
            _categories.Add(new Category {CategoryId = 1, Name = "Phone"});
            _categories.Add(new Category {CategoryId = 2, Name = "Computer"});

            _products.Add(new Product { ProductId = 1, Name = "Iphone14", Price = 40000, IsActive = true, Image = "1.jpg", CategoryId = 1});
            _products.Add(new Product { ProductId = 2, Name = "Iphone15", Price = 50000, IsActive = false, Image = "2.jpg", CategoryId = 1});
            _products.Add(new Product { ProductId = 3, Name = "Iphone16", Price = 60000, IsActive = true, Image = "3.jpg", CategoryId = 1});
            _products.Add(new Product { ProductId = 4, Name = "Iphone17", Price = 70000, IsActive = false, Image = "4.jpg", CategoryId = 1});

            _products.Add(new Product { ProductId = 5, Name = "Macbook Air", Price = 80000, IsActive = false, Image = "5.jpg", CategoryId = 2});
            _products.Add(new Product { ProductId = 6, Name = "Macbook Pro", Price = 90000, IsActive = true, Image = "6.jpg", CategoryId = 2});
        }

        public static void CreateProduct(Product entity){
            _products.Add(entity);
        }

        public static List<Product> Products{
            get{
                return _products;
            }
        }

        public static void EditProduct(Product updatedProduct){
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);

            if(entity != null){
                if(!string.IsNullOrEmpty(updatedProduct.Name)){
                    entity.Name = updatedProduct.Name;
                }
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void EditIsActive(Product updatedProduct){
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if(entity != null){
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void DeleteProduct(Product deletedProduct){
            var entity = _products.FirstOrDefault(p => p.ProductId == deletedProduct.ProductId);

            if(entity != null){
                _products.Remove(entity);
            }
        }

        public static List<Category> Categories{
            get{
                return _categories;
            }
        }
    }
}