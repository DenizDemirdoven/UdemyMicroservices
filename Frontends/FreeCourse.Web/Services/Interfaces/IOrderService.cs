using FreeCourse.Web.Models.Orders;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FreeCourse.Web.Services.Interfaces
{
    public interface IOrderService
    { 
       
        Task<List<OrderViewModel>> GetOrder();

        Task<OrderCreatedViewModel> CreateOrder(CheckoutInfoInput checkoutInfoInput);

        Task SuspendOrder(CheckoutInfoInput checkoutInfoInput);

    }
}
