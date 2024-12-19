using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParticipantsLib
{
    public class ParticipantsRepository
    {
        private int _nextId = 1;
        private List<Participant> partis = new List<Participant>();

        public ParticipantsRepository()
        {
            Participant tobias = new Participant() { Name = "Tobias", Age = 12, Country = "USA" };
            Participant viktor = new Participant() { Name = "Viktor", Age = 13, Country = "Denmark" };
            Participant oliver = new Participant() { Name = "Oliver", Age = 14, Country = "Britain" };
            Participant jonas = new Participant() { Name = "Jonas", Age = 15, Country = "Egypt" };
            Participant matti = new Participant() { Name = "Matti", Age = 16, Country = "Sweden" };
            AddParti(tobias);
            AddParti(viktor);
            AddParti(oliver);
            AddParti(jonas);
            AddParti(matti);
        }

        public IEnumerable<Participant> GetAll()
        {
            IEnumerable<Participant> result = new List<Participant>(partis);
            return result;
        }

        public Participant GetById(int id)
        {

            Participant? parti = partis.FirstOrDefault(p => p.Id == id);

            if (parti == null)
            {
                return null;
            }
            else
                return parti;
        }

        public Participant AddParti(Participant parti)
        {

            parti.Validate();
            parti.Id = _nextId++;
            partis.Add(parti);
            return parti;
        }

        public Participant? Delete(int id)
        {
            partis.Remove(GetById(id));
            return GetById(id);
        }

    }
}
