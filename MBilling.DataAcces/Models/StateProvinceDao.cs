using MBilling.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MBilling.DataAcces.Models
{
    public class StateProvinceDao
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        private Repository<StateProvince> StateProvinceDaoRepository;

        public StateProvinceDao()
        {
            StateProvinceDaoRepository = unitOfWork.Repository<StateProvince>();
        }

        public bool Validate(StateProvince _StateProvince, out List<string> lstMessages)
        {
            return StateProvinceDaoRepository.Validate(_StateProvince, out lstMessages);
        }

        public int Insert(StateProvince _StateProvince)
        {
            return StateProvinceDaoRepository.Insert(_StateProvince);
        }

        public int Update(StateProvince _StateProvince)
        {
            return StateProvinceDaoRepository.Update(_StateProvince);
        }

        public int Delete(StateProvince _StateProvince)
        {
            return StateProvinceDaoRepository.Delete(_StateProvince);
        }

        public async Task<StateProvince> GetById(int _id)
        {
            return await StateProvinceDaoRepository.GetById(_id);
        }

        public async Task<IEnumerable<StateProvince>> GetAll()
        {
            return await StateProvinceDaoRepository.GetAll();
        }

        public async Task<IEnumerable<StateProvince>> FindBy(Expression<Func<StateProvince, bool>> predicate)
        {
            return await StateProvinceDaoRepository.FindBy(predicate);
        }

        public async Task<IEnumerable<StateProvince>> GetAllBy(Expression<Func<StateProvince, bool>> filter = null, Func<IEnumerable<StateProvince>, IOrderedEnumerable<StateProvince>> orderBy = null)
        {
            return await StateProvinceDaoRepository.GetAllBy(filter, orderBy);
        }

    }
}
