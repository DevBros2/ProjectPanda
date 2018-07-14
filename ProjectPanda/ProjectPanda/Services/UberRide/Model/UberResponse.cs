using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPanda.Services.UberRide.Model
{
    public class UberResponse<T>
    {
        public T Data { get; set; }
        public UberError Error { get; set; }
    }
}
