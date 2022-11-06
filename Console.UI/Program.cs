using DataAccessLayer;
using DataAccessLayer.UnitOfWork;
using Domains.Entities;

namespace Console.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork unitOfWork = new UnitOfWork(new DatabaseContext());
            unitOfWork.DeparmentRepository.Insert(new Department() 
            {
                Name="Bilgi İşlem",
                IsActive = true,
                CreatedDate = DateTime.Now,
            });
            unitOfWork.Complete();
        }
    }
}