using Examen.Base;
using System;
using System.Threading.Tasks;

namespace Examen.Core
{
    public class AddCommand : ICommandFamily
    {
        private readonly FamilyRepository _repository;
        private readonly int _userId;
        private readonly string _fio;
        private readonly string _stepenRodstva;
        private readonly DateTime _dataRojdeniya;

        public AddCommand(FamilyRepository repository, int userId, string fio, string stepenRodstva, DateTime dataRojdeniya)
        {
            _repository = repository;
            _userId = userId;
            _fio = fio;
            _stepenRodstva = stepenRodstva;
            _dataRojdeniya = dataRojdeniya;
        }

        public async Task ExecuteAsync()
        {
            var family = new Family
            {
                FK_sotrudnik = _userId,
                FIO = _fio,
                stepen_rodstva = _stepenRodstva,
                data_rojdeniya = _dataRojdeniya
            };

            _repository.AddFamily(family);
            await _repository.SaveChangesAsync();
        }
    }
}
