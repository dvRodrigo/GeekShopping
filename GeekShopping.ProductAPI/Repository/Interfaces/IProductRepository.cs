namespace GeekShopping.ProductAPI.Repository.Interfaces
{
    public interface IProductRepository
    {
        Task<IEnumerable<Data.ValueObjects.ProductVO>> FindAll();
        Task<Data.ValueObjects.ProductVO> FindById(long id);
        Task<Data.ValueObjects.ProductVO> Create(Data.ValueObjects.ProductVO product);
        Task<Data.ValueObjects.ProductVO> Update(Data.ValueObjects.ProductVO product);
        Task<bool> Delete(long id);
    }
}
