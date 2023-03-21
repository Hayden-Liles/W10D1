using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W10D1.Services
{
    public class SnacksService
    {

        private readonly SnacksRepository _repo;
        public SnacksService(SnacksRepository repo)
        {
            _repo = repo;
        }

        public List<Snack> getAllSnacks()
        {
            return _repo.getAllSnacks();
        }

        internal Snack getOneSnack(int id)
        {
            return _repo.getOneSnack(id);
        }
        internal Snack createSnack(Snack snackData)
        {
            return _repo.createSnack(snackData);
        }

        internal string removeSnack(int id)
        {
            return _repo.removeSnack(id);
        }
    }
}