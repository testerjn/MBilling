using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class WorkOrderReceivedChallanHeaderDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<WorkOrderReceivedChallanHeader> WorkOrderReceivedChallanHeaderDaoRepository;

        public WorkOrderReceivedChallanHeaderDao()
        {
            WorkOrderReceivedChallanHeaderDaoRepository = unitOfWork.Repository<WorkOrderReceivedChallanHeader>();
        }

        public bool Validate(WorkOrderReceivedChallanHeader _WorkOrderReceivedChallanHeader, out List<string> lstMessages)
        {
            return WorkOrderReceivedChallanHeaderDaoRepository.Validate(_WorkOrderReceivedChallanHeader, out lstMessages);
        }

        public int Insert(WorkOrderReceivedChallanHeader _WorkOrderReceivedChallanHeader)
        {
            return WorkOrderReceivedChallanHeaderDaoRepository.Insert(_WorkOrderReceivedChallanHeader);
        }

        public int Update(WorkOrderReceivedChallanHeader _WorkOrderReceivedChallanHeader)
        {
            return WorkOrderReceivedChallanHeaderDaoRepository.Update(_WorkOrderReceivedChallanHeader);
        }

        public int Delete(WorkOrderReceivedChallanHeader _WorkOrderReceivedChallanHeader)
        {
            return WorkOrderReceivedChallanHeaderDaoRepository.Delete(_WorkOrderReceivedChallanHeader);
        }

        public async Task<WorkOrderReceivedChallanHeader> GetById(int _id)
        {
            return await WorkOrderReceivedChallanHeaderDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanHeader>> GetAll()
        {
            return await WorkOrderReceivedChallanHeaderDaoRepository.GetAll();
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanHeader>> FindBy(Expression<Func<WorkOrderReceivedChallanHeader, bool>> predicate)
        {
            return await WorkOrderReceivedChallanHeaderDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<WorkOrderReceivedChallanHeader>> GetAllBy(Expression<Func<WorkOrderReceivedChallanHeader, bool>> filter = null, Func<IEnumerable<WorkOrderReceivedChallanHeader>, IOrderedEnumerable<WorkOrderReceivedChallanHeader>> orderBy = null)
        {
            return await WorkOrderReceivedChallanHeaderDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
