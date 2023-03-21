using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
     public interface IStorage
    {
        public void Read(string fileName);
        public void Write(string fileName);

    }
}
