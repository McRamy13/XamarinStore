using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinStore.model;

namespace XamarinStore.utils
{
    /// <summary>
    /// Clase OperationUtils
    /// </summary>
    public class OperationUtils
    {
        /// <summary>
        /// El método estático getTotalPrice suma todos los precios de los productos
        /// </summary>
        /// <param name="cpu">Objeto CPU del pedido</param>
        /// <param name="gpu">Objeto GPU del pedido</param>
        /// <param name="motherBoard">Objeto MotherBoard del pedido</param>
        /// <param name="pcBox">Objeto cpu del PcBox</param>
        /// <param name="ram">Objeto Ram del pedido</param>
        /// <returns>Retorna el precio total del pedido</returns>
        public static double GetTotalPrice(CPU cpu, GPU gpu, MotherBoard motherBoard, PcBox pcBox, Ram ram)
        {
            double price;
            price = cpu.Price + gpu.Price + motherBoard.Price + pcBox.Price + ram.Price;

            return price;
        }
    }
}
