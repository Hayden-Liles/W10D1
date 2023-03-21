using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace W10D1.Repositories
{
    public class SnacksRepository
    {
        private List<Snack> dbSnacks = new List<Snack>();
        public SnacksRepository(){
            dbSnacks.Add(new Snack(0, "Doritos", 100, false));
            dbSnacks.Add(new Snack(1, "Funions", 100, false));
            dbSnacks.Add(new Snack(2, "Payday", 100, false));
            dbSnacks.Add(new Snack(3, "Gummy Bears", 100, false));
        }

        internal List<Snack> getAllSnacks()
        {
            return dbSnacks;
        }

        internal Snack getOneSnack(int id)
        {
            Snack snack = dbSnacks.Find(snack => snack.id == id);
            return snack;
        }

        internal Snack createSnack(Snack snackData)
        {
            snackData.id = dbSnacks[dbSnacks.Count - 1].id + 1;
            dbSnacks.Add(new Snack(snackData.id, snackData.name, snackData.quantity, snackData.sugarFree));
            return snackData;
        }

        internal string removeSnack(int id)
        {
            int count = dbSnacks.RemoveAll(snack => snack.id == id);
            return "Removed";
        }
    }
}