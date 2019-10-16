using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class PlanLogic : BusinessLogic
    {
        private PlanAdapter _DataPlan;
        public PlanAdapter DataPlan
        {
            get
            {
                return _DataPlan;
            }
            set
            {
                _DataPlan = value;
            }
        }

        public PlanLogic()
        {
            _DataPlan = new PlanAdapter();
        }

        public PlanLogic(PlanAdapter pa)
        {
            _DataPlan = pa;
        }

        public List<Plan> GetAll()
        {
            return DataPlan.GetAll();
        }

        public Plan GetOne(int id)
        {
            return DataPlan.GetOne(id);
        }

        public void Delete (int id)
        {
            DataPlan.Delete(id);
        }

        public void Save(Plan plan)
        {
            DataPlan.Save(plan);
        }
    }
}
