using OpenShop___Despacho;
using System;
using System.Linq;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CantidadDePedidosIgualACantidadDeClientes()
        {
            Assert.Equal(Pedido.Pedidos.Count.ToString(), Cliente.Clientes.Count.ToString());
        }

        [Fact]

    public void cantidadDeProductosNegativos()
        {
            Assert.Throws<Exception>(() =>
            {
                //Codigo
            });
        }

    }
}
