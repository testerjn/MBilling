using MBilling.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class WorkOrderHeaderDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<WorkOrderHeader> WorkOrderHeaderDaoRepository;

        public WorkOrderHeaderDao()
        {
            WorkOrderHeaderDaoRepository = unitOfWork.Repository<WorkOrderHeader>();
        }

        public bool Validate(WorkOrderHeader _WorkOrderHeader, out List<string> lstMessages)
        {
            return WorkOrderHeaderDaoRepository.Validate(_WorkOrderHeader, out lstMessages);
        }

        public int Insert(WorkOrderHeader _WorkOrderHeader)
        {
            return WorkOrderHeaderDaoRepository.Insert(_WorkOrderHeader);
        }

        public int Update(WorkOrderHeader _WorkOrderHeader)
        {
            return WorkOrderHeaderDaoRepository.Update(_WorkOrderHeader);
        }

        public int Delete(WorkOrderHeader _WorkOrderHeader)
        {
            return WorkOrderHeaderDaoRepository.Delete(_WorkOrderHeader);
        }

        public async Task<WorkOrderHeader> GetById(int _id)
        {
            return await WorkOrderHeaderDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<WorkOrderHeader>> GetAll()
        {
            return await WorkOrderHeaderDaoRepository.GetAll();
        }

        public async Task<IEnumerable<WorkOrderHeader>> FindBy(Expression<Func<WorkOrderHeader, bool>> predicate)
        {
            return await WorkOrderHeaderDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<WorkOrderHeader>> GetAllBy(Expression<Func<WorkOrderHeader, bool>> filter = null, Func<IEnumerable<WorkOrderHeader>, IOrderedEnumerable<WorkOrderHeader>> orderBy = null)
        {
            return await WorkOrderHeaderDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
