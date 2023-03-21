using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BtvnBai4
{
    public class Document : IEncryable , IStorage
    {
        public void Decrypt()
        {
            throw new NotImplementedException();
        }

        public void Encrypt()
        {
            throw new NotImplementedException();
        }

        void IStorage.Read(string fileName)
        {
            throw new NotImplementedException();
        }

        void IStorage.Write(string fileName)
        {
            throw new NotImplementedException();
        }
    }

}
