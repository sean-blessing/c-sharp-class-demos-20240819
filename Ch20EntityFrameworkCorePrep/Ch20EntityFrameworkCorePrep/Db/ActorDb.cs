using Ch20EntityFrameworkCorePrep.Models;

namespace Ch20EntityFrameworkCorePrep.Db {
    public class ActorDb {
        private bmdbContext context = new();

        public List<Actor> GetActors() { 
            return context.Actors.ToList();
        }
    }
}
