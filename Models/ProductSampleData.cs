namespace Core_MVC.Models
{
	public class ProductSampleData
	{

		public List<Product> products;

		public ProductSampleData()
		{
			List<Product> Products;
			products = new List<Product>();
			products.Add(new Product() { ID = 1, Name = "UltraSonic Sensor", Description = "UltraSonic Sensor used to measure distance", Price = 45, Image = "img1.jpg" });
			products.Add(new Product() { ID = 2, Name = "Seven-Segment", Description = "Common-cathode Seven-Segment", Price = 8, Image = "img2.jpg" });
			products.Add(new Product() { ID = 3, Name = "Switch", Description = "Black mechanical on/off switch", Price = 5, Image = "img3.jpg" });
		}

		public List<Product> GetAll()
		{
			return products;
		}
		public Product getProductByID(int id)
		{
			return products.FirstOrDefault(p => p.ID == id);
		}

	}
}
