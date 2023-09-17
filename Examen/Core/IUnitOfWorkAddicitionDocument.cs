using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    internal interface IUnitOfWorkAddicitionDocument
    {
        IAdditionalDocumentsRepository AdditionalDocumentsRepository { get; }
        Task SaveChangesAsync();
    }
}
