using System;
using System.Collections.Generic;
using System.Text;

namespace HomeService.service.Exeptions
{
   public class ItemNotFoundExeption:Exception
    {
        public ItemNotFoundExeption(string msg):base(msg)
        {

        }
    }
}
