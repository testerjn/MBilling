using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class PurchaseOrderTaxDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<PurchaseOrderTax> PurchaseOrderTaxDaoRepository;

        public PurchaseOrderTaxDao()
        {
            PurchaseOrderTaxDaoRepository = unitOfWork.Repository<PurchaseOrderTax>();
        }

        public bool Validate(PurchaseOrderTax _PurchaseOrderTax, out List<string> lstMessages)
        {
            return PurchaseOrderTaxDaoRepository.Validate(_PurchaseOrderTax, out lstMessages);
        }

        public int Insert(PurchaseOrderTax _PurchaseOrderTax)
        {
            return PurchaseOrderTaxDaoRepository.Insert(_PurchaseOrderTax);
        }

        public int Update(PurchaseOrderTax _PurchaseOrderTax)
        {
            return PurchaseOrderTaxDaoRepository.Update(_PurchaseOrderTax);
        }

        public int Delete(PurchaseOrderTax _PurchaseOrderTax)
        {
            return PurchaseOrderTaxDaoRepository.Delete(_PurchaseOrderTax);
        }

        public async Task<PurchaseOrderTax> GetById(int _id)
        {
            return await PurchaseOrderTaxDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<PurchaseOrderTax>> GetAll()
        {
            return await PurchaseOrderTaxDaoRepository.GetAll();
        }

        public async Task<IEnumerable<PurchaseOrderTax>> FindBy(Expression<Func<PurchaseOrderTax, bool>> predicate)
        {
            return await PurchaseOrderTaxDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<PurchaseOrderTax>> GetAllBy(Expression<Func<PurchaseOrderTax, bool>> filter = null, Func<IEnumerable<PurchaseOrderTax>, IOrderedEnumerable<PurchaseOrderTax>> orderBy = null)
        {
            return await PurchaseOrderTaxDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
