using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class UpdateCommand : ICommandFamily
    {
        private readonly FamilyRepository _repository;
        private readonly int _id;
        private readonly string _fio;
        private readonly string _stepenRodstva;
        private readonly string _dataRojdeniya;

        public UpdateCommand(FamilyRepository repository, int id, string fio, string stepenRodstva, string dataRojdeniya)
        {
            _repository = repository;
            _id = id;
            _fio = fio;
            _stepenRodstva = stepenRodstva;
            _dataRojdeniya = dataRojdeniya;
        }

        public async Task ExecuteAsync()
        {
            var family = await _repository.GetById(_id);
            if (family != null)
            {
                family.FIO = _fio;
                family.stepen_rodstva = _stepenRodstva;

                await _repository.SaveChangesAsync();
            }
        }
    }
}
