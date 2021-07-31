using System.Collections.Generic;
using System.Linq;
using Drugstore.Models;
using Namespace;

namespace Drugstore.Services
{
    public class DrugService : IDrugService
    {
        private readonly DataContext _context;
        public DrugService(DataContext context)
        {
            _context = context;
        }

        public void AddNewDrug(Drug drug)
        {
            _context.Drugs.Add(drug);
            _context.SaveChanges();
        }

        public void DeleteDrug(int Id)
        {
            var drug = GetDrugById(Id);
            if(drug ==null)
            {
                return ;
            }
            _context.Drugs.Remove(drug);
            _context.SaveChanges();
        }

        public void EditDrug(Drug drug)
        {
            var editDrug = GetDrugById(drug.Id);
            if(editDrug == null)
            {
                return;
            }
            editDrug.Name = drug.Name;
            editDrug.nhaSX = drug.nhaSX;
            editDrug.soLuong = drug.soLuong;

            _context.SaveChanges();
        }

        public Drug GetDrugById(int Id)
        {
            return _context.Drugs.FirstOrDefault(s => s.Id == Id);
        }

        public List<Drug> GetDrugs()
        {
             return _context.Drugs.ToList();
        }

        public List<Drug> SearchDrugs(string name)
        {
            var FilteredList = from x in _context.Drugs 
                   where x.Name.Contains (name)
                   select x;
            return (List<Drug>)FilteredList;
        }
    }
}