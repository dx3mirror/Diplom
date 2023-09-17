using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class DeleteCommand : ICommandFamily
    {
        private readonly FamilyRepository _repository;
        private readonly int _id;

        public DeleteCommand(FamilyRepository repository, int id)
        {
            _repository = repository;
            _id = id;
        }

        public async Task ExecuteAsync()
        {
            var family = await _repository.GetById(_id);
            if (family != null)
            {
                _repository.RemoveFamily(family);
                await _repository.SaveChangesAsync();
            }
        }
    }
}
