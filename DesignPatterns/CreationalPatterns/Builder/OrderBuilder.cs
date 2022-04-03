using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.CreationalPatterns.Builder.FluentBuilder;

namespace DesignPatterns.CreationalPatterns.Builder
{
    /// <summary>
    /// Fluent Builder は各メソッドでプロパティを設定し、メソッドでは自身(this)を返すようにします
    /// 最後にbuild()を行うことで設定されたプロパティ値を統合してクラス(ここではOrderクラス)を完成させます
    ///
    /// このようにすることで、コンストラクタの引数を設定することなく、必要なプロパティのみを設定することができます
    /// </summary>
    internal class OrderBuilder
    {
        private Order _order = new Order();

        public Order Build()
        {
            if(_order.Product.Price > 0 && _order.Quantity > 0)
            {
                _order.Sum = _order.Product.Price * _order.Quantity;
            }

            return _order;
        }

        public OrderBuilder SetCustomer(Customer customer)
        {
            _order.Customer = customer;
            return this;
        }

        public OrderBuilder SetProduct(Product product)
        {
            _order.Product = product;
            return this;
        }

        public OrderBuilder SetQuantity(int quantity)
        {
            _order.Quantity = quantity;
            return this;
        }
    }
}
