using Fitness.Data;
using Fitness.Models.RoutineModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness.Services
{
    public class RoutineService
    {
        private readonly Guid _userId;

        public RoutineService(Guid userId)
        {
            _userId = userId;
        }

        public bool CreateRoutine(RoutineCreate model)
        {
            var entity =
                new Routine()
                {
                    Name = model.Name,
                    Category = model.Category,
                    RoutineId = model.RoutineId,
                    Style = model.Style,
                    Intensity = model.Intensity,
                    WorkoutId = model.WorkoutId,
                    UserID = model.UserId
                };

            using (var ctx = new ApplicationDbContext())
            {
                ctx.Routines.Add(entity);
                return ctx.SaveChanges() == 1;
            }
        }

        public IEnumerable<RoutineListItem> GetRoutines()
        {
            using (var ctx = new ApplicationDbContext())
            {
                var query =
                    ctx.Routines
                    .Where(e => e.UserID == _userId)
                    .Select(
                        e =>
                        new RoutineListItem
                        {
                            RoutineId = e.RoutineId,
                            Name = e.Name,
                            Category = e.Category,
                        }
              );
                return query.ToArray();
            }
        }
    }
}
