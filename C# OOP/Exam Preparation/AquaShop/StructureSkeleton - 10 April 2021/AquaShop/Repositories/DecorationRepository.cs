using AquaShop.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AquaShop.Models.Decorations.Contracts;

namespace AquaShop.Repositories
{
    public class DecorationRepository : IRepository<IDecoration>
    {
        private readonly ICollection<IDecoration> _decorations;

        public DecorationRepository()
        {
            this._decorations = new List<IDecoration>();
        }
        public IReadOnlyCollection<IDecoration> Models => (IReadOnlyCollection<IDecoration>)this._decorations;

        public void Add(IDecoration model) => this._decorations.Add(model);

        public bool Remove(IDecoration model) => this._decorations.Remove(model);

        public IDecoration FindByType(string type) => this._decorations.FirstOrDefault(x => x.GetType().Name == type);
    }
}
