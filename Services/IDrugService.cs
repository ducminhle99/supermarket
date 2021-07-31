using System;
using System.Collections.Generic;
using Drugstore.Models;

namespace Drugstore.Services
{
    public interface IDrugService
    {
        List<Drug> GetDrugs();
        List<Drug> SearchDrugs(String name);
         Drug GetDrugById(int Id);
         void AddNewDrug(Drug drug);
         void EditDrug(Drug drug);
         void DeleteDrug(int Id);

         
    }
}