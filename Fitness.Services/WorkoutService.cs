using Fitness.Data;
using Fitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Services
{
   public class WorkoutService
    {
        private readonly Guid _userId;

        public WorkoutService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateWorkout(WorkoutCreate model)
        {
            var entity =
                new Workout()
                {
                    OwnerId = _userId,
                    Title = model.Title,
                    Reps = model.Reps,
                    Sets = model.Sets
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Workouts.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<WorkoutListItem> GetWorkouts()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Workouts
                    .Where(e => e.OwnerId == _userId)
                    .Select(
                        e =>
                        new WorkoutListItem
                        {
                            WorkoutId = e.WorkoutId,
                            Title = e.Title,
                            Reps = e.Reps,
                            Sets = e.Sets
                        }
              );
                return query.ToArray();
            }
        }
    }
}
