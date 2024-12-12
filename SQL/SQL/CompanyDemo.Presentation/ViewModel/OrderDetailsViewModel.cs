using CompanyDemo.Domain;
using CompanyDemo.Infrastructure.Data.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyDemo.Presentation.ViewModel;

class OrderDetailsViewModel
{
    public ObservableCollection<OrderDetail> Details { get; set; }
    public OrderDetailsViewModel(OrderSummary order)
    {
        LoadOrderDetails(order.Id);
    }

    private void LoadOrderDetails(int orderId)
    {
        using var db = new CompanyContext();

        Details = new ObservableCollection<OrderDetail>(
        db.OrderDetails.Where(o => o.OrderId == orderId).ToList()
        );

    }
}
