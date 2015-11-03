namespace StudentSystem.Data.Repositories
{
    using System.Data.Entity;
    using System.Linq;

    public class EfGenericRepository<T> : IRepository<T> where T : class
    {
        private IStudentSystemDbContext context;
        private IDbSet<T> set;

        public EfGenericRepository(IStudentSystemDbContext context)
        {
            this.context = context;
            this.set = context.Set<T>();
        }

        public void Add(T entity)
        {
            var entry = this.context.Entry(entity);
            if (entry.State != EntityState.Detached)
            {
                entry.State = EntityState.Added;
            }
            else
            {
                this.set.Add(entity);
            }
        }

        public IQueryable<T> All()
        {
            return this.set.AsQueryable();
        }

        public void Update(T entity)
        {
            var entry = this.context.Entry(entity);
            if (entry.State == EntityState.Detached)
            {
                this.set.Attach(entity);
            }

            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            var entry = this.context.Entry(entity);
            if (entry.State != EntityState.Deleted)
            {
                entry.State = EntityState.Deleted;
            }
            else
            {
                this.set.Attach(entity);
                this.set.Remove(entity);
            }
        }

        public void Detach(T entity)
        {
            var entry = this.context.Entry(entity);
            entry.State = EntityState.Detached;
        }

        public void SaveChanges()
        {
            this.context.SaveChanges();
        }
    }
}
