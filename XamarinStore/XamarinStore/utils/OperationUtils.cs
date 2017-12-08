using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XamarinStore.model;

namespace XamarinStore.utils
{
    class OperationUtils
    {
        public static double GetTotalPrice(CPU cpu, GPU gpu, MotherBoard motherBoard, PcBox pcBox, Ram ram)
        {
            double price;
            price = cpu.Price + gpu.Price + motherBoard.Price + pcBox.Price + ram.Price;

            return price;
        }
    }
}
