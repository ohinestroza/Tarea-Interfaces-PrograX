using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TareaSolidInterface.Classes;

namespace TareaSolidInterface.Interfaces
{
    public interface Interfaces
    {
        void Print(Document document);
        void Photocopy(Document document);
        void Scan(Document document);
    }
}
